using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IDevolucionService
    {
        public Task<List<DevolverFactura>> GetAllDevoluciones();
        public Task<DevolverFactura> GuardarDevolucion(DevolverFactura devolucion);
        public Task<DevolverFactura> TieneDevolucion(string FolioFactura);
    }
}
