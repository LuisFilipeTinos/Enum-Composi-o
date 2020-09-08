using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Desafio_Enumeração_Composição.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product ProductInfo { get; set; }

        public OrderItem(int quantity, double price, Product productInfo)
        {
            Quantity = quantity;
            Price = price;
            ProductInfo = productInfo;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return ProductInfo.Name + ", $" +
                ProductInfo.Price.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + "Quantity: " + Quantity + ", " + "SubTotal: $" + 
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
