using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desafio_Enumeração_Composição.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderS { get; set; }
        public Client ClientInfo { get; set; }
        public List<OrderItem> List { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus orderS, Client clientInfo)
        {
            Moment = moment;
            OrderS = orderS;
            ClientInfo = clientInfo;
        }
    
        public void AddItem(OrderItem orderItem)
        {
            List.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            List.Remove(orderItem);
        }
    
        public double Total()
        {
            double sum = 0;

            foreach (OrderItem obj in List)
            {
                sum = sum + obj.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARRY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(OrderS.ToString());
            sb.Append("Client: ");
            sb.Append(ClientInfo.Name);
            sb.Append(" (" + ClientInfo.BirthDate + ")" + " - ");
            sb.AppendLine(ClientInfo.Email);
            sb.AppendLine("Order items");
            foreach(OrderItem obj in List)
            {
                sb.AppendLine(obj.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
