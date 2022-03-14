using System;
using System.IO;

namespace TrabalhandoComArquivos01
{
    class Program
    {
        static void Main(string[] args)
        {

            string caminhoArquivo = @"c:\Temp\Arquivo.txt";

            string caminhoDestino = @"c:\Temp\Arquivo2.txt";

            try
            {

                FileInfo fileInfo = new FileInfo(caminhoArquivo);

              
                // fileInfo.CopyTo(caminhoDestino); // copia os dados pra outro arquivo

                string[] linhas = File.ReadAllLines(caminhoArquivo); // le todas linhas e guarda no vetor 
                    
                foreach(string linha in linhas)
                {
                    Console.WriteLine(linha);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("erro de execução: " + e.Message);
            }

        }
    }
}
