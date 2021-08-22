using System;
using System.Globalization;
namespace exercicio_condicional_05 {
    class Program {
        static void Main(string[] args) {
            int codigo, quantidade;
            double valor = 0;
            Console.WriteLine("Codigo   Especificação   Preço");
            Console.WriteLine("1        Cachoro Quente  R$ 4.00\n" +
                "2        X-salada        R$ 4.50\n" +
                "3        X-bacon         R$ 5.00\n" +
                "4        Torrada Simples R$ 2.00\n" +
                "5        Refrigerante    R$ 1.50\n" +
                "digite o codigo do produto e quantidade:");

            string[] vetor = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            if (codigo == 1) {
                valor = 4.00 * quantidade;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }else if (codigo == 2 ) {
                valor = 4.50 * quantidade;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 3) {
                valor = 5.00 * quantidade;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 4) {
                valor = 2.00 * quantidade;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 5) {
                valor = 1.50 * quantidade;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Erro!!");
            }






        }
    }
}
