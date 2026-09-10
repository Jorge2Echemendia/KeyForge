// Models/CartItem.cs
using KeyForge.Frontend.Model;

namespace KeyForge.Frontend.Model;

public class CartItem
{
    public int ProductId { get; set; }
    public Producto Product { get; set; } = new();    public int Quantity { get; set; }

    public decimal Subtotal => Product?.precio * Quantity ?? 0;
}
