using System;
using Exercicio1.Entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Agenda agenda = new Agenda();

            var busca = agenda.BuscaPorCPForCNPJ("7");

            Console.WriteLine("Pessoa Buscada por CNPF = " + busca?.ToString());

            var todosOsContatos = agenda.RetornaListaDecontatosOrdenda();

            foreach(var pessoa in todosOsContatos)
            {
                Console.WriteLine($"{pessoa} Idade = {pessoa.Idade()}");
            }

        }
    }
}
