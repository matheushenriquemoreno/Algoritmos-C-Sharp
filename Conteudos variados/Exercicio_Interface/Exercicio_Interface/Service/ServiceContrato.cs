using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Interface.Entities;

namespace Exercicio_Interface.Service
{
    class ServiceContrato
    {
        public Contrato Contrato { get; set; }
        public readonly IServicoPagamento _servicoPagamento;
        /*
         Injeção de dependencia via contrutor da classe, gerando um acoplamento fraco,
         a classe Servicecontrato não conhece a dependecia Concreta, Se a classe que implementar a interface  IServicoPagamento mudar, nada acontece com a classe de serviço 
        */
        public ServiceContrato(Contrato contrato, IServicoPagamento pagamento) 
        {
            Contrato = contrato;
            _servicoPagamento = pagamento;
        }


        public void CalculaParcelas(int mes)
        {
            var valorMes = Contrato.ValorContrato / mes;

            for (int i = 1; i <= mes; i++)
            {
                var ResultadoJurosSimples = _servicoPagamento.JurosSimples(valorMes, i);
                var ResultadoTaxaPagamento = _servicoPagamento.TaxaPagamento(ResultadoJurosSimples);

                Parcelas parcelaMes = new Parcelas(Contrato.DataContrato.AddMonths(i), ResultadoTaxaPagamento);

                Contrato.AddParcelas(parcelaMes);
                
            }

        }

    }
}
