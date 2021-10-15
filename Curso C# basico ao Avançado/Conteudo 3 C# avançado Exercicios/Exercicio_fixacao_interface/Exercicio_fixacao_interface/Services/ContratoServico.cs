using System;
using Exercicio_fixacao_interface.Entities;

namespace Exercicio_fixacao_interface.Services
{
    class ContratoServico
    {

        private IOnlinePagamentos _pagamentos;


        public ContratoServico(IOnlinePagamentos servicopagamento)
        {
            _pagamentos = servicopagamento;
        }

        public void ProcessandoContrato(Contrato contrato, int mes)
        {
            double valorMes = contrato.ValorContrato / mes;

            for(int i = 1; i <= mes; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);
                double updateCota = valorMes + _pagamentos.Interest(valorMes, i);
                double fullCota = updateCota + _pagamentos.PagamentoTaxa(updateCota);
                contrato.AddParcelas(new Parcelas(data, fullCota));
            }
        }
    }
}
