using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PrototipoAcerosSA.Models
{
    public class Almacenn
    {
        public int IdAlmacen { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        public string Clave { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        public string Nombre { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public int Alto { get; set; }
        [Required(ErrorMessage = "Campo requerido.")]
        public string Estatus { get; set; }
        public string  Descripcion { get; set; }

    }
}
