using System;
using System.Collections.Generic;
using System.Globalization;

using Exercicio1.Entities;
using Exercicio1.Entities.Enums;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Enter client data: ");
            
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Order order = new Order(client);
            Console.WriteLine("Enter order data: ");
            
            Console.Write("Status: ");
            order.OrderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            order.Moment = DateTime.Now;
            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdItems; i++)
            {
                OrderItem item = new OrderItem();
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                item.Product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                item.Product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                item.Quantity = int.Parse(Console.ReadLine());

                order.AddItem(item);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine($"Order moment: {order.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            Console.WriteLine($"Order status: {order.OrderStatus.ToString()}");
            Console.WriteLine($"Client: {client.Name} ({client.BirthDate.ToString("dd/MM/yyyy")}) - {client.Email}");

            Console.WriteLine("Order items: ");
            foreach(OrderItem item in order.OrderItems)
            {
                Console.WriteLine($"{item.Product.Name}, ${item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"Total price: ${order.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
