using System;
using heranca.Entities;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {








            Account acc1 = new Account(1001, "alex", 500.00);
            Account acc2 = new SavingAccount(100, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);





            /*
             * Aula  Upcasting DownCasting
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "maria", 0.0, 500.00);


            // UPCASTING  = conversao da sub classe para superclasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "BOB", 0.0, 200.00);
            Account acc3 = new SavingAccount(1004, "anna", 0.0, 0.01);


            // DOUWCASTING =  conversao da super classe para sub classe // e uma operação insegura.

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            //BusinessAccount acc5 = (BusinessAccount)acc3;  erro na compilação
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // sintaxe alternativa
                acc5.Loan(200.0);
                Console.WriteLine("Loan!!");
            }

            if (acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3;
                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            */
           
        }
    }
}
