using System;
using System.Globalization;
using System.Collections.Generic;
using Desafio_secao_10.Entities;

namespace Desafio_secao_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listP = new List<Pessoa>();

            Console.Write("Enter the number of taz payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Taz payer #{i} date:");
                Console.Write("Individual or Company (i/c)? ");
                char verifica = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(verifica == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastomedico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listP.Add(new PessoaFisica(name, renda, gastomedico));
                }
                else
                {
                    Console.Write("Number of employess: ");
                    int quantidadef = int.Parse(Console.ReadLine());
                    listP.Add(new PessoaJuridica(name, renda, quantidadef));
                }

            }

            Console.WriteLine("\nTAXES PAID: ");
            double soma = 0.0;
            foreach(Pessoa pes in listP)
            {
                Console.WriteLine($"{pes.Name} $ {pes.CalculoImposto().ToString("F2", CultureInfo.InvariantCulture)}");
                soma += pes.CalculoImposto();
            }

            Console.WriteLine($"\nTOTAL TAXES: {soma.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
