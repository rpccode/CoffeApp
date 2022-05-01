using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
    public  class ElementoEnMenuValidator: GenericValidator<ElementoEnMenu>
    {
        public ElementoEnMenuValidator()
        {
            RuleFor(e => e.idMenuComidaCorrida).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(e => e.idProducto).NotEmpty().NotNull().MaximumLength(50);

        }
    }
}
