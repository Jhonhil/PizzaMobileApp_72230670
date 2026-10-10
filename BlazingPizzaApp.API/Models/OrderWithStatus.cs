using System;

namespace BlazingPizzaApp.API.Models
{
    public class OrderWithStatus
    {
        public Order Order { get; set; } = new Order();
        public string StatusText { get; set; } = string.Empty;

        public static OrderWithStatus FromOrder(Order order)
        {
            string status;
            var dispatchTime = order.CreatedTime.AddSeconds(10);

            if (DateTime.Now < dispatchTime)
            {
                status = "Preparing";
            }
            else if (DateTime.Now < dispatchTime.AddMinutes(1))
            {
                status = "Out for delivery";
            }
            else
            {
                status = "Delivered";
            }

            return new OrderWithStatus
            {
                Order = order,
                StatusText = status
            };
        }
    }
}