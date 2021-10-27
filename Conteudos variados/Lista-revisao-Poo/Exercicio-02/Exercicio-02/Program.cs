using System;
using Exercicio_02.Entities;
namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja uma agenda com quantas pessoas:  ");
            int n = int.Parse(Console.ReadLine());
            Agenda agenda = new Agenda(n);

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());
                agenda.ArmazenaPessoa(name, idade, altura);
            }

            Console.WriteLine("deseja qual das opções? ");
            Console.WriteLine("1 - remover pessoa." +
                "\n2 - Buscar pessoa na agenda." +
                "\n3 - Imprimir agenda." +
                "\n4 - Imprimir Pessoa.");
            n = int.Parse(Console.ReadLine());


            switch (n)
            {
                case 1:
                    Console.WriteLine("Qual o nome da pessoa: ");
                    string nome = Console.ReadLine();
                    agenda.RemovePessoa();
                    break;
                case 2:
                    agenda.BuscaPessoa();

            }




        }
    }
}
