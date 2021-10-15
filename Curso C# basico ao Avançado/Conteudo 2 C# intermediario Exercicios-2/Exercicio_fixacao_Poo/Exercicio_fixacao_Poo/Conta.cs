using System.Globalization;

namespace Exercicio_fixacao_Poo {
    class Conta {

        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string nome) {
            Nome = nome;
            NumeroConta = conta;
        }
        public Conta(int conta, string nome, double valor) : this (conta, nome){
            Saldo = AddSaldo(valor);
        }

        public double AddSaldo(double valor) {
            return Saldo += valor;
        }

        public double Saque(double valor) {
            return Saldo -= (valor + 5);
        }


        public override string ToString() {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
