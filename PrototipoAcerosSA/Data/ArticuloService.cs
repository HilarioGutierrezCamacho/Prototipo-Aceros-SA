using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class ArticuloService : IArticuloService
    {

        public List<Articulo> articulos = new List<Articulo>();

        public ArticuloService()
        {
            articulos.Add(new Articulo() { IdArticulo = 1, Clave = "MP-ART-001", Descripcion = "Acero", Marca = "TRUPER", Almacen = "MP", Ubicacion = "PB", Unidad = "Pieza", PrecioUnitario = 50.50 });
            articulos.Add(new Articulo() { IdArticulo = 2, Clave = "VA-ART-002", Descripcion = "Libreta", Marca = "Patito", Almacen = "VA", Ubicacion = "PB", Unidad = "Pieza", PrecioUnitario = 10.50 });
            articulos.Add(new Articulo() { IdArticulo = 3, Clave = "RF-ART-004", Descripcion = "Tornillos", Marca = "TRUPER", Almacen = "RF", Ubicacion = "PB", Unidad = "Caja", PrecioUnitario = 25.75 });
        }

        public async Task<List<Articulo>> GetTodosArticulos()
        {
            return articulos;
        }

        public async Task<Articulo> GetArticuloById(int IdArticulo)
        {
            Articulo articulo = null;
            foreach (var art in articulos)
            {
                if (art.IdArticulo == IdArticulo)
                {
                    articulo = art;
                }
            }
            return articulo;
        }

        public async Task<Articulo> GetArticuloByClave(string Clave)
        {
            Articulo articulo = null;
            foreach (var art in articulos)
            {
                if (art.Clave == Clave)
                {
                    articulo = art;
                }
            }
            return articulo;
        }

        public async Task<Articulo> AddArticulo()
        {
            var articulo = new Articulo() { IdArticulo = 4, Clave = "RF-ART-004", Descripcion = "Tornillos", Marca = "TRUPER", Almacen = "RF", Ubicacion = "PB", Unidad = "Caja", PrecioUnitario = 25.75 };
            articulos.Add(articulo);
            return articulo;
        }
    }
}
