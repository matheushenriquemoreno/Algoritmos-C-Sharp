using System;

namespace estrutura_repetitiva_for {
    class Program {
        static void Main(string[] args) {
            int numero1,numero2,soma = 0;

            Console.Write("Quantos números inteiros você vai digitar? ");
            numero1 = int.Parse(Console.ReadLine());


            for(int i = 1; i <= numero1; i++) {
                Console.Write("valor #{0}: ", i);
                numero2 = int.Parse(Console.ReadLine());
                soma += numero2;
            }
            Console.WriteLine("soma = " + soma);


        }
    }
}
