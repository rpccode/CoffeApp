using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class ProductosEnVentaValidator : GenericValidator<ProductosEnVenta>
    {
        public ProductosEnVentaValidator()
        {
            RuleFor(p => p.idVenta).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.idProducto).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.idMenu).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.idPaquete).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Cantidad).NotNull().NotEmpty();
            RuleFor(p => p.Costo).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(p => p.Preparando).NotNull().NotEmpty();
            RuleFor(p => p.Preparado).NotNull().NotEmpty();
            RuleFor(p => p.Entregado).NotNull().NotEmpty();



        }
    }
}
