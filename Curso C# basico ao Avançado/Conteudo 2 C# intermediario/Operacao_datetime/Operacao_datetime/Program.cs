using System;

namespace Operacao_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d2 = d.AddHours(2);

            DateTime d3 = d.AddMinutes(3);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime boleto = DateTime.Now;

            DateTime prazo = boleto.AddDays(7);

            Console.WriteLine("boleto " + boleto +"\nprazo final " + prazo.ToString("d"));

            DateTime data1 = new DateTime(2000, 10, 15);
            DateTime data2 = new DateTime(2001, 10, 18);

            TimeSpan t = data2.Subtract(data1);

            Console.WriteLine(t);
           



        }
    }
}
