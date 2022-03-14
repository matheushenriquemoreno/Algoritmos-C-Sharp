using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herancarevisao.Entities
{
    class Conta
    {
        public int Numero { get; private set; }

        public string Nome { get; private set; }

        public double Saldo { get; protected set; }

        public Conta()
        {

        }
        
        public Conta(int numero, string nome, double saldo)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Saldo = saldo;
        }

        public virtual void Saque(double valorSaque)
        {
            Saldo -= (valorSaque + 5);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }
    }
}
