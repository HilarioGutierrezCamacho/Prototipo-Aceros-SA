using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class DevolucionService : IDevolucionService
    {

        public List<DevolverFactura> devoluciones = new List<DevolverFactura>();

        public DevolucionService()
        {

        }

        public async Task<List<DevolverFactura>> GetAllDevoluciones()
        {
            return devoluciones;
        }

        public async Task<DevolverFactura> GuardarDevolucion(DevolverFactura devolucion)
        {
            devolucion.Subtotal = Math.Round(devolucion.Subtotal, 2);
            devolucion.TotalFactura = Math.Round(devolucion.TotalFactura, 2);
            devoluciones.Add(devolucion);
            return devolucion;
        }

        public async Task<DevolverFactura> TieneDevolucion(string FolioFactura)
        {
            DevolverFactura devolucion = null;
            devoluciones.ForEach(
                dev =>
                {
                    if (dev.Factura.FolioFactura == FolioFactura)
                    {
                        devolucion = dev;
                    }
                }
            );
            return devolucion;
        }
    }
}
