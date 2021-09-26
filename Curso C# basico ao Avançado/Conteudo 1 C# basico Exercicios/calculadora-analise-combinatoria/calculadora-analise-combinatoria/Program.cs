using System;

namespace calculadora_analise_combinatoria {
    class Program {
        static void Main(string[] args) {
            int n, p, resultado = 0;

            Console.WriteLine("digite dois numero para calculo do aranjo");
            string [] vetor = Console.ReadLine().Split(' ');
            n = int.Parse(vetor[0]);
            p = int.Parse(vetor[1]);

            p = n - p;
            resultado = n;
            for (int i = n - 1; i > p; i--) {
                resultado *= i ;
            }
            Console.WriteLine(resultado);
        }
    }
}
