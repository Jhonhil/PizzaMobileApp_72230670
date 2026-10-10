using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizzaApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaApp.API.Data
{
    public class PizzaSpecialsDAL : IPizzaSpecials
    {
        private readonly PizzaStoreContext _db;

        public PizzaSpecialsDAL(PizzaStoreContext db)
        {
            _db = db;
        }

        public async Task<List<PizzaSpecial>> GetPizzaSpecialsAsync()
        {
            return await _db.Specials.OrderByDescending(s => s.BasePrice).ToListAsync();
        }
    }
}