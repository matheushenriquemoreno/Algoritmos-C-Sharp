using System;
using System.Globalization;
namespace exercicio_sequencial_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_pecas1, numero_pecas2;
            double Valor1, valor2, valor;

            string[] vetor1 = Console.ReadLine().Split(' ');
            numero_pecas1 = int.Parse(vetor1[1]);
            Valor1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

            string[] vetor2 = Console.ReadLine().Split(' ');
            numero_pecas2 = int.Parse(vetor2[1]);
            valor2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            valor = (Valor1 * numero_pecas1) + (valor2 * numero_pecas2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
