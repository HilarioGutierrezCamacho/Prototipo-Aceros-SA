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
        public Task<string> GenerateFolioFactura();
        public Task<Factura> GuardarFactura(Factura factura);
        public Task<Factura> GetFacturaByClave(string Clave);
        public Task<Factura> EditarFactura(Factura factura);
        public Task<List<ArticuloValor>> GetProductosValor(string mes, string año);
        public Task<List<ArticuloUnidad>> GetProductosUnidad(string mes, string año);
    }
}
