using System;

namespace Exercicio_01.Entities
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(string nome, DateTime data, double altura)
        {
            Nome = nome;
            DataNascimento = data;
            Altura = altura;
        }


        public int Idade()
        {
            DateTime data_atual = DateTime.Now;
            TimeSpan dias = data_atual.Subtract(DataNascimento);
            int anos = (int)dias.TotalDays / 365; 

            return anos;      
        }


        public override string ToString()
        {
            return ($"A pessoa com o nome {Nome} nasceu no dia {DataNascimento:d} e tem a altura {Altura:f2} com a idade de: {Idade()} anos");
        }


    }
}
