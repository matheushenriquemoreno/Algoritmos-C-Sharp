using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herancarevisao.Entities
{
    class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; private set; }

        public ContaEmpresarial()
        {

        }

        public ContaEmpresarial(int numero, string nome, double saldo, double limite) : base(numero, nome, saldo)
        {
            this.LimiteEmprestimo = limite;
        }

        public sealed override void Saque(double valorSaque) // sealed =  bloqueia que a função seja sobrescrita  em outras classes que erdarem da ContaEmpresarial 
        {
           base.Saque(valorSaque);
           this.Saldo -= 10;
        }

        public void Emprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo)
                    this.Saldo += LimiteEmprestimo;
        }
    }
}
