using System;
using Apostila5exercicio.Entities;

namespace Apostila5exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;


            Console.Write("Entre com o numero da conta: ");
            var numeroConta = Console.ReadLine();

            Console.Write("Entre o titular da conta:");
            var nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (sim/não)?");
            var verifica = Console.ReadLine();
            verifica.ToLower();

            if(verifica == "sim")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                var deposito = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroConta, nome, deposito);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nome);
            }

            Console.WriteLine("\nDados da conta: \n" + conta);

            conta.Deposito(500);
            Console.WriteLine("\nDados conta com deposito : \n" + conta);

            conta.Saque(550);
            Console.WriteLine("\nDados conta saque: \n" + conta);



        }
    }
}
