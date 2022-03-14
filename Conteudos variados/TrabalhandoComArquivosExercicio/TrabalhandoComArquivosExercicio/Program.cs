using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using TrabalhandoComArquivosExercicio.Entities;

namespace TrabalhandoComArquivosExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            string pastaOrigem = @"c:\Temp\ArquivoExercicio.txt";

            string pastaDestino = @"c:\Temp\ArquivoExercicioComDadosTratados.txt";


            string[] aa = File.ReadAllLines(pastaOrigem);


            foreach (string linha in aa)
            {
                //Console.WriteLine(linha);
            }

            CriaNovaPastaComDadosProdutos(pastaDestino, PopularProdutos(pastaOrigem));

        }

        public static List<Produto> PopularProdutos(string caminhoArquivo)
        {
            try
            {
                List<Produto> listaProdutos = new List<Produto>();

                using (StreamReader stream = new StreamReader(caminhoArquivo))
                {

                    while (!stream.EndOfStream)
                    {
                        string[] linha = stream.ReadLine().Split(',');

                        string nome = linha[0];
                        double valor = double.Parse(linha[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(linha[2]);

                        listaProdutos.Add(new Produto(nome, valor, quantidade));
                    }

                }

                Console.WriteLine("Dados Populados!!");

                return listaProdutos;

            }
            catch(IOException e)
            {
                Console.WriteLine("Erro de execução " + e.Message);
                return null;
            }

        }

        public static void CriaNovaPastaComDadosProdutos(string caminhoDestino, List<Produto> listaPopulada)
        {
            try
            {

                if (File.Exists(caminhoDestino))
                {
                    File.Delete(caminhoDestino);
                }
                

                using (StreamWriter escrita = new StreamWriter(caminhoDestino))
                {
                    foreach (var produtos in listaPopulada)
                    {
                        escrita.WriteLine(produtos + $" Total De Vendas = {produtos.RetornaTotalVendas().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

                Console.WriteLine("Dados Passados pra pasta de destino!!");

            }
            catch(IOException e)
            {
                Console.WriteLine("Erro de execução " + e.Message);
            }
        }
    }
}
