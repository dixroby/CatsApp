using System.Net.Http.Json;

namespace Cats.Models
{
    public class CatsModel : ICatsModel
    {
        readonly HttpClient Client;
        readonly CatsEndpoints Endpoints;
        public CatsModel(HttpClient client, CatsEndpoints endpoints)
        {
            Endpoints = endpoints;
            Client = client;
        }
        public async Task<IReadOnlyCollection<Cat>> GetCatsAsync() =>
            await Client.GetFromJsonAsync<IReadOnlyCollection<Cat>>(Endpoints.Cats);
        
    }
}