using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio1_lista_treine.Entities.Enums;

namespace Exercicio1_lista_treine.Entities
{
    class Contatos
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Numero { get; set; }

        public TipoRelacionamento TipoDoRelacionamentoCliente { get; set; }

        public Contatos(int codigo, string nome, string numero, TipoRelacionamento tipo)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Numero = numero;
            this.TipoDoRelacionamentoCliente = tipo;
        }

        public override string ToString()
        {
            return $"Codigo: {Codigo}\nNome: {Nome}\nNumero: {Numero}\nTipo do Relacionamento: {TipoDoRelacionamentoCliente.ToString()}";
        }

    }
}
