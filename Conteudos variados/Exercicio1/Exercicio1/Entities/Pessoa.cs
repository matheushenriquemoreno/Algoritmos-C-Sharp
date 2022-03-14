using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    abstract class Pessoa
    {

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        /* public Endereco Endereco { get; set; }*/

        public string EstadoCivil { get; set; }

        public Pessoa(string nome, string email, DateTime dataNascimento,  string estadoCivil)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.EstadoCivil = estadoCivil;
        }

        public int Idade()
        {
            var idade =  DateTime.Now.Subtract(DataNascimento);
            return (int)(idade.TotalDays / 365.25);
        }


        public override string ToString()
        {
            return $"{Nome}, {Email}, {DataNascimento.ToString("dd/MM/yyyy")}, {this.EstadoCivil} ";
        }
    }
}
