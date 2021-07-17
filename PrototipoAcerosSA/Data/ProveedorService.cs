using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public class ProveedorService : IProveedorService
    {

        public List<Proveedor> Proveedores = new List<Proveedor>();

        public ProveedorService()
        {
            Proveedores.Add(new Proveedor() { IdProveedor = 1, Clave = "TRP01", Nombre = "Truper", Ciudad = "Zitacuaro", Pais = "México", Direccion = "Ocampo Ote # 50", CP = "60122", Email = "truper@mail.com", Telefono = "45676858", Rfc = "TRP98227U", IVA = 0.16 });
            Proveedores.Add(new Proveedor() { IdProveedor = 2, Clave = "TRP01", Nombre = "Aceros SA", Ciudad = "Morelia", Pais = "México", Direccion = "Morelos Ote # 50", CP = "60122", Email = "aceros@mail.com", Telefono = "45676858", Rfc = "ACRS98227U", IVA = 0.16 });
            Proveedores.Add(new Proveedor() { IdProveedor = 3, Clave = "TRP01", Nombre = "Refineria Margarita", Ciudad = "Morelos", Pais = "México", Direccion = "Av. Hidalgo Ote # 50", CP = "60123", Email = "refineria@mail.com", Telefono = "45676858", Rfc = "RFNR98227U", IVA = 0.16 });
        }

        public async Task<List<Proveedor>> GetTodosProveedores()
        {
            return Proveedores;
        }

        public async Task<Proveedor> GetProveedorById(int IdProveedor)
        {
            Proveedor proveedor = null;
            foreach (var prov in Proveedores)
            {
                if (prov.IdProveedor == IdProveedor)
                {
                    proveedor = prov;
                }
            }
            return proveedor;
        }

    }
}
