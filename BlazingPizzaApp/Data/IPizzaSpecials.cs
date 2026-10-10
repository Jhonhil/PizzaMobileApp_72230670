using System.Collections.Generic;
using System.Threading.Tasks;
using BlazingPizzaApp.Model; // Menggunakan model Frontend

namespace BlazingPizzaApp.Data
{
    public interface IPizzaSpecials
    {
        Task<List<PizzaSpecial>> GetPizzaSpecialsAsync();
    }
}