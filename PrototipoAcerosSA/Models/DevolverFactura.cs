using System;
using System.Collections.Generic;
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
        public FormaPago FormaPago { get; set; } = new FormaPago();
        public Factura Factura { get; set; }
    }
}
