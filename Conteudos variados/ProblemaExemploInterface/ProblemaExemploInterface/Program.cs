using System;
using ProblemaExemploInterface.Entities;
using ProblemaExemploInterface.Services;

namespace ProblemaExemploInterface
{
    class Program
    {
        public static void Main(string[] args)
        {

            ServiceLocacao _service = new ServiceLocacao(new Calculataxa());
                

            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Hora de entrada (dd/MM/yyyy hh:mm): ");
            var entrada = DateTime.Parse(Console.ReadLine());

            Console.Write("Hora de saida (dd/MM/yyyy hh:mm):");
            var saida = DateTime.Parse(Console.ReadLine());

            var carro = new Carro { Modelo = modelo, Entrada = entrada, Saida = saida };

            Console.Write("valor por Hora: ");
            var valorHora = double.Parse(Console.ReadLine());

            Console.Write("valor por Dia: ");
            var valorDia = double.Parse(Console.ReadLine());

            var locacao = new Locacao { ValorHora = valorHora, ValorDia = valorDia };

            var valorAPagar = _service.RetornaValorApagar(carro, locacao);
            var valorTaxa = _service.CalculaValorTaxa(valorAPagar);

            var valortotal = valorAPagar + valorTaxa;
            Console.WriteLine("\n{0} \n{1} \n{2}", valorAPagar, valorTaxa, valortotal);

        }
    }
}
