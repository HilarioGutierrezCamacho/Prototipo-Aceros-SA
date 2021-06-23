using PrototipoAcerosSA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IEmpleadosService
    {
        public Task<Empleado> Login(string ClaveUsuario, string Password);
        public Task<Empleado> GetEmpleadoByClave(string Clave);
        public Task<Empleado> GetEmpleadoById(int idEmpleado);
        public Task<List<Empleado>> GetTodosEmpleados();
    }
}