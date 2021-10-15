using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao_interface.Services
{
    class ServicoPagamento : IOnlinePagamentos
    {
        private double TaxaBasica = 0.01;
        private double TaxaFixa = 0.02;
       public double Interest(double valor, int mes)
        {
            return valor * TaxaBasica * mes;
        }
        public double PagamentoTaxa(double valor)
        {
            return valor * TaxaFixa;
        }

    }
}
