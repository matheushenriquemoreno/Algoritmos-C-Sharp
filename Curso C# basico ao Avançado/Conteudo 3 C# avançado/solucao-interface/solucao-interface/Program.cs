using System;
using System.Globalization;
using solucao_interface.Entities;
using solucao_interface.Services;
namespace solucao_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data ");
            Console.Write("Car molde:");
            string modelo = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyyy hs:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("return (dd/mm/yyyy hs:mm): ");
            DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("enter pri per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental car = new CarRental(start, saida, new Vehicle(modelo));

            RetalService rentar = new RetalService(hour, day,new BrasilTexService());

            rentar.ProcessInvoice(car);

            Console.WriteLine("Invoice: \n" + car.Invoice);
        
          
        }
    }
}
