using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_lista_treine.Entities
{
    class Cliente
    {
        public string Nome { get; set; }

        public string CPF { get; set; }
   
        public Endereco EnderecoCliente { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public List<Contatos> ListaContatos;


        public Cliente(string nome, string cpf, Endereco endereco, DateTime datanascimento)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.EnderecoCliente = endereco;
            this.DataNascimento = datanascimento;
            ListaContatos = new List<Contatos>();
        }

        public void AdicionarContatos(Contatos contato)
        {
            if (ListaContatos.Count > 1)
            {
                ListaContatos.Add(contato);
            }

            var VerificaNumeroIgualExiste = ListaContatos.Where(x => x.Numero == contato.Numero && x.TipoDoRelacionamentoCliente == contato.TipoDoRelacionamentoCliente).Any();

            // no where acima verifico se tem um numero igual ao contato que vai ser adicionado e verifico o tipo do relacionamento
            // se tiver um registro que possue o mesmo numero e o mesmo relacionamento não deixo adiconar e gero uma excessao

            if (VerificaNumeroIgualExiste)
            {
                throw new ArgumentException("Já existe um contato com esse numero e relacionamento na sua lista!!");
            }
            else
            {
                ListaContatos.Add(contato);
            }
        }


        public List<Contatos> RetornaListaContatos()
        {
            return ListaContatos.OrderBy(x => x.Codigo).ToList();
        }

        public override string ToString()
        {
            StringBuilder Cliente = new StringBuilder();
            Cliente.AppendLine($"Nome: {Nome}\nCPF: {CPF}");
            Cliente.AppendLine($"Endereço: {EnderecoCliente} \nData Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}" );
            Cliente.AppendLine($"Contatos: ");
            foreach (var contatos in RetornaListaContatos())
            { 
                Cliente.Append(contatos);
            }

            return Cliente.ToString();
        }
    }
}
