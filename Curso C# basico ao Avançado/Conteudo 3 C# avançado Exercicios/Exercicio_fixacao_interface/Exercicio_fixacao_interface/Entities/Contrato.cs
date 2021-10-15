using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao_interface.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; private set; }
        
        public Double ValorContrato { get;  private set; }

        public List<Parcelas> ParcelasMes { get; set; }

        public Contrato (int numero, DateTime data, double valor)
        {
            NumeroContrato = numero;
            DataContrato = data;
            ValorContrato = valor;
            ParcelasMes = new List<Parcelas>();
        }

        public void AddParcelas(Parcelas parcela)
        {
            ParcelasMes.Add(parcela);
        }
     

    }
}
