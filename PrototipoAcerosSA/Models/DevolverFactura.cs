using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class DevolverFactura
    {
        public int IdDevolucion { get; set; }
        public string FolioDevolucion { get; set; }
        public string FechaCaptura { get; set; }
        public string Comentarios { get; set; }
        public Double Subtotal { get; set; }
        public Double Descuento { get; set; }
        public Double IVA { get; set; }
        public Double TotalFactura { get; set; }
        [Required(ErrorMessage = "La forma de pago es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un almacén.")]
        public int IdFormaPago { get; set; }
        public FormaPago FormaPago { get; set; } = new FormaPago();
        public List<DetalleDevolucion> DetallesDevolucion { get; set; } = new List<DetalleDevolucion>();
        public Factura Factura { get; set; }
    }
}
