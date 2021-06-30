using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models.Validadores
{
    public class ValidadorMaximosMinimos : AbstractValidator<Articulo>
    {
        public ValidadorMaximosMinimos()
        {
            RuleFor(x => x.Minimo).LessThan(x => x.Maximo).WithMessage("El minimo debe ser menor al maximo.");
            RuleFor(x => x.Maximo).GreaterThan(x => x.Minimo).WithMessage("El maximo debe ser mayor al minimo.");
            RuleFor(x => x.PuntoReorden).GreaterThan(x => x.Minimo).LessThan(x => x.Maximo);
        }
    }
}
