using System;
using System.Globalization;
namespace vetores {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];


            double soma = 0;
            for(int i = 0; i < n; i++) {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vetor[i];
            }

            double media = soma / n;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
