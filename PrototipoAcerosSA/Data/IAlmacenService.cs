using PrototipoAcerosSA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IAlmacenService
    {
        Task<Almacenn> AddAlmacen(string clave, string nombre, int alto, int ancho, int largo, string estatus, string descripcion);
        Task<Almacenn> AddAlmacenModelo(Almacenn datos);
        Task<Almacenn> GetAlmacenByClave(string Clave);
        Task<Almacenn> GetAlmacenById(int IdAlmacen);
        Task<List<Almacenn>> GetTodosAlmacenes();
        Task<Almacenn> UpdateAlmacen(int IdAlmacen, string clave, string nombre, int alto, int ancho, int largo, string estatus, string descripcion);
    }
}