using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Entities
{
    class Contrato
    {
         public int NumeroContrato { get; private set; }
         public DateTime DataContrato { get; private set; }
         public double ValorContrato { get; private set; }

        public List<Parcelas> ListaParcelas { get; set; } = new List<Parcelas>();

        public Contrato (int numero, DateTime data, double valor)
        {
            NumeroContrato = numero;
            DataContrato = data;
            ValorContrato = valor;
            
        }


        public void AddParcelas(Parcelas parcela)
        {
            ListaParcelas.Add(parcela);
        }
        

    }
}
