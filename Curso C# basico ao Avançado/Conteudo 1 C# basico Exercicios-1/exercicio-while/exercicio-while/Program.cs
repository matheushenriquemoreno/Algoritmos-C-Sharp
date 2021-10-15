using System;

namespace exercicio_while {
    class Program {
        static void Main(string[] args) {
            int senha;

            Console.WriteLine("digite sua senha: ");
            senha = int.Parse(Console.ReadLine());
            while(senha != 2002) {
                Console.WriteLine("senha invalida!!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!!");
        }
    }
}
