using KeyForge.Frontend.Model;
namespace KeyForge.Frontend.Services
{
    public class CartService
    {
        private readonly List<CartItem> _items = new();

        
        public IReadOnlyList<CartItem> Items => _items;

        
        public event Action? OnChange;

        
        public void AddItem(Producto product, int quantity = 1)
        {
            if (quantity <= 0) return;

            var existing = _items.FirstOrDefault(i => i.ProductId == product.id);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _items.Add(new CartItem
                {
                    ProductId = product.id,
                    Product = product,
                    Quantity = quantity
                });
            }

            NotifyStateChanged();
        }

        
        public void RemoveItem(int productId)
        {
            var item = _items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                _items.Remove(item);
                NotifyStateChanged();
            }
        }

        
        public void UpdateQuantity(int productId, int quantity)
        {
            var item = _items.FirstOrDefault(i => i.ProductId == productId);
            if (item == null) return;

            if (quantity <= 0)
            {
                _items.Remove(item);
            }
            else
            {
                item.Quantity = quantity;
            }

            NotifyStateChanged();
        }

        
        public void ClearCart()
        {
            _items.Clear();
            NotifyStateChanged();
        }

        
        public int GetTotalItems() => _items.Sum(i => i.Quantity);

        
        public decimal GetTotalPrice() => _items.Sum(i => i.Product.precio * i.Quantity);

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}