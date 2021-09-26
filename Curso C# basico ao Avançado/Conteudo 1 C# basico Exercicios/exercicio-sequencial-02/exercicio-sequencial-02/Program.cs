using System;
using System.Globalization;
namespace exercicio_sequencial_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, raio, area;

            Console.WriteLine("digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("area = " + area.ToString("F4", CultureInfo.InvariantCulture));



        }
    }
}
