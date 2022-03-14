using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome, string email, DateTime dataNascimento, string estadoCivil, string cpf) : base(nome, email, dataNascimento, estadoCivil)
        {
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return base.ToString() + $" CPF = {this.CPF}";
        }
    }
}
