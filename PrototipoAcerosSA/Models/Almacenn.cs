using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Almacenn
    {
        public int IdAlmacen { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public int Alto { get; set; }
        public string Estatus { get; set; }
        public string  Descripcion { get; set; }

    }
}
