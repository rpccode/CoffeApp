using System;
using System.Collections.Generic;
using System.Text;
using CoffeApp.COMMON.Entidades;
using FluentValidation;

namespace CoffeApp.COMMON.Validadores
{
  public abstract class GenericValidator<T> : AbstractValidator<T> where T:BaseDTO 
    {
        public GenericValidator()
        {
            RuleFor(c => c.id).NotNull().NotEmpty()
                              .MaximumLength(50)
                              .WithMessage("El valor del ID no puede ser Nulo o exeder 50 caracteres");
        }
    }
}
