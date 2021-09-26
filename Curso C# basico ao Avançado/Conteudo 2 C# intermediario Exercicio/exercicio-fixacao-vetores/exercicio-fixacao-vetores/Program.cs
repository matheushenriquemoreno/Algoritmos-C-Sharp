using System;

namespace exercicio_fixacao_vetores {
    class Program {
       
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());

            Quarto[] quarto = new Quarto[10];

            PopularVetor(qtd, quarto);
            MostraVetor(quarto);

        }

        static void PopularVetor(int qtd, Quarto[] q) {
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Alugel {i + 1}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int p = int.Parse(Console.ReadLine());

                if (q[p] == null) // verifica se a posicao do quarto escolhido esta vazia
                    q[p] = new Quarto(nome, email);
                else { // quarto ja ocupado, escolha outro
                    while (q[p] != null) {
                        Console.Write("Quarto escolhido ocupado escolha outro: ");
                        p = int.Parse(Console.ReadLine());
                        q[p] = new Quarto(nome, email);
                    }
                }

            }

        }

        static void MostraVetor(Quarto[] q) {
            Console.WriteLine("Quantos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (q[i] != null) {
                    Console.WriteLine(i + ": " + q[i]);
                }

            }

        }


    }
}
