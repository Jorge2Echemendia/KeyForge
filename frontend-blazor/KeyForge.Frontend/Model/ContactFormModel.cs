// Models/ContactFormModel.cs
using System.ComponentModel.DataAnnotations;

namespace KeyForge.Frontend.Model;

public class ContactFormModel
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Correo electrónico no válido")]
    public string Email { get; set; } = string.Empty;
    [Phone(ErrorMessage = "Deben ser numeros")]
    public int Telefono { get; set; }

    [Required(ErrorMessage = "Selecciona un asunto")]
    public string? Asunto { get; set; }

    [Required(ErrorMessage = "El mensaje es obligatorio")]
    [StringLength(500, ErrorMessage = "El mensaje no puede superar los 500 caracteres")]
    public string Mensaje { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debes aceptar los términos")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "Debes aceptar los términos")]
    public bool AceptaTerminos { get; set; }
}