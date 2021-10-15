using System;


namespace Exercicio_heranca_polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerhour { get; set; }



        public Employee()
        {

        }
        
        public Employee(string name, int hours, double value)
        {
            Name = name;
            Hours = hours;
            ValuePerhour = value;
        }


        public virtual double Payment()
        {
            return Hours * ValuePerhour;
        }




    }
}
