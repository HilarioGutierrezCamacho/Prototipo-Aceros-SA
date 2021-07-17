using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models.Validadores
{
    public class ValidadorFactura : AbstractValidator<Factura>
    {
        public ValidadorFactura()
        {
        }
    }
}
