using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Models
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        [Required(ErrorMessage = "La clave del articulo es requerida.")]
        public string Clave { get; set; }
        [Required(ErrorMessage = "La descripcion del articulo es requerida.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La marca del articulo es requerida.")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El almacén es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un almacén.")]
        public int IdAlmacen { get; set; }
        public Almacenn Almacen { get; set; }
        [Required(ErrorMessage = "La ubicación es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una ubicación.")]
        public int IdUbicacion { get; set; }
        public Ubicacion Ubicacion { get; set; }
        [Required(ErrorMessage = "La unidad es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una unidad.")]
        public int IdUnidad { get; set; }
        public Unidad Unidad { get; set; } = new Unidad();
        [Required(ErrorMessage = "El precio unitario es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El precio unitario debe ser mayor a 0")]
        public Double PrecioUnitario { get; set; }
        [Required(ErrorMessage = "El maximo es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El maximo debe ser mayor a 0")]
        public int Maximo { get; set; }
        [Required(ErrorMessage = "El punto de reorden es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El punto de reorden debe ser mayor a 0")]
        public int PuntoReorden { get; set; }
        [Required(ErrorMessage = "El minimo es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El minimo debe ser mayor a 0")]
        public int Minimo { get; set; }
        public bool Estatus { get; set; } = true;
    }
}
