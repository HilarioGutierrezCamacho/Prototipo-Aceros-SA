using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Ubicacion
    {
        public int IdUbicacion { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public int IdAlmacen { get; set; }
        public int Estante { get; set; }
        public int Pasillo { get; set; }
        public int nivel { get; set; }
        public string Estatus { get; set; }

    }
}
