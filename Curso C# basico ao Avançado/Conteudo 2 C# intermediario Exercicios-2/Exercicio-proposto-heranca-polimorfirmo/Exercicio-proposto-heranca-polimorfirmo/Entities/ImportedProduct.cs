using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_proposto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }



        public ImportedProduct(string name, double price, double customfee) : base(name, price)
        {
            CustomFee = customfee;
        }

        public override string PriceTag()
        {
           
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

    }
}
