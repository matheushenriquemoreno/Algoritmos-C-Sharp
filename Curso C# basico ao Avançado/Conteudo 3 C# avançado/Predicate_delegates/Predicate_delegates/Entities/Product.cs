using System;
using System.Collections.Generic;
using System.Text;

namespace Predicate_delegates.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product()
        {

        }
        public Product(string name, double preco)
        {
            Name = name;
            Price = preco;
        }


        public override string ToString()
        {
            return $"{Name}, {Price:f2}";
        }
    }
}
