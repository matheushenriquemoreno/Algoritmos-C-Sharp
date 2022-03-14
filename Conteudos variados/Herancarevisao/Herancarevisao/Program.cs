using System;
using Herancarevisao.Entities;

namespace Herancarevisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta = new Conta(1001, "alex", 100);

            ContaEmpresarial contaempresarial = new ContaEmpresarial(1002, "Maria", 100, 500.0);

            var contaPoupanca = new ContaPoupanca(1234, "adriella", 100, 10);


            conta.Saque(50);
            contaempresarial.Saque(50);
            contaPoupanca.Saque(50);


            Console.WriteLine($"conta 1 = {conta.Saldo}\ncontaempresarial = {contaempresarial.Saldo}\ncontaPoupanca = {contaPoupanca.Saldo}");



            contaPoupanca.AtualizandoValorTaxaDeJuros();

            Console.WriteLine($"contaPoupanca atualizada = {contaPoupanca.Saldo}");

        }
    }
}
