using PrototipoAcerosSA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IUbicacionService
    {
        Task<Ubicacion> AddUbicacion(string clave, string nombre, int numSecciones, int numPasillo, int alto, int ancho, int largo, string descripcion, string estatus);
        Task<List<Ubicacion>> GetTodosUbicacion();
        Task<Ubicacion> GetUbicacionByClave(string Clave);
        Task<Ubicacion> GetUbicacionById(int IdUbicacion);
        Task<Ubicacion> UpdateAlmacen(int IdUbicacion, string clave, string nombre, int numSecciones, int numPasillo, int alto, int ancho, int largo, string descripcion, string estatus);
    }
}