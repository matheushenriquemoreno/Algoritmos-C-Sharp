using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Propriedades.Entities
{
    class Pessoa
    {
        public string Nome { get; }
        public string Genero {get; set;}
        private int idade;

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }


        public int Idade
        {
            set
            {
                if (value < 18)
                    Console.WriteLine("Menor de idade!!");
                else
                    this.idade = value;
            }

            get { return idade; }

        }

        public override string ToString()
        {
            return $"{Nome} {Idade} {Genero}";
        }

    }
}
