using System;
using System.IO;

namespace TrabalhandoComArquivos02
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\Temp\Arquivo.txt";

            FileStream file = null;

            StreamReader stream = null;

            StreamReader stream2 = null;

            try
            {
                //stream2 = File.OpenText(arquivo); // outra forma de instanciar o StreamReader

                file = new FileStream(arquivo, FileMode.Open); // pra intanciar existe varias sobreposicao de contrutor, esse escolhido passa o local do arquivo e o que vai fazer nele. Open = abri o arquivo
                stream = new StreamReader(file);


                while(!stream.EndOfStream) // True se a posição do fluxo atual estiver no final caso não esteja False
                {

                    string line = stream.ReadLine();

                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de Execução: " + e);
            }
            finally{
                if (stream != null)
                    stream.Close(); // como essas coneções são recursos externos e estão em contato com direto com o sistema operacional o .net não fecha a coneção 
                if (file != null)
                    file.Close();
            }
        }
    }
}
