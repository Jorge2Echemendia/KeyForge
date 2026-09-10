
namespace KeyForge.Frontend.Model;

public class Review
{
    public int id { get; set; }
    public string ? nombre { get; set; }
    public string ? avatar { get; set; }
    public string ? fecha { get; set; }
    public double ? rating { get; set; }
    public bool verified { get; set; }
    public string ? titulo { get; set; }
    public string ? comentario { get; set; }
    public string ? producto { get; set; }
    public int utiles { get; set; }
    public List<string> imagenes { get; set; } = new();
}