using System;
using System.Globalization;

namespace Exercicio_secao_07_heranca.Entitis
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime data) : base(name, price)
        {
            ManuFactureDate = data;
        }
        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + $"(Manufacture date: {ManuFactureDate:d})";
        }

    
    }
}
