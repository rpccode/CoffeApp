using CoffeApp.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
  public  class CategoriaProductoValidator :  GenericValidator<CategoriaProducto>
    {
        public CategoriaProductoValidator()
        {
            RuleFor(c => c.Nombre).NotNull().NotEmpty().WithMessage("El Nombre no Puede Quedar vacio").MaximumLength(50).WithMessage("El Nombre no puede superar los 50 caracteres");
            RuleFor(C => C.Descrpcion).NotNull().NotEmpty().WithMessage("La Descripcion no puede quedar vacia").MaximumLength(200);
        }
    }
}
