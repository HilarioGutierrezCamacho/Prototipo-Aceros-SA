using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class UbicacionService : IUbicacionService
    {

        public List<Ubicacion> ubicaciones = new List<Ubicacion>();

        public UbicacionService()
        {
            ubicaciones.Add(new Ubicacion() { IdUbicacion = 1, Clave = "EST MV-001", Nombre = "Estante 1", IdAlmacen = 1, Pasillo = 1, Estante = 1, nivel = 3,  Estatus = "Activo"});
            ubicaciones.Add(new Ubicacion() { IdUbicacion = 2, Clave = "EST RF-002", Nombre = "Estante 2", IdAlmacen = 3, Pasillo = 3, Estante = 2, nivel = 0, Estatus = "Activo" });
            ubicaciones.Add(new Ubicacion() { IdUbicacion = 3, Clave = "EST VA-003", Nombre = "Estante 3", IdAlmacen = 2, Pasillo = 2, Estante = 1, nivel = 3, Estatus = "Activo" });
        }

        public async Task<List<Ubicacion>> GetTodosUbicacion()
        {
            return ubicaciones;
        }

        public async Task<Ubicacion> GetUbicacionById(int IdUbicacion)
        {
            Ubicacion ubicacion = null;
            foreach (var ubi in ubicaciones)
            {
                if (ubi.IdUbicacion == IdUbicacion)
                {
                    ubicacion = ubi;
                }
            }
            return ubicacion;
        }

        public async Task<Ubicacion> GetUbicacionByClave(string Clave)
        {
            Ubicacion ubicacion = null;
            foreach (var ubi in ubicaciones)
            {
                if (ubi.Clave == Clave)
                {
                    ubicacion = ubi;
                }
            }
            return ubicacion;
        }

        public async Task<Ubicacion> AddUbicacion(string clave, string nombre, int IdAlmacen, int numPasillo, int Estante, int Nivel, string estatus)
        {
            var idIncrementable = ubicaciones.LastOrDefault().IdUbicacion + 1;
            var nuevaUbicacion = new Ubicacion()
            {
                IdUbicacion = idIncrementable,
                Clave = clave,
                Nombre = nombre,
                IdAlmacen=IdAlmacen,
                Pasillo = numPasillo,
                Estante = Estante,
                nivel = Nivel,
                Estatus = estatus
            };
            ubicaciones.Add(nuevaUbicacion);
            return nuevaUbicacion;
        }

        public async Task<Ubicacion> UpdateAlmacen(int IdUbicacion, string clave, string nombre, int IdAlmacen, int numPasillo, int Estante, int Nivel, string estatus)
        {
            var modificarUbicacion = new Ubicacion()
            {
                IdUbicacion = IdUbicacion,
                Clave = clave,
                Nombre = nombre,
                IdAlmacen = IdAlmacen,
                Pasillo = numPasillo,
                Estante = Estante,
                nivel = Nivel,
                Estatus = estatus
            };
            ubicaciones[ubicaciones.FindIndex(index => index.IdUbicacion == modificarUbicacion.IdUbicacion)] = modificarUbicacion;
            return modificarUbicacion;
        }
    }
}
