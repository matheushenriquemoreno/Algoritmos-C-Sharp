using System;
using System.Collections.Generic;
using Predicate_delegates.Entities;

namespace Predicate_delegates
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

            // list.RemoveAll(p => p.Price <= 100.00); //  função lambda
            // list.RemoveAll(ProductTeste); // predicate


            Action<Product> act1 = p => { p.Price += p.Price * 0.1; };

            Action<Product> act = UpdatePrice;

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            list.ForEach(act1);

            //list.ForEach(UpdatePrice);

            foreach(var p in list)
            {
                Console.WriteLine(p);
            }

        }
        public static bool ProductTeste(Product p) // predicate
        {
            return p.Price >= 100.00;
        }

        static void UpdatePrice(Product p) // Action
        {
            p.Price += p.Price * 0.1;
        }


    }
}
