using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class FormaPagoService : IFormaPagoService
    {
        public List<FormaPago> FormasPago = new List<FormaPago>();

        public FormaPagoService()
        {
            FormasPago.Add(new FormaPago() { IdFormaPago = 1, Descripcion = "Tarjeta de Credito" });
            FormasPago.Add(new FormaPago() { IdFormaPago = 2, Descripcion = "Tarjeta de Debito" });
            FormasPago.Add(new FormaPago() { IdFormaPago = 3, Descripcion = "Pago Fisico" });
        }

        public async Task<List<FormaPago>> GetTodasFormaPago()
        {
            return FormasPago;
        }

        public async Task<FormaPago> GetFormaPagoById(int IdFormaPago)
        {
            FormaPago formaPago = null;
            foreach (var pago in FormasPago)
            {
                if (pago.IdFormaPago == IdFormaPago)
                {
                    formaPago = pago;
                }
            }
            return formaPago;
        }

    }
}
