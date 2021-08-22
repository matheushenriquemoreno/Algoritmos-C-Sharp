using System;

namespace tipo_de_dados {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            int numero2 = int.MinValue;
            int numero3 = int.MaxValue;
            Console.WriteLine("mostrando o menor valor que pode alocar em int " + numero2 + " agora o maior " + numero3);




            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            sbyte n1 = 126;
            int n2 = 100;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Matheus henrique"; // não e considerado um tipo basico da linguaguem C#. variavel imutável

            object objt1 = "alex brow";
            object objt2 = 4.5;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4); // cw    tab + tab
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(objt2);
            Console.WriteLine(objt1);




        }
    }
}
