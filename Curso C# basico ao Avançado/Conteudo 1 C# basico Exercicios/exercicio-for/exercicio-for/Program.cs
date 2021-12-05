using System;
using System.Globalization;
namespace exercicio_for {
    class Program {
        static void Main(string[] args) {
            int n;
            Console.WriteLine("digite o numero de vezes a executar os teste: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("digite os dados ");
            for (int i = 0; i < n; i++) {
                string[] vetor = Console.ReadLine().Split(' ');

                double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                double media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / (2 + 3 + 5);
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
