using BlazingPizzaApp.API.Models;

namespace BlazingPizzaApp.Model
{
    public class PizzaTopping
    {
        public int ToppingId { get; set; }
        public int PizzaId { get; set; }
        public Topping Topping { get; set; } = null!;
        public Pizza Pizza { get; set; } = null!;
    }
}