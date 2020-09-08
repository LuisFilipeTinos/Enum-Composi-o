using System;
using System.Globalization;
using System.Collections.Generic;

namespace Desafio_Enumeração_Composição.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(moment, os, client);

            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(quantity, prodPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);


        }
    }
}
