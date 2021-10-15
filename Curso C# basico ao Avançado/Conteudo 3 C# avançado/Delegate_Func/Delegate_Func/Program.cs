using System;
using System.Collections.Generic;
using Delegate_Func.Entities;
using System.Linq;

namespace Delegate_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            Func<Product, string> func1 = p => p.Name.ToUpper();

            Func<Product, string> func2 = NameUpper;

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            
            // List<string> result = list.Select(NameUpper).ToList();

            foreach(var s in result)
            {
                Console.WriteLine(s);
            }


        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}
