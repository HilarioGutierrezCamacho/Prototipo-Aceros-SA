using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IFormaPagoService
    {
        public Task<List<FormaPago>> GetTodasFormaPago();
        public Task<FormaPago> GetFormaPagoById(int IdFormaPago);
    }
}
