using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class Endereco
    {
        public string Complemento { get; set; }
    
        public int? Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public Endereco(string complemento, int? numero, string bairro, string cidade, string cep)
        {
            Complemento = complemento;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
        }
    }
}
