using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class MenuComidaCorridaValidator : GenericValidator<MenuComidaCorrida>
    {
        public MenuComidaCorridaValidator()
        {
            RuleFor(m => m.Nombre).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(m => m.Foto).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(m => m.Costo).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(m => m.EstaEnVenta).NotNull();
            RuleFor(m => m.Descripcion).NotNull().NotEmpty();




        }
    }
}
