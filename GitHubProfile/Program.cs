using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubProfile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var nickClient = RestService.For<IGitHubService>("https://api.github.com");
                Console.WriteLine("Informa o usuário: ");
                string nickname = Console.ReadLine().ToString();

                var address = await nickClient.GetAddressAsync(nickname);

                Console.Write($"\nNome: {address.Name}\nNome de usuário: {address.Login}\nSeguidores: {address.Followers}\n]Repositórios: {address.Public_Repos}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
