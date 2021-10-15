using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace solucao_interface.Entities
{
    class Invoic
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoic(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }


        public double TotalPaymente
        {
            get { return BasicPayment + Tax; }
        }



        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) +"\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal paumente: " + TotalPaymente.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
