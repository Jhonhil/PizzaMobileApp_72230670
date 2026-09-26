using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingPizzaApp.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice()
        {
            return Pizzas.Sum(p => p.GetTotalPrice());
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
