using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Entities
{
    class Parcelas
    {
        public DateTime DataMes { get; set; }
        public double ValorMes { get; set; }

        public Parcelas (DateTime data, double valor)
        {
            DataMes = data;
            ValorMes = valor;
        }


        public override string ToString()
        {
            return $"{DataMes.ToString("dd/MM/yyyy")} - {ValorMes:F2}";
        }


    }
}
