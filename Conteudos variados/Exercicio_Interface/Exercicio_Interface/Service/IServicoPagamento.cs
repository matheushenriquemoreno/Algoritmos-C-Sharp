using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Service
{
    interface IServicoPagamento
    {
        public double TaxaPagamento(double valor);
        public double JurosSimples(double valor, int parcela);

    }
}
