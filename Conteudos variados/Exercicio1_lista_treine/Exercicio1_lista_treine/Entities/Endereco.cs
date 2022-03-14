using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_lista_treine.Entities
{
    class Endereco
    {

        public int Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }
            
        public string Complemento { get; set; }

        public Endereco(int cep, string bairro, string cidade, string complemento)
        {
            this.Cep = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Complemento = complemento;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
