using EnumsEComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnumsEComposicao.Entities
{
    public class Order
    {
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = DateTime.Now;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.subTotal(); 
            }
            return sum;
        }

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public OrderItem OrderItem { get; set; } = new OrderItem();
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; } = new Client();
    }
}
