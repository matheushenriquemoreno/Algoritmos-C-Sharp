using System;
using System.IO;
using System.Collections.Generic;
using exercicio_link.Entities;
using System.Globalization;
using System.Linq;

namespace exercicio_link
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: "); // C:\Users\mathe\products.txt
            string path = Console.ReadLine();

            List<Products> listaProdutos = new List<Products>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vetCampos = sr.ReadLine().Split(',');
                    string names = vetCampos[0];
                    double price = double.Parse(vetCampos[1], CultureInfo.InvariantCulture);
                    listaProdutos.Add(new Products(names, price));
                }
            }

            var media = listaProdutos.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price = " + media.ToString("F2", CultureInfo.InvariantCulture));

            var name = listaProdutos.Where(p => p.Price < media).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string nomes in name)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
