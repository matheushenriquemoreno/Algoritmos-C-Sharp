using System;
using System.Globalization;

namespace entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * AULA PARTE 1
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vetorS = Console.ReadLine().Split(' '); //   ou string s = Console.ReadLine();
            string a = vetorS[0];
            string b = vetorS[1];
            string c = vetorS[2];

            Console.WriteLine("Você digitou ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */
           
            // AULA PARTE 2

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // lendo um numero double com ponto inves de virgula

            string[] vetor = Console.ReadLine().Split(' '); // usado para recontar partes de uma frase e quardar em um vetor.
            String nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));




        }
    }
}
