using Microsoft.AspNetCore.Components;
using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class ArticuloService : IArticuloService
    {
        private readonly IAlmacenService _almacenService;
        private readonly IUnidadService _unidadService;
        private readonly IUbicacionService _ubicacionService;

        public List<Articulo> articulos = new List<Articulo>();

        public ArticuloService(IAlmacenService almacenService, IUnidadService unidadService, IUbicacionService ubicacionService)
        {
            _almacenService = almacenService;
            _unidadService = unidadService;
            _ubicacionService = ubicacionService;
            InicializarArticulos();
        }

        public async Task<List<Articulo>> GetTodosArticulos()
        {
            return articulos.Where(articulo => articulo.Estatus == true).ToList();
        }

        public async Task InicializarArticulos()
        {
            articulos.Add(new Articulo() { 
                IdArticulo = 1, 
                Clave = "MP-ART-001", 
                Descripcion = "Acero", 
                Marca = "TRUPER", 
                IdAlmacen = 1, 
                Almacen = await _almacenService.GetAlmacenById(1), 
                IdUbicacion = 1, 
                Ubicacion = await _ubicacionService.GetUbicacionById(1), 
                IdUnidad = 2, 
                Unidad = await _unidadService.GetAlmacenById(2), 
                PrecioUnitario = 50.50, 
                Estatus = true });
            articulos.Add(new Articulo() { 
                IdArticulo = 2, 
                Clave = "VA-ART-002", 
                Descripcion = "Libreta", 
                Marca = "Patito", 
                IdAlmacen = 2, 
                Almacen = await _almacenService.GetAlmacenById(2), 
                IdUbicacion = 1, 
                Ubicacion = await _ubicacionService.GetUbicacionById(1), 
                IdUnidad = 2, 
                Unidad = await _unidadService.GetAlmacenById(2), 
                PrecioUnitario = 10.50, 
                Estatus = true });
            articulos.Add(new Articulo() { 
                IdArticulo = 3, 
                Clave = "RF-ART-004", 
                Descripcion = "Tornillos", 
                Marca = "TRUPER", 
                IdAlmacen = 3, 
                Almacen = await _almacenService.GetAlmacenById(3), 
                IdUbicacion = 1, 
                Ubicacion = await _ubicacionService.GetUbicacionById(1), 
                IdUnidad = 1, 
                Unidad = await _unidadService.GetAlmacenById(1), 
                PrecioUnitario = 25.75, 
                Estatus = true });
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
            articulo.Almacen = await _almacenService.GetAlmacenById(articulo.IdAlmacen);
            articulo.Ubicacion = await _ubicacionService.GetUbicacionById(articulo.IdUbicacion);
            articulo.Unidad = await _unidadService.GetAlmacenById(articulo.IdUnidad);
            articulos.Add(articulo);
            return articulo;
        }

        public async Task<Articulo> EditarArticulo(Articulo articulo)
        {
            articulo.Almacen = await _almacenService.GetAlmacenById(articulo.IdAlmacen);
            articulo.Ubicacion = await _ubicacionService.GetUbicacionById(articulo.IdUbicacion);
            articulo.Unidad = await _unidadService.GetAlmacenById(articulo.IdUnidad);
            articulos[articulos.FindIndex( index => index.IdArticulo == articulo.IdArticulo)] = articulo;
            return articulo;
        }

        public async Task<Articulo> EliminarArticulo(int IdArticulo)
        {
            articulos[articulos.FindIndex(index => index.IdArticulo == IdArticulo)].Estatus = false;
            return await GetArticuloById(IdArticulo);
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
