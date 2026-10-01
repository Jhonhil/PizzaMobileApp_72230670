using BlazingPizzaApp.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

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
                // Try the primary endpoint first
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

                // Return empty list instead of throwing to prevent crashes
                return new List<PizzaSpecial>();
            }
        }
    }
}
