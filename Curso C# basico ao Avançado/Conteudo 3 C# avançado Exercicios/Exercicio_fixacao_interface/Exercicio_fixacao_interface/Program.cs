using System;
using Exercicio_fixacao_interface.Entities;
using Exercicio_fixacao_interface.Services;

namespace Exercicio_fixacao_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installmenst: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor); // instanciando o contrato

            ContratoServico pagamentoservico = new ContratoServico(new ServicoPagamento()); // instanciando o pagamento passando por parametro qual e o servicço

            pagamentoservico.ProcessandoContrato(contrato, meses); // chamando a função que vai gerar as parcelas

            Console.WriteLine("Installments");
            foreach (Parcelas par in contrato.ParcelasMes)
            {
                Console.WriteLine(par);
            }






        }
    }
}
