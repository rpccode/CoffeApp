using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class PaqueteValidator : GenericValidator<Paquete>
    {
        public PaqueteValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(p => p.Costo).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(p => p.Descripcion).NotEmpty().NotNull();


        }
    }
}
