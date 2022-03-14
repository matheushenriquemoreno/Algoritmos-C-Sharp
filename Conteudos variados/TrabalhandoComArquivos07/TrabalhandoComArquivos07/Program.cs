using System;
using System.IO;

namespace TrabalhandoComArquivos07
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasta = @"c:\temp\Arquivo.txt";

            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine("local do diretorio " + Path.GetDirectoryName(pasta));
            Console.WriteLine("Nome do arquivo " + Path.GetFileName(pasta));
            Console.WriteLine("extenção do arquivo " + Path.GetExtension(pasta));
            Console.WriteLine("nome do arquivo sem extenção " + Path.GetFileNameWithoutExtension(pasta));
            Console.WriteLine("caminho da pasta " + Path.GetFullPath(pasta));
            Console.WriteLine("mostra pasta temporaria do sistema   " + Path.GetTempPath());
        }
    }
}
