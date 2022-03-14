using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class PessoaJuridica : Pessoa
    {

        public string CNPJ { get; set; }
     
        public string InscricaoEstadual { get; set; }

        public string RazaoSocial { get; set; }

        public PessoaJuridica(string nome, string email, DateTime dataNascimento, string estadoCivil, string cnpj, string inscricao, string razao) : base(nome, email, dataNascimento,  estadoCivil)
        {
            this.CNPJ = cnpj;
            this.InscricaoEstadual = inscricao;
            this.RazaoSocial = razao;
        }

        public override string ToString()
        {
            return base.ToString() + $"CNPJ = {this.CNPJ}";
        }

    }
}
