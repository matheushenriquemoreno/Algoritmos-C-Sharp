using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio_Poo_list {
    class Program {
        static void Main(string[] args) {

            List<Funcionario> flist = new List<Funcionario>();

            Console.Write("how many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                flist.Add(new Funcionario(id, nome, salary));
            }

            Console.Write("Enter employee id tath will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            bool verifica = true;
            foreach (Funcionario fa in flist) {
                if(fa.Id == id2) {
                    Console.Write("Enter the percentage: ");
                    double porcem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    fa.IncreaseSalary(porcem);
                    verifica = false;
                } 
            }
            if(verifica) {
                Console.WriteLine("This id does not exist!");
            }


            /* ou
     
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = flist.Find(x => x.Id == searchId); // logica para pegar o id 

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            */

            Console.WriteLine("\nUpdate list of employees:");
            foreach (Funcionario fa in flist) {
                Console.WriteLine(fa);
            }

        }
    }
}
