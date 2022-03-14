using System;
using System.IO;
namespace TrabalhandoComArquivos04
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"c:\Temp\Arquivo.txt";
            string copia = @"c:\Temp\Arquivo5.txt";

            lerArquivoEFazCopiaLetraMaiscula(arquivo, copia);

        }


        public static void lerArquivoEFazCopiaLetraMaiscula(string arquivoOrigem, string copia)
        {

            try
            {

                var complemento = Guid.NewGuid();

                string[] line = File.ReadAllLines(arquivoOrigem);

                using (StreamWriter stream = File.AppendText(copia))
                {
                    foreach (string linhas in line)
                    {
                        stream.WriteLine(linhas.ToUpper() + " : " + complemento);
                    }

                }


            }
            catch (IOException e)
            {
                Console.WriteLine(" Erro execução " + e);
            }

        }

    }
}
