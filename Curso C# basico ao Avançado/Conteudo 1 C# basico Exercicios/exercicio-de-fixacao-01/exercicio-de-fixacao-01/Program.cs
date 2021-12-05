using System;
using System.Globalization;

namespace exercicio_de_fixacao_01 {
    class Program {
        static void Main(string[] args) {
            string produto1 = "computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.00;
            double media = 53.234567;

            Console.WriteLine($"Produtos: \n{produto1}, cujo o valor é $ {preco1:F2}.\n{produto2}, cujo preco é $ {preco2:F2}. \n\nRegistro: {idade} anos de idade" +
                $", código {codigo} é genero {genero}\n");
            Console.WriteLine("Medida com oito casas decimais: {0}\nArredondado: {1:F3}", media, media);
            Console.WriteLine("Separador decimal: " + media.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
