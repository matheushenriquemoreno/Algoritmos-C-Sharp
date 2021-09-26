using System;

namespace combinacao {
    class Program {
        static void Main(string[] args) {
            int n, p, resultado = 0, c;

            Console.WriteLine("digite os numeros para combinacao: ");
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            c = n - p;
            resultado = n;

            for(int i = n - 1; i > c; i--) {
                resultado *= i;
            }
            for(int i = p - 1; i > 0 ; i--) {
                p *= i;
            }
            resultado = resultado / p;
            Console.WriteLine(resultado);

        }
    }
}
