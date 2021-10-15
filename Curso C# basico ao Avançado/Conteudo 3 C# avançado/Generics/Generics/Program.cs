using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> service = new PrintService<string>();

            Console.Write("How manu values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i < n; i++)
            {
                string x = Console.ReadLine();
                service.AddValue(x);
            }
            service.Print();
            Console.Write("\nFirst: " + service.First());
        }
    }
}
