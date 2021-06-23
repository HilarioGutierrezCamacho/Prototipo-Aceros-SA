using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int IdAlmacen { get; set; }
        public string Almacen { get; set; }
        public int IdUbicacion { get; set; }
        public string Ubicacion { get; set; }
        public int IdUnidad { get; set; }
        public string Unidad { get; set; }
        public Double PrecioUnitario { get; set; }
        public int Maximo { get; set; }
        public int PuntoReorden { get; set; }
        public int Minimo { get; set; }
    }
}
