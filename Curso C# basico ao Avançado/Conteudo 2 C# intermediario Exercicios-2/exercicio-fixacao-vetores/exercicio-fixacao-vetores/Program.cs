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

        static void PopularVetor(int qtd, Quarto[] quarto) {
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Alugel {i}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int p = int.Parse(Console.ReadLine());

                if (quarto[p] == null) // verifica se a posicao do quarto escolhido esta vazia
                    quarto[p] = new Quarto(nome, email);
                else { // quarto ja ocupado, escolha outro
                    while (quarto[p] != null) {
                        Console.Write("Quarto escolhido ocupado escolha outro: ");
                        p = int.Parse(Console.ReadLine());
                        quarto[p] = new Quarto(nome, email);
                    }
                }

            }

        }

        static void MostraVetor(Quarto[] quarto) {
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 1; i <= 10; i++) {
                if (quarto[i] != null) {
                    Console.WriteLine(i + ": " + quarto[i]);
                }

            }

        }


    }
}
