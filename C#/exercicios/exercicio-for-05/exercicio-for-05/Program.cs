using System;

namespace exercicio_for_05 {
    class Program {
        static void Main(string[] args) {


            /*
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
            */


            
            int fatorial, resultado = 0;

            Console.Write("digite um numero para fatoração: ");
            fatorial = int.Parse(Console.ReadLine());

         //   if (fatorial <= 1) { resultado = 1; }
            resultado = fatorial;
             for (int i = fatorial - 1; i >= 1; i--) {
                resultado *= i;
            }
           

            Console.WriteLine("resultado = " + resultado);
           
        }
    }
}
