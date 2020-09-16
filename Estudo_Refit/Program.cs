using Estudo_Refit.Interfaces;
using Refit;
using System;
using System.Threading.Tasks;

namespace Estudo_Refit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepService>("https://viacep.com.br");
            string meuCep = "09330806";
            Console.WriteLine("Consultando dados do Cep:" + meuCep);

            var address = await cepClient.GetAddressAsync(meuCep);

            Console.Write($"" +
                $"\nLocalidade:{address.Localidade}" +
                $"\nUnidade:{address.Unidade}" +
                $"\nLogradouro:{address.Logradouro}" +
                $"\nBairro:{address.Bairro}" +
                $"\nEstado:{address.Uf}" +
                $"\nCódigo Ibge:{address.Ibge}");
            Console.ReadKey();
        }
    }
}