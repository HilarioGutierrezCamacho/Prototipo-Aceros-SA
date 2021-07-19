using PrototipoAcerosSA.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototipoAcerosSA.Data
{
    public interface IRequisicionService
    {
        Task<string> GenerateFolioRequisicion();
        Task<Requisicion> GetRequisicionByClave(string Clave);
        Task<Requisicion> GetRequisicionById(int IdRequisicion);
        Task<List<Requisicion>> GetTodasRequisiciones();
        Task<Requisicion> GuardarRequisiciona(Requisicion requisicion);
    }
}