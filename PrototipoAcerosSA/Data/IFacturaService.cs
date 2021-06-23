using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IFacturaService
    {
        public Task<List<Factura>> GetTodasFacturas();
        public Task<Factura> GetFacturaById(int IdFactura);
    }
}
