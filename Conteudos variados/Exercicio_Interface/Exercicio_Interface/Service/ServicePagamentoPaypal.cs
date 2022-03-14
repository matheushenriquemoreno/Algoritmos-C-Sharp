using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Service
{

    class ServicePagamentoPaypal : IServicoPagamento
    {
        public double JurosSimples(double valor, int parcela)
        {
            return (valor * (parcela / 100)) + valor;
        }

        public double TaxaPagamento(double valor)
        {
            return  valor * 1.02;
        }
    }
}
