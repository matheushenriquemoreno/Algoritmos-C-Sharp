using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herancarevisao.Entities
{
    sealed class ContaPoupanca : Conta
    {
        public double taxaDeJuros { get; set; }
        
        public ContaPoupanca(int numero, string nome, double saldo, double taxa) : base(numero, nome, saldo)
        {
            this.taxaDeJuros = taxa;
        } 

        public void AtualizandoValorTaxaDeJuros()
        {
            Saldo += (Saldo * (taxaDeJuros / 100.00));
        }

        public override void Saque(double valorSaque)
        {
            this.Saldo -= valorSaque;
        }
    }
}
