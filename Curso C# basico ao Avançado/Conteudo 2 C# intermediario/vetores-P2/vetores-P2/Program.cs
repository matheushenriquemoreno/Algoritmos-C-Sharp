﻿using System;
using System.Globalization;
namespace vetores_P2 {
    class Program {
        static void Main(string[] args) {
           int n = int.Parse(Console.ReadLine());

            Product[] vetor = new Product[n];
            
            for(int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Product { Name = name, Price = price };

            }

            double soma = 0.0;
            for(int i = 0; i < n; i++) {
                soma += vetor[i].Price;
            }
            double media = soma / n;

            Console.WriteLine($"AVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");
           

        }
    }
}
