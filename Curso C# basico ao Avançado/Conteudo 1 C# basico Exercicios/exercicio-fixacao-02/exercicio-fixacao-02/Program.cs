using System;
using System.Globalization;


namespace exercicio_fixacao_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarto, idade;
            double preco, altura;
            string nome1, nome2;

            Console.WriteLine("digite seu nome completo: ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("digite seu ultimo nome, idade e altura na mesma linha");
            string[] vetor = Console.ReadLine().Split(' ');
            nome2 = vetor[0];
            idade = int.Parse(vetor[1]);
            altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("--------\nNome completo: " + nome1);
            Console.WriteLine("Quartos: " + quarto);
            Console.WriteLine("Preço do produto aleatorio: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Seu ultimo nome: {nome2} \nIdade: {idade} \nAltura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}
