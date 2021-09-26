using System;

namespace nullable {
    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5; // se x for null a = 5 
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            /*
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // verifica se tem valor
            Console.WriteLine(y.HasValue);

            if (x.HasValue) 
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is Null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is Null");

            */

        }
    }
}
