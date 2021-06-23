using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string CP { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Rfc { get; set; }
    }
}
