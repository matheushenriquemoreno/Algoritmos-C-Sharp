using System;

namespace exercicio_matrizes {
    class Program {
        static void Main(string[] args) {

            string[] pega_tamanho = Console.ReadLine().Split(' ');
            int l = int.Parse(pega_tamanho[0]);
            int c = int.Parse(pega_tamanho[1]);
            int[,] matriz = new int[l, c];

            for(int i = 0; i < l; i++) {
                string[] popula_matriz = Console.ReadLine().Split(' ');
                for(int j = 0; j < c; j++) {
                    matriz[i, j] = int.Parse(popula_matriz[j]);
                }
            }

            int procurar = int.Parse(Console.ReadLine());

            for(int i = 0; i < l; i++) {
                for(int j = 0; j < c; j++) {
                    if (matriz[i, j] == procurar) {
                        Console.WriteLine($"position  {i},{j}:");

                        if (j > 0) {
                            Console.WriteLine("left: " + matriz[i, (j - 1)]);
                        }
                        if (j < c - 1) { //1 < 4 - 1 = 
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        }
                        if (i < l - 1) { // 0 < 3 - 1
                            Console.WriteLine("Down: " + matriz[(i + 1), j]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matriz[(i - 1), j]);
                        }
                    }
                }

            }

        }
    }
}
