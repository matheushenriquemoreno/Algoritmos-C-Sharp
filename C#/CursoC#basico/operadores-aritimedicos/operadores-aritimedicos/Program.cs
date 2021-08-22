using System;

namespace operadores_aritimedicos
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = (3 + 4) * 2;
            int n2 = 17 % 3;
            double n3 = (double) 10 / 8; //ou  double n3 = 10.0 / 8;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);


            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4 * a * c; // ou double delta = Math.Poq(b, 2.0) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"Valor Delta = {delta}\nValor X1 = {x1}\nValor X2 = {x2}");

        }
    }
}
