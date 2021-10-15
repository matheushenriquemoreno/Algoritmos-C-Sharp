using System;
using Exercicio_tratamento_excecoes.Entities;
using Exercicio_tratamento_excecoes.Entities.Exceptions;

namespace Exercicio_tratamento_excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (mm/dd/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());


                Reservation reservetion = new Reservation(number, entrada, saida);
                Console.WriteLine("Reservetion: " + reservetion);

                Console.WriteLine("\nEnter data to update the reservario: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (mm/dd/yyyy): ");
                saida = DateTime.Parse(Console.ReadLine());


                reservetion.UpdateDates(entrada, saida);
                Console.WriteLine("Reservertion " + reservetion);
            }
            catch (DomainException e )
            {
                Console.WriteLine(e);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
