using System;

namespace matrizes {
    class Program {
        static void Main(string[] args) {
            double[,] matriz = new double[2, 3];


            Console.WriteLine(matriz.Length); // mostra quantos elementos a matriz tem no total

            Console.WriteLine(matriz.Rank); // quantidade de linhas

            Console.WriteLine(matriz.GetLength(0));

            Console.WriteLine(matriz.GetLength(1));


        }
    }
}
