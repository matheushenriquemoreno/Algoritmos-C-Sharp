using System;

namespace operadores_de_atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += 2;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF"; //+= tambem serve para contatenação acumulativa de string
            Console.WriteLine(s);

            int a2 = 10;
            int b = ++a;
            Console.WriteLine(a2);
            Console.WriteLine(b);
        }
    }
}
