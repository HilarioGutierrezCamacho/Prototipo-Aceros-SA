using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models.Validadores
{
    public class ValidadorDetalleDevolucion : AbstractValidator<DetalleDevolucion>
    {
        public ValidadorDetalleDevolucion()
        {
            RuleFor(x => x.CantidadDevolver).GreaterThan(x => x.CantidadAnterior).WithMessage("La cantidad debe ser menor/igual a la actual.");
            RuleFor(x => x.CantidadDevolver).Empty().WithMessage("Debes agregar una cantidad");
            RuleFor(x => x.CantidadDevolver).LessThan(0).WithMessage("Valor incorrecto.");
        }
    }
}
