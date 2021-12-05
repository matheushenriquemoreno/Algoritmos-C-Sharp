using System;


namespace Desafio_secao_10.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double Renda { get; set; }

        public Pessoa (string name, double renda)
        {
            Name = name;
            Renda = renda;
        }

        public abstract double CalculoImposto(); 


    }
}
