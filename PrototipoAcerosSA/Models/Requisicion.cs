using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Requisicion
    {
        public string FolioRequisicion { get; set; }
        public Proveedor Proveedor { get; set; }

        public string ClaveResponsable { get; set; }
        public string NombreResponsable { get; set; }
        public string FirmaResponsable { get; set; }
        public string ClaveSolicitante { get; set; }
        public string NombreSolicitante { get; set; }
        public string FirmaSolicitante { get; set; }
        public string ClaveResponsableCentroCostos { get; set; }
        public string NombreResponsableCentroCostos { get; set; }
        public string FirmaResponsableCentroCostos { get; set; }
        public DateTime? FechaCaptura { get; set; }
        public DateTime? FechaRecibido { get; set; }
        public FormaPago FormaPago { get; set; } = new FormaPago();
        public string Observaciones { get; set; }
        public Double Subtotal { get; set; }
        public Double Descuento { get; set; }
        public Double IVA { get; set; }
        public Double TotalRequisicion { get; set; }
        
        public List<DetalleRequisicion> DetallesRequisicion { get; set; } = new List<DetalleRequisicion>();
    }
}
