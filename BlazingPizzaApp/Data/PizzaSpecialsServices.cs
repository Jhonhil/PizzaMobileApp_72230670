using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazingPizzaApp.Model;

namespace BlazingPizzaApp.Data
{
    public class PizzaSpecialsServices : IPizzaSpecials
    {
        private readonly HttpClient _httpClient;

        public PizzaSpecialsServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PizzaSpecial>> GetPizzaSpecialsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials") ?? new List<PizzaSpecial>();
        }
    }
}