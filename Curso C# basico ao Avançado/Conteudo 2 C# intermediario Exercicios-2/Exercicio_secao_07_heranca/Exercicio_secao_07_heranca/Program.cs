using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_secao_07_heranca.Entitis;

namespace Exercicio_secao_07_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int quantidade = int.Parse(Console.ReadLine());
            List<Product> listprodutos = new List<Product>();

            for(int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Product #{i} data: ");
                Console.Write("Common, usde or imported (c/u/i)? ");
                char verifica = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (verifica == 'i' || verifica == 'I')
                {
                    Console.Write("Customs fee: ");
                    double pricefee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listprodutos.Add(new ImportedProducts(name, price, pricefee));
                }
                else if (verifica == 'u' || verifica == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    listprodutos.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    listprodutos.Add(new Product(name, price));
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in listprodutos)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}
