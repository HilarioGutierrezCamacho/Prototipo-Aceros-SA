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
            ubicaciones.Add(new Ubicacion() { IdUbicacion = 1, Clave = "UBI-MV-001", Nombre = "Estante 1", NumeroSecciones = 4, NumeroPasillo = 1, Alto = 50, Ancho = 30, Largo = 70, Estatus = "Activo", Descripcion = "Estante 1" });
            ubicaciones.Add(new Ubicacion() { IdUbicacion = 2, Clave = "UBI-RF-002", Nombre = "Estante 2", NumeroSecciones = 4, NumeroPasillo = 2, Alto = 50, Ancho = 30, Largo = 70, Estatus = "Activo", Descripcion = "Estante 2" });
            ubicaciones.Add(new Ubicacion() { IdUbicacion = 3, Clave = "UBI-VA-003", Nombre = "Estante 3", NumeroSecciones = 4, NumeroPasillo = 3, Alto = 50, Ancho = 30, Largo = 70, Estatus = "Activo", Descripcion = "Estante 3" });
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

        public async Task<Ubicacion> AddUbicacion(string clave, string nombre, int numSecciones, int numPasillo, int alto, int ancho, int largo, string descripcion, string estatus)
        {
            var idIncrementable = ubicaciones.LastOrDefault().IdUbicacion + 1;
            var nuevaUbicacion = new Ubicacion()
            {
                IdUbicacion = idIncrementable,
                Clave = clave,
                Nombre = nombre,
                NumeroSecciones = numSecciones,
                NumeroPasillo = numPasillo,
                Alto = alto,
                Ancho = ancho,
                Largo = largo,
                Descripcion = descripcion,
                Estatus = estatus
            };
            ubicaciones.Add(nuevaUbicacion);
            return nuevaUbicacion;
        }

        public async Task<Ubicacion> UpdateAlmacen(int IdUbicacion, string clave, string nombre, int numSecciones, int numPasillo, int alto, int ancho, int largo, string descripcion, string estatus)
        {
            var modificarUbicacion = new Ubicacion()
            {
                IdUbicacion = IdUbicacion,
                Clave = clave,
                Nombre = nombre,
                NumeroSecciones = numSecciones,
                NumeroPasillo = numPasillo,
                Alto = alto,
                Ancho = ancho,
                Largo = largo,
                Descripcion = descripcion,
                Estatus = estatus
            };
            ubicaciones[ubicaciones.FindIndex(index => index.IdUbicacion == modificarUbicacion.IdUbicacion)] = modificarUbicacion;
            return modificarUbicacion;
        }
    }
}
