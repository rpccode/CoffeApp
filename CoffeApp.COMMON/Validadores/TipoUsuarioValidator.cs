using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class TipoUsuarioValidator : GenericValidator<TipoUsuario>
    {
        public TipoUsuarioValidator()
        {
            RuleFor(t => t.Nombre).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(t => t.Descripcion).NotEmpty().NotNull().MaximumLength(200);


        }
    }
}
