using System;
using System.Collections.Generic;
using System.Text;

namespace Link_Lambida.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price:f2}, {Category.Name}, {Category.Tier}";
        }


    }
}
