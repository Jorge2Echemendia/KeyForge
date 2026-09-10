// Services/ProductService.cs
using System.Net.Http.Json;
using KeyForge.Frontend.Model;

namespace KeyForge.Frontend.Services;

public class ProductService
{
    private readonly HttpClient _http;
    private readonly ILogger<ProductService> _logger;

    public ProductService(HttpClient http, ILogger<ProductService> logger)
    {
        _http = http;
        _logger = logger;
    }

    public async Task<List<Producto>?> GetProductosAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<Producto>>("/api/productos");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener productos");
            return null;
        }
    }

    public async Task<Producto?> GetProductoByIdAsync(int id)
    {
        var productos = await GetProductosAsync();
        return productos?.FirstOrDefault(p => p.id == id);
    }

}
