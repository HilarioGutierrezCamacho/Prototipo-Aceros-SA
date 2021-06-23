using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "La clave de usuario es requerida.")]
        public string ClaveUsuario { get; set; }
        [Required(ErrorMessage = "El password es requerido.")]
        public string Password { get; set; }
    }
}
