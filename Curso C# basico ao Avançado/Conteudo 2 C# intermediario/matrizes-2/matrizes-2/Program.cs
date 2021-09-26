using System;

namespace matrizes_2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int [n, n];
            // int[] vetor = new int [n];

            for(int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

          
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                //  vetor[i] = matriz[i, i];
                Console.Write("" + matriz[i, i]);
            }

            int negativo = 0;
            for (int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(matriz[i, j] < 0) {
                        negativo++;
                    }
                }
            }

            Console.WriteLine("\nNegative Numbers = " + negativo);

            //  foreach(int a1 in vetor) {
            //     Console.Write(" " + a1);
            //  }



        }
    }
}
