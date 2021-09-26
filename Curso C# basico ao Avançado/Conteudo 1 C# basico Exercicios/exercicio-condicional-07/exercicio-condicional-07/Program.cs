using System;
using System.Globalization;
namespace exercicio_condicional_07 {
    class Program {
        static void Main(string[] args) {
            double x, y;

            Console.WriteLine("digite primeiro o eixo X e Y )");
            string[] vetor = Console.ReadLine().Split(' ');
            x = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y = double.Parse(vetor[1], CultureInfo.InvariantCulture);


            if (x >= 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x <= 0 && y < 0) {
                Console.WriteLine("Q3");
            } else if (x >= 0 && y < 0) {
                Console.WriteLine("Q4");
            } else if (x <= 0 && y > 0) {
                Console.WriteLine("Q2");
            } else {
                Console.WriteLine("Origem!");
            }


        }
    }
}

