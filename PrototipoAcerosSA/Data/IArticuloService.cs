using PrototipoAcerosSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IArticuloService
    {
        public Task<List<Articulo>> GetTodosArticulos();
        public Task<Articulo> GetArticuloById(int IdArticulo);
        public Task<Articulo> GetArticuloByClave(string Clave);
        public Task<Articulo> AddArticulo();

    }
}
