using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public string FolioFactura { get; set; }
        public Proveedor Proveedor { get; set; } = new Proveedor();
        public string FechaCaptura { get; set; }
        public string Comentarios { get; set; }
        public Double Subtotal { get; set; }
        public Double Descuento { get; set; }
        public Double IVA { get; set; }
        public Double TotalFactura { get; set; }
        public FormaPago FormaPago { get; set; } = new FormaPago();
        public List<DetalleFactura> DetallesFactura { get; set; } = new List<DetalleFactura>();
    }
}
