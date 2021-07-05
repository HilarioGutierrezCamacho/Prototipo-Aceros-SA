using PrototipoAcerosSA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IUnidadService
    {
       
        Task<Unidad> AddUnidad(string clave, string nombre, string estatus);
        Task<Unidad> GetAlmacenById(int IdUnidad);
        Task<List<Unidad>> GetTodosUnidades();
        Task<Unidad> GetUnidadByClave(string Clave);
        Task<Unidad> UpdateUnidad(int IdUnidad, string clave, string nombre, string estatus);
    }
}