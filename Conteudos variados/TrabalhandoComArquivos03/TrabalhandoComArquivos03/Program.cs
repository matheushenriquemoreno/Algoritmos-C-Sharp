using System;
using System.IO;
namespace TrabalhandoComArquivos03
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"c:\Temp\Arquivo.txt";

            Modificacao(arquivo);

            try
            {
                using (FileStream file = new FileStream(arquivo, FileMode.Open))
                {
                    using (StreamReader stream = new StreamReader(file))
                    {
                        while (!stream.EndOfStream)
                        {
                            string line = stream.ReadLine();

                            //Console.WriteLine(line);
                        }

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de execução: " + e);
            }
        }


        public static void Modificacao(string arquivo)
        {

            try
            {
                var contador = 0;
                using (StreamReader stream1 = File.OpenText(arquivo))
                {
                    while (!stream1.EndOfStream)
                    {
                        string line = stream1.ReadLine();

                        Console.WriteLine(line + " linha " + contador);
                        contador ++;
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de execução: " + e);
            }

        }


    }
}
