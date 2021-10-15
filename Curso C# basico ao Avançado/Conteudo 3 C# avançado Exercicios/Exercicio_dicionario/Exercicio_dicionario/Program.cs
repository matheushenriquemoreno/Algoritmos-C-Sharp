using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio_dicionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: "); // C:\Users\mathe\list.txt
            string path = Console.ReadLine();
            Dictionary<string, int> votos = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(',');
                        string nomeC = linha[0];
                        int votosC = int.Parse(linha[1]);

                        if (votos.ContainsKey(nomeC)) // ContainsKey(key) = verifica se a dada chave existe
                        {
                            votos[nomeC] += votosC;
                        }
                        else
                        {
                            votos[nomeC] = votosC;
                        }
                    }
                }

                Console.WriteLine("CANDIDATOS: ");
                foreach(var candidatos in votos)
                {
                    Console.WriteLine(candidatos.Key + " : " + candidatos.Value);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
