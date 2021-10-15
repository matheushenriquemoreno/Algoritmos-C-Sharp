using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_heranca_polimorfismo.Entities;

namespace Exercicio_heranca_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} Data:");
                Console.Write("Outsousced: (y/n)? ");
                char verifica = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(verifica == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additonal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsouserEmployee(name, hours, value, additonal)); // intanciando um funcionario tercerizado de outra claase.
                }
                else
                {
                    list.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTES");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
               
        }
    }
}
