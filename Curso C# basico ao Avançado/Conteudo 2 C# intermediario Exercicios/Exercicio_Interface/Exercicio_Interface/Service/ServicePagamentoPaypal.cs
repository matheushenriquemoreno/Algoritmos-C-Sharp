using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Service
{

    class ServicePagamentoPaypal : IServicoPagamento
    {
        public double JurosSimples(double valor, int mes)
        {
            return ((mes / 100.00) * valor ) + valor;
        }

        public double TaxaPagamento(double valor)
        {
            return (valor * 0.02) + valor;
        }
    }
}
