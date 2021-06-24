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
            articulos.Add(new Articulo() { IdArticulo = 1, Clave = "MP-ART-001", Descripcion = "Acero", Marca = "TRUPER", Almacen = "MP", Ubicacion = "PB",  PrecioUnitario = 50.50, Estatus = true });
            articulos.Add(new Articulo() { IdArticulo = 2, Clave = "VA-ART-002", Descripcion = "Libreta", Marca = "Patito", Almacen = "VA", Ubicacion = "PB",  PrecioUnitario = 10.50, Estatus = true });
            articulos.Add(new Articulo() { IdArticulo = 3, Clave = "RF-ART-004", Descripcion = "Tornillos", Marca = "TRUPER", Almacen = "RF", Ubicacion = "PB", PrecioUnitario = 25.75, Estatus = true });
        }

        public async Task<List<Articulo>> GetTodosArticulos()
        {
            return articulos.Where(articulo => articulo.Estatus == true).ToList();
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

        public async Task<Articulo> AddArticulo(Articulo articulo)
        {
            int lastId = articulos.Count() + 1;
            articulo.IdArticulo = lastId;
            articulos.Add(articulo);
            return articulo;
        }

        public async Task<Articulo> EditarArticulo(Articulo articulo)
        {
            articulos[articulos.FindIndex( index => index.IdArticulo == articulo.IdArticulo)] = articulo;
            return articulo;
        }

        public Task<Articulo> EliminarArticulo(int IdArticulo)
        {
            articulos[articulos.FindIndex(index => index.IdArticulo == IdArticulo)].Estatus = false;
            return GetArticuloById(IdArticulo);
        }

        /**** UTILS *****/

        private string GenerarNumeroArticulo()
        {
            int ceros = 5;
            int totalRegistros = articulos.Count();
            string cadena = "";
            for (int i = totalRegistros; i < ceros; i++)
            {
                cadena += "0";
            }
            return cadena + totalRegistros;
        }

    }
}
