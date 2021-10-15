using System;


namespace Exercicio_heranca_polimorfismo.Entities
{
    class OutsouserEmployee : Employee
    {

       public double AdditionalCharge { get; set; }



        public OutsouserEmployee()
        {

        }

        public OutsouserEmployee(string name, int hours, double value, double charge) : base(name, hours, value)
        {
            AdditionalCharge = charge;
        }


        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }


    }
}
