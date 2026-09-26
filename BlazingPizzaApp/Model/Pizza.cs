using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingPizzaApp.Model
{
    public class Pizza
    {
        public const int DefaultSize = 12;
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;

        public int Id { get; set; }
        public int OrderId { get; set; }
        public PizzaSpecial Special { get; set; }
        public int SpecialId { get; set; }
        public int Size { get; set; } = DefaultSize;
        public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();

        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice();
            // Jika ada topping nanti, hitung juga harga toppingnya di sini
            // return GetBasePrice() + Toppings.Sum(t => t.Topping.Price);
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}

