using System;
using Exercicio_metodos_abstratos.Entities.Enums;

namespace Exercicio_metodos_abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }


    }
}
