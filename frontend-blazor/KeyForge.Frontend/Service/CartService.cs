// Services/CartService.cs
using KeyForge.Frontend.Model; // Asegúrate de que apunte a donde está tu clase Producto

namespace KeyForge.Frontend.Services
{
    public class CartService
    {
        private readonly List<CartItem> _items = new();

        // Propiedad de solo lectura para que las páginas vean los items
        public IReadOnlyList<CartItem> Items => _items;

        // Evento para notificar a la UI que el carrito cambió
        public event Action? OnChange;

        // Agregar o sumar cantidad
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

        // Eliminar un producto completo
        public void RemoveItem(int productId)
        {
            var item = _items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                _items.Remove(item);
                NotifyStateChanged();
            }
        }

        // Actualizar cantidad de un item específico (si llega a 0, lo eliminamos)
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

        // Vaciar carrito
        public void ClearCart()
        {
            _items.Clear();
            NotifyStateChanged();
        }

        // Calcular total de items (ej: 3 productos)
        public int GetTotalItems() => _items.Sum(i => i.Quantity);

        // Calcular precio total
        public decimal GetTotalPrice() => _items.Sum(i => i.Product.precio * i.Quantity);

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}