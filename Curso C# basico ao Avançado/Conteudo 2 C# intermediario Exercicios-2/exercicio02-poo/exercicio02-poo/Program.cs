using System;
using System.Globalization;
namespace exercicio02_poo {
    class Program {
        static void Main(string[] args) {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (a.salario + b.salario) / 2.0;

            Console.WriteLine($"Salário medio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
