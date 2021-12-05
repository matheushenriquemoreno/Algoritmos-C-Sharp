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

                        if (j > 0) { // j maior que 0, se ele for igual ou menor a validação da erro
                            Console.WriteLine("left: " + matriz[i, (j - 1)]);
                        }
                        if (j < c - 1) { // c = tamanho da coluna da matriz // j menor que c - 1 = j sendo maior não tem numero a direita 
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        }
                        if (i < l - 1) { // l tamnho das linhas // i menor que l - 1 = i sempre menor se não não tem numero abaixo
                            Console.WriteLine("Down: " + matriz[(i + 1), j]);
                        }
                        if (i > 0) { // i maior que zero não tem a linha de cima 
                            Console.WriteLine("Up: " + matriz[(i - 1), j]);
                        }
                    }
                }

            }

        }
    }
}
