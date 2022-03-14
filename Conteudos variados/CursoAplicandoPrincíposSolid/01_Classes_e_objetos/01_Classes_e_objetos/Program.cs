using System;
using System.Collections.Generic;

namespace _01_Classes_e_objetos
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var lista = new List<string>();

            Pessoa pessoa1 = new Pessoa(); // Criando Instancia da classe 
            pessoa1.nome = "matheus";
            pessoa1.idade = 30;
            pessoa1.genero = "masculino";

            var pessoa2 = new Pessoa { nome = "paulo", idade = 26, genero = "não binario" }; 

            var pessoa3 = new Pessoa("amanda", 44, "feminino");

            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);
            Console.WriteLine(pessoa3);
        }
    }
}
