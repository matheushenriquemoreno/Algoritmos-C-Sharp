using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class Agenda
    {
        List<Pessoa> ListaContatos ;

        public Agenda()
        {
           ListaContatos = new List<Pessoa>();

           AdicionarContatos(new PessoaFisica("matheus Pessoa fisica", "matheus@henrique", new DateTime(1999, 11, 21), "solteiro", "701"));
           AdicionarContatos(new PessoaJuridica("Valdir  Pessoa Jurica", "Valdir@Vicente", new DateTime(1980, 10, 18), "solteiro", "702-637", "não tem", "nem sei o que e razao"));
           AdicionarContatos(new PessoaFisica("Fernando Pessoa fisica", "matheus@henrique", new DateTime(1970, 11, 21), "solteiro", "702"));
           AdicionarContatos(new PessoaJuridica("Geovani  Pessoa Jurica", "Valdir@Vicente", new DateTime(1997, 10, 18), "solteiro", "702-638", "não tem", "nem sei o que e razao"));
           AdicionarContatos(new PessoaFisica("Adriano Pessoa fisica", "matheus@henrique", new DateTime(1996, 11, 21), "solteiro", "703"));
           AdicionarContatos(new PessoaJuridica("Carlos  Pessoa Jurica", "Valdir@Vicente", new DateTime(1988, 10, 18), "solteiro", "702-639", "não tem", "nem sei o que e razao"));
        }

        public void AdicionarContatos(Pessoa pessoa)
        {
            ListaContatos.Add(pessoa);
        }

        public void RemoverContatos(Pessoa pessoa)
        {
            ListaContatos.Remove(pessoa);
        }

        public Pessoa BuscaPorNome(string nome)
        {
            return ListaContatos.Where(x => x.Nome == nome).First();
        }

        public Pessoa BuscaPorCPForCNPJ(string CPFOuCNPJ)
        {

            var pessoaCPF = ListaContatos.OfType<PessoaFisica>().Where(x => x.CPF == CPFOuCNPJ).FirstOrDefault();

            var pessoaCNJP = ListaContatos.OfType<PessoaJuridica>().Where(x => x.CNPJ == CPFOuCNPJ).FirstOrDefault();

            //return pessoaCPF == null ? pessoaCNJP == null ? null : pessoaCNJP : pessoaCPF;
            return pessoaCPF != null ? pessoaCPF : pessoaCNJP != null ? pessoaCNJP : null;
        }

        public List<Pessoa> BuscaTodos()
        {
            return ListaContatos;
        }

        public List<Pessoa> RetornaListaDecontatosOrdenda()
        {
            var listaOrdenada = new List<Pessoa>();
            listaOrdenada.AddRange(ListaContatos.OfType<PessoaFisica>().OrderBy(x => x.CPF));
            listaOrdenada.AddRange(ListaContatos.OfType<PessoaJuridica>().OrderBy(x => x.CNPJ));

            return listaOrdenada;
        }
    }
}
