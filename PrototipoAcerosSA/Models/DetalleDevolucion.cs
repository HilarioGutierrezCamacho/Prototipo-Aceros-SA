using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class DetalleDevolucion
    {
        public Articulo Articulo { get; set; }
        public string Unidad { get; set; }
        public int CantidadDevolver { get; set; }
        public int CantidadAnterior { get; set; }
        public Double PrecioUnitario { get; set; }
        public Double Subtotal { get; set; }
        public Double IVA { get; set; }
        public Double TotalConIVA { get; set; }
    }
}
