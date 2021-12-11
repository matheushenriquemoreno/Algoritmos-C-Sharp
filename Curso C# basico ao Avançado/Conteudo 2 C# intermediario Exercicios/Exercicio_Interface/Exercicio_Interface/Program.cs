using System;
using Exercicio_Interface.Entities;
using Exercicio_Interface.Service;


namespace Exercicio_Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter contract data");
            Console.Write("Numbeer");
            var numero = int.Parse(Console.ReadLine());

            Console.Write("date (dd/MM/yyyy): ");
            var data = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            var valor = double.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            Console.Write("Enter number of installments: ");
            var mes = int.Parse(Console.ReadLine());

            ServiceContrato service = new ServiceContrato(contrato, new ServicePagamentoPaypal());

            service.CalculaParcelas(mes);

            Console.WriteLine("Parcelas/Intallments: ");

            foreach(var parcelas in contrato.ListaParcelas)
            {
                Console.WriteLine(parcelas);
            }




        }
    }
}
