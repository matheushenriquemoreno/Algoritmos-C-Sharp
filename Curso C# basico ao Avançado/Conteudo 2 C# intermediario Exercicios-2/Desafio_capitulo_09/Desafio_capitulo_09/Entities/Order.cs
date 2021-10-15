using System;
using System.Collections.Generic;
using System.Text;
using Desafio_capitulo_09.Entities.Enum;

namespace Desafio_capitulo_09.Entities
{
    class Order
    {
        public DateTime Momente { get; set; }
        public OrderStatus Status { get; set; }

        public Client Cliente { get; set; }
        public List<OrderItem> OrderList { get; set; } = new List<OrderItem>();


        public Order(DateTime date, OrderStatus order, Client c)
        {
            Momente = date;
            Status = order;
            Cliente = c;
        }
        

        public void AddItem(OrderItem order)
        {
            OrderList.Add(order);
        }

        public void RemoveItem(OrderItem order)
        {
            OrderList.Remove(order);
        }

        public  double Total()
        {
            double total = 0;
            foreach(OrderItem or in OrderList)
            {
                total = or.Price * or.Quantidade;
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment " + Momente);
            sb.AppendLine("Oder status: " + Status);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Orders items: ");
            foreach(OrderItem or in OrderList){
                sb.AppendLine($"{or.Produto.Name} , ${or.Price} Quantity: {or.Quantidade}, Subtotal: {or.SubTotal()}");
            }
            return sb.ToString();
        }

    }
}
