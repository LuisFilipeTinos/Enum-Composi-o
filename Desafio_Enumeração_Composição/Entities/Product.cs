using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Enumeração_Composição.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            
        }
    }
}
