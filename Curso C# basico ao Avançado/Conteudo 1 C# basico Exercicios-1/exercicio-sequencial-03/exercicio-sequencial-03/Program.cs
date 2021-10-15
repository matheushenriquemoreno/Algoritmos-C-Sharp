using System;

namespace exercicio_sequencial_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            Console.WriteLine("digite 4 numeros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);
            Console.WriteLine("DIFEREÇA = " + diferenca);


        }
    }
}
