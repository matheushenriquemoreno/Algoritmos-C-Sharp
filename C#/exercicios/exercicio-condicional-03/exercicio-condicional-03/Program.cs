using System;

namespace exercicio_condicional_03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("digite dois valores: ");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            if(valor1 % valor2 == 0 || valor2 % valor1 == 0) {
                Console.WriteLine("são multiplos");
            } else {
                Console.WriteLine("não são multiplos");
            }
        }
    }
}
