using System;
using System.Linq;
using System.Collections.Generic;

namespace Introducao_Lin_q
{
    class Program
    {
        static void Main(string[] args)
        {
            // espificar o data souce
            int[] numbers = new int[] { 2, 3, 4, 5, 6};

            // definir expressao de consulta

           // e uma coleção mais generica.
            IEnumerable<int> result =  numbers.Where(x => x % 2 == 0)
                         .Select(x => x * 10); // pegando os elementos pares da lista number e multiplicando por 10

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }


        }
    }
}
