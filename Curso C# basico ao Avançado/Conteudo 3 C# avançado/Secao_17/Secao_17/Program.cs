using System;
using System.Collections.Generic;
using Secao_17.Entities;
namespace Secao_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();

            produtos.Add(new Product("Xbox series S", 2400.00));
            produtos.Add(new Product("Play 5 digital", 3800.00));
            produtos.Add(new Product("Nitendo swhit", 3000.00));
            produtos.Add(new Product("Controle ps5/Xbox",380.00));

            produtos.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // expressao lambida
             
            foreach(Product list in produtos)
            {
                Console.WriteLine(list);
            }

        }
    }
}
