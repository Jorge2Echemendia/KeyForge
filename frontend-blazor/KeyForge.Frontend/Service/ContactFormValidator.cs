// Services/ContactFormValidator.cs
using FluentValidation;
using KeyForge.Frontend.Model; // Necesitas instalar FluentValidation

public class ContactFormValidator : AbstractValidator<ContactFormModel>
{
    public ContactFormValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio");
        RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Correo no válido");
        RuleFor(x => x.Asunto).NotEmpty().WithMessage("Selecciona un asunto");
        RuleFor(x => x.Mensaje).NotEmpty().WithMessage("El mensaje es obligatorio");
        RuleFor(x => x.AceptaTerminos).Must(x => x == true).WithMessage("Debes aceptar los términos");
    }
}