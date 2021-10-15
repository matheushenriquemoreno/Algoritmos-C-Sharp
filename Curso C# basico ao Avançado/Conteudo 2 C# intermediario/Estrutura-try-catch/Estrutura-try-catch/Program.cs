using System;

namespace Estrutura_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divisao por zero não aceita!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Formato de escrita errado! " + e.Message);
            }
                
        }
    }
}
