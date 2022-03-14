using System;
using _03_Encapsulamento.Entities;

namespace _03_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {


                var cliente = new Cliente(-1, "matheus", "Avenida v3 qd 150");


            }
            catch (InvalidationExeption e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
