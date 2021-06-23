using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class EmpleadosService : IEmpleadosService
    {
        public List<Empleado> empleados = new List<Empleado>();

        public EmpleadosService()
        {
            empleados.Add(new Empleado() { IdEmpleado = 1, Clave = "ALM-EMP-001", Nombre = "HILARIO GUTIERREZ  CAMACHO", Area = "ALMACEN", Password = "HIL0015" });
            empleados.Add(new Empleado() { IdEmpleado = 2, Clave = "ADM-EMP-002", Nombre = "MARTINEZ HERNANDEZ PEDRO", Area = "ADMINISTRADOR", Password = "PED8821" });
            empleados.Add(new Empleado() { IdEmpleado = 3, Clave = "CCOS-EMP-004", Nombre = "JOSÉ EVERARDO CENOBIO SANTIAGO", Area = "CENTRO DE COSTOS", Password = "EVER1233" });
        }

        public async Task<List<Empleado>> GetTodosEmpleados()
        {
            return empleados;
        }

        public async Task<Empleado> GetEmpleadoById(int idEmpleado)
        {
            Empleado empleado = null;
            foreach (var art in empleados)
            {
                if (art.IdEmpleado == idEmpleado)
                {
                    empleado = art;
                }
            }
            return empleado;
        }

        public async Task<Empleado> GetEmpleadoByClave(string Clave)
        {
            Empleado empleado = null;
            foreach (var art in empleados)
            {
                if (art.Clave == Clave)
                {
                    empleado = art;
                }
            }
            return empleado;
        }

        public async Task<Empleado> Login(string ClaveUsuario, string Password)
        {
            Empleado empleado = null;
            foreach (var art in empleados)
            {
                if (art.Clave == ClaveUsuario && art.Password == Password)
                {
                    empleado = art;
                }
            }
            return empleado;
        }
    }
}
