using System;

namespace Extensio_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2021, 9, 20, 8, 10, 30);
            Console.WriteLine(dt.ElapedTime());
            
            string s1 = "GOOD Morning Dear Students! ";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
