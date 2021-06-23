using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IProveedorService
    {
        public Task<List<Proveedor>> GetTodosProveedores();
        public Task<Proveedor> GetProveedorById(int IdProveedor);
    }
}
