using System;
using Exercicio_01.Entities;
namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de nascimento(DD/MM/YYYY) ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            Pessoa p = new Pessoa(nome, data, altura);

            Console.WriteLine(p);
            
        }
    }
}
