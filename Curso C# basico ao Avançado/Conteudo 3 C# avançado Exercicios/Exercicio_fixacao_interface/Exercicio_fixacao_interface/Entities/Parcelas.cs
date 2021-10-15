using System;
using System.Globalization;

namespace Exercicio_fixacao_interface.Entities
{
    class Parcelas
    {
        public DateTime Data { get; set; }
        public double ValorMensal { get; set; }

        public Parcelas(DateTime data, double valorMensal)
        {
            Data = data;
            ValorMensal = valorMensal;
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy")
                + " - "
                + ValorMensal.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
