using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02.Entities
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
       
        public Pessoa()
        {

        }

        public Pessoa(string name, int idade, double altura)
        {
            Nome = name;
            Idade = idade;
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome}, {Idade}, {Altura.ToString("F2")}.";
        }

    }
}
