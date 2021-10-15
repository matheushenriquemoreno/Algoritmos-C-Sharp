using System;
using System.IO;
namespace Bloco_finaly
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("diretorio não encontrado");
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
            
        }
    }
}
