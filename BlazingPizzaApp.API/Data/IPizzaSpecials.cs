using System.Collections.Generic;
using System.Threading.Tasks;
using BlazingPizzaApp.API.Models;

namespace BlazingPizzaApp.API.Data
{
    public interface IPizzaSpecials
    {
        Task<List<PizzaSpecial>> GetPizzaSpecialsAsync();
    }
}