using System;
using System.Collections.Generic;
using System.IO;
using Resolvendo_exercicios_conjuntos.Entities;

namespace Resolvendo_exercicios_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instante = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { UserName = name, Instat = instante });
                    }
                    Console.WriteLine("Total Using: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    
    }
}
