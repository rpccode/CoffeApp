using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;
namespace CoffeApp.COMMON.Validadores
{
   public class ElementoEnPaqueteValidator : GenericValidator<ElementoEnPaquete>
    {
        public ElementoEnPaqueteValidator()
        {
            RuleFor(e => e.idPaquete).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(e => e.Foto).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(e => e.Cantidad).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(e => e.idProducto).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(e => e.idMenuComidaCorrida).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(e => e.Descripcion).NotEmpty().NotNull();

        }
    }
}
