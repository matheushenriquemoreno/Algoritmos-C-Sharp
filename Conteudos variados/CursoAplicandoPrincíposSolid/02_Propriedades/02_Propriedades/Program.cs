using System;
using _02_Propriedades.Entities;

namespace _02_Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {

            var pessoa = new Pessoa("rafael");
            pessoa.Idade = 17;
            pessoa.Genero = "masculino";

            Console.WriteLine(pessoa);
            Console.WriteLine(pessoa.Genero + " " + pessoa.Idade);
        }
    }
}
