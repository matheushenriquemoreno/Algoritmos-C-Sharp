using System;
using Desafio_capitulo_09.Entities;
using Desafio_capitulo_09.Entities.Enum;

namespace Desafio_capitulo_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente data: ");
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, date);

            Console.WriteLine("Enter order Data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime dataAtual = DateTime.Now;
            Order order = new Order(dataAtual, status, c1);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameP = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());
                Product p1 = new Product(nameP, price);
                OrderItem or1 = new OrderItem(price, quantidade, p1);
                order.AddItem(or1);
            }

            Console.WriteLine("\nORDEM SUMMARY: ");
            Console.WriteLine(order);


        }
    }
}
