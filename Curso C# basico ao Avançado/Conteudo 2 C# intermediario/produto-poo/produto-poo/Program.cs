using System;
using System.Globalization;
namespace produto_poo {
    class Program {
        static void Main(string[] args) {


            Produto p = new Produto("TV", 900.00);

            p.Nome = "t";
         
            Console.WriteLine(p);
            Console.WriteLine(p.Preco);





            /*
             * 
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto { // sintaxe alternativa para iniciar valores // necessario contrutor padrao
                Nome = "tv",
                Preco = 1200.00,
                Quantidade = 20
            };

            Console.WriteLine("\nDados do produto: " + p);
          
            Console.Write("\ndigite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("\nDados atualizados: " + p);
            *
            */
        }
    }
}
