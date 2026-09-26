using System;
using System.Collections.Generic;
using System.Text;
using BlazingPizzaApp.Model;

namespace BlazingPizzaApp.Data
{
    public class OrderState
    {
        public Order Order { get; private set; } = new Order();

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }
    }
}
