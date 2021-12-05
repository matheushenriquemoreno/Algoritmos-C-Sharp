using System;
using System.Globalization;

namespace Exercicio_secao_07_heranca.Entitis
{
    class ImportedProducts : Product
    {
        public double CustomFee { get; set; }

        public ImportedProducts(string name, double price, double customfee) : base(name, price)
        {
            CustomFee = customfee;
        }

        public override string PriceTag()
        {
            return  $"{Name} $ " +
                $"{TotalPrice().ToString("F2",CultureInfo.InvariantCulture)} " +
                $"(Customs fee: " +
                $"{CustomFee.ToString("F2", CultureInfo.InvariantCulture)})" ; 
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

    }
}
