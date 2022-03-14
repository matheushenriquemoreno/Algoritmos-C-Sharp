using System;
using System.IO;

namespace TrabalhandoComArquivos06
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasta = @"G:\Querys SQL";

            listandoSubpastas(pasta);

            listandoArquivosDentroDePastas(pasta);

            CriarArquivo(@"C:\Temp");

        }

        public static void listandoSubpastas(string caminho)
        {
            try
            {

                var folders = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories); // pegando subspastas atraves de uma pasta principal. paramentro 2 = mascara de busca, estou dizendo pra buscar tudo, 3 = como vai ser buscado 
                Console.WriteLine("Pastas dentro do diretorio: ");

                foreach (var pastas in folders)
                {
                    Console.WriteLine(pastas);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
        }

        public static void listandoArquivosDentroDePastas(string caminho)
        {
            try
            {

                var Arquivos = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("arquivos detro da pasta: " + caminho);

                foreach (var pastas in Arquivos)
                {
                    Console.WriteLine(pastas);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
        }

        public static void CriarArquivo(string caminho)
        {
            try
            {

                string arquivoNovo = caminho + @"\New Pasta";
                string arquivoNovo2 = caminho + @"\Nova folder";

                DirectoryInfo directory = new DirectoryInfo(arquivoNovo2);

                if (Directory.Exists(arquivoNovo) && directory.Exists)
                {
                    directory.Delete();
                    Directory.Delete(arquivoNovo);
                }

                directory.Create();
                Directory.CreateDirectory(arquivoNovo);

                Console.WriteLine("Arquivo Criado!");

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
        }
    }
}
