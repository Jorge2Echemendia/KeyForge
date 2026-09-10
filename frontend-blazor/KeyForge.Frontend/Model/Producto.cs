
namespace KeyForge.Frontend.Model;

public class Producto
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public decimal precio { get; set; }
    public string imagen { get; set; }
    public string categoria { get; set; }

    public string switches { get; set; }
    public string layout { get; set; }
    public List<string> caracteristicas { get; set; }
}