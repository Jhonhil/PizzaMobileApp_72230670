using BlazingPizzaApp.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazingPizzaApp.Model // Gunakan BlazingPizzaApp.API.Models untuk proyek API
{
    public class Pizza
    {
        public const int DefaultSize = 12;
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;

        public int Id { get; set; }
        public int OrderId { get; set; }
        public PizzaSpecial Special { get; set; } = null!;
        public int SpecialId { get; set; }
        public int Size { get; set; } = DefaultSize;
        public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();

        public decimal GetBasePrice()
        {
            return Special == null ? 0 : ((decimal)Size / DefaultSize) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice() + Toppings.Sum(t => t.Topping?.Price ?? 0);
        }

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}