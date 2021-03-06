using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class UsuarioValidator : GenericValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.NombreUsuario).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Password).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Nombre).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Apellido).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Foto).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Correo).NotNull().NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(u => u.Telefono).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.idTipoUsuario).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Credito).GreaterThanOrEqualTo(0);
         


        }
    }
}
