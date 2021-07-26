using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class ArticuloExistencia
    {
        public string ClaveArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Unidad { get; set; }
        public string Almacen { get; set; }
        public int Stock { get; set; }
    }
}
