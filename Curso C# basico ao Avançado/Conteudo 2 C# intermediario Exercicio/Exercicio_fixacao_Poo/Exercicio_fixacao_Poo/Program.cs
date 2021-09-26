using System;

namespace Exercicio_fixacao_Poo {
    class Program {
        static void Main(string[] args) {
            Conta co;
            double valor = 0;

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havéra depósito inicial (S/N)? ");
            char validacao = char.Parse(Console.ReadLine());

            if(validacao == 'S' || validacao == 's') {
                Console.Write("entre com o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                co = new Conta(conta, nome, valor);
            }else{
                co = new Conta(conta, nome);
            }

            Console.WriteLine("\nDados da conta: \n" + co);

            Console.Write("\nEntre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            co.AddSaldo(valor);
            Console.Write("Dados da conta atualizado:\n"+ co);

            Console.WriteLine();

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            co.Saque(valor);
            Console.WriteLine("Dados da conta atualizado:\n" + co);
        }
    }
}
