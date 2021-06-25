using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class UnidadService : IUnidadService
    {

        public List<Unidad> unidades = new List<Unidad>();

        public UnidadService()
        {
            unidades.Add(new Unidad() { IdUnidad = 1, Clave = "CAJ-UNI-001", Nombre = "Caja", Descripcion = "Caja", Estatus = "Activo" });
            unidades.Add(new Unidad() { IdUnidad = 2, Clave = "PZA-UNI-002", Nombre = "Pieza", Descripcion = "Pieza", Estatus = "Activo" });
            unidades.Add(new Unidad() { IdUnidad = 3, Clave = "FRA-UNI-003", Nombre = "Botella", Descripcion = "Botella", Estatus = "Activo" });
        }

        public async Task<List<Unidad>> GetTodosUnidades()
        {
            return unidades;
        }

        public async Task<Unidad> GetAlmacenById(int IdUnidad)
        {
            Unidad unidad = null;
            foreach (var uni in unidades)
            {
                if (uni.IdUnidad == IdUnidad)
                {
                    unidad = uni;
                }
            }
            return unidad;
        }

        public async Task<Unidad> GetUnidadByClave(string Clave)
        {
            Unidad unidad = null;
            foreach (var uni in unidades)
            {
                if (uni.Clave == Clave)
                {
                    unidad = uni;
                }
            }
            return unidad;
        }

        public async Task<Unidad> AddUnidad(string clave, string nombre, string descripcion, string estatus)
        {
            
            var idIncrementable = unidades.LastOrDefault().IdUnidad+1;
            var nuevaUnidad = new Unidad()
            {
                IdUnidad = idIncrementable,
                Clave = clave,
                Nombre = nombre,
                Descripcion = descripcion,
                Estatus = estatus
            };
            unidades.Add(nuevaUnidad);
            return nuevaUnidad;
        }

        public async Task<Unidad> UpdateUnidad(int IdUnidad, string clave, string nombre, string descripcion, string estatus)
        {
            var modificaUnidad = new Unidad()
            {
                IdUnidad = IdUnidad,
                Clave = clave,
                Nombre = nombre,
                Descripcion = descripcion,
                Estatus = estatus,
            };
            unidades[unidades.FindIndex(index => index.IdUnidad == modificaUnidad.IdUnidad)] = modificaUnidad;
            return modificaUnidad;
        }
    }
}
