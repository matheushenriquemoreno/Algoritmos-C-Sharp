using System;
using System.Globalization;

namespace saida_de_dados {
    class Program {
        static void Main(string[] args) {


            int idade2 = 32;
            double saldo2 = 10.53600;
            string nome2 = "matheus henrique";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2); // saida de dados com placeholder

            Console.WriteLine($"{nome2} tem {idade2} e tem saldo igual a {saldo2:F2} reais"); // saida de dados com interpolação

            Console.WriteLine(nome2 + " tem " + idade2 + "anos e tem saldo igual a " + saldo2.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // saida de dados com contatenação



















            char genero = 'f';
            int idade = 32;
            double saldo  = 10.53600;
            string nome = "matheus henrique";


            Console.Write("\nbom dia!!");
            Console.WriteLine("boa tarde!!");
            Console.WriteLine("-----------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));



        }
    }
}
