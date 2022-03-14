using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apostila5exercicio.Entities
{
    class ContaBancaria
    {
        public string NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }



        public ContaBancaria(string numero, string nome)
        {
            this.NomeTitular = nome;
            this.NumeroConta = numero;
        }

        public ContaBancaria(string numero, string nome, double saldo) : this(numero, nome)
        {
            this.Saldo = saldo;
        }

            
        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo = Saldo - (5.00 + valorSaque);
        }


        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: {Saldo:F2}";
        }


    }
}
