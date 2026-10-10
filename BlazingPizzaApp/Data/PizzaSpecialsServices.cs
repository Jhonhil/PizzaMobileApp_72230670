using BlazingPizzaApp.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace BlazingPizzaApp.Data
{
    public class PizzaSpecialsServices : IPizzaSpecials
    {
        private readonly HttpClient _httpClient;

        public PizzaSpecialsServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PizzaSpecial>> GetPizzaSpecialsAsync()
        {
            try
            {
                // Disesuaikan ke "api/specials" sesuai rute controller API
                var specials = await _httpClient.GetFromJsonAsync<List<PizzaSpecial>>("api/specials");

                if (specials == null || specials.Count == 0)
                {
                    System.Diagnostics.Debug.WriteLine("No specials returned from API");
                    return new List<PizzaSpecial>();
                }

                System.Diagnostics.Debug.WriteLine($"Successfully loaded {specials.Count} pizza specials");
                return specials;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error retrieving pizza specials: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                return new List<PizzaSpecial>();
            }
        }
    }
}