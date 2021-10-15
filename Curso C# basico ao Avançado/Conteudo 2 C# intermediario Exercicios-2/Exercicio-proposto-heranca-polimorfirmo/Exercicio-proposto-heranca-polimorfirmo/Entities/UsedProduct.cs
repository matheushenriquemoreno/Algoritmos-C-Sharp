using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_proposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }



        public UsedProduct (string name, double price, DateTime data) : base(name, price)
        {
            ManufactureDate = data;
        } 



        
    }
}
