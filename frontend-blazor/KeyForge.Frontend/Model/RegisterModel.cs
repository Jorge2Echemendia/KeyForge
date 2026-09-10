using System.ComponentModel.DataAnnotations;
using FluentValidation;
namespace KeyForge.Frontend.Model;

public class RegisterModel
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = "";

    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Correo no válido")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [MinLength(6, ErrorMessage = "Mínimo 6 caracteres")]
    public string Password { get; set; } = "";

    [Required(ErrorMessage = "Confirma tu contraseña")]
    [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coinciden")]
    public string ConfirmPassword { get; set; } = "";

    [Required(ErrorMessage = "Debes aceptar los términos")]
    public bool AceptaTerminos { get; set; }
}

public class RegisterValidator : AbstractValidator<RegisterModel>
{
    public RegisterValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
        RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Las contraseñas no coinciden");
        RuleFor(x => x.AceptaTerminos).Must(x => x == true).WithMessage("Debes aceptar los términos");
    }
}