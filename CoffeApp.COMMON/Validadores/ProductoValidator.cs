using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class ProductoValidator : GenericValidator<Producto>
    {
        public ProductoValidator()
        {
            RuleFor(p => p.Nombre).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Descripcion).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Foto).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Costo).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(p => p.idCategoria).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.EsPreparado).NotNull().NotEmpty();
            RuleFor(p => p.Stock).NotNull().NotEmpty();
            RuleFor(p => p.EstaEnVenta).NotNull().NotEmpty();

        }
    }
}
