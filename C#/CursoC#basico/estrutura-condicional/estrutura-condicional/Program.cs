using System;

namespace estrutura_condicional {
    class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("numero Par!!");
            } else {
                Console.WriteLine("numero Impar");
            }
            */

            Console.WriteLine("Qual a hora atual");
            int hora = int.Parse(Console.ReadLine());





            /*
            if (hora < 12) 
                Console.WriteLine("Bom dia !!");
             else if(hora < 18) 
                Console.WriteLine("Boa tarde");
             else 
                Console.WriteLine("Boa noite!!");
            */



            if (hora < 12) {
                Console.WriteLine("bom dia !!");
            } else if(hora < 18) {
                Console.WriteLine("Boa tarde");
            } else {
                Console.WriteLine("Boa noite!!");
            }






        }
    }
}
