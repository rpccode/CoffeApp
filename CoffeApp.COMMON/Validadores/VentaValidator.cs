using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
   public class VentaValidator : GenericValidator<Venta>
    {
        public VentaValidator()
        {
            RuleFor(v => v.FechaHora).NotEmpty().NotNull();
            RuleFor(v => v.idCliente).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(v => v.idVendedor).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(v => v.EsVentaMovil).NotEmpty().NotNull();
            RuleFor(v => v.Monto).NotEmpty().NotNull().GreaterThan(0);


        }
    }
}
