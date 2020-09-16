using Estudo_Refit.Models;
using Refit;
using System.Threading.Tasks;

namespace Estudo_Refit.Interfaces
{
    public interface ICepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepModel> GetAddressAsync(string cep);
    }
}