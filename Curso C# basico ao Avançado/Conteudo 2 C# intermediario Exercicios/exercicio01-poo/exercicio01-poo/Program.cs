using System;

namespace exercicio01_poo {
    class Program {
        static void Main(string[] args) {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();
            
            Console.WriteLine("dados da primeira pessoa: ");
            Console.Write("nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("idade ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("idade ");
            b.Idade = int.Parse(Console.ReadLine());
            
            if(a.Idade > b.Idade) {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }
        }
    }
}
