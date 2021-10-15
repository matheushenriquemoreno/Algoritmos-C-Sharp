using Exercicio_metodos_abstratos.Entities.Enums;

namespace Exercicio_metodos_abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // declarando um metodo abstrato
    }
}
