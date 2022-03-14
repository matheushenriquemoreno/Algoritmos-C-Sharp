using System;
using System.Collections.Generic;
using System.Text;
using ProblemaExemploInterface.Entities;

namespace ProblemaExemploInterface.Services
{
    class ServiceLocacao
    {
        public readonly IPagamento _servicoCalculo;

        public ServiceLocacao(IPagamento injecaoConstrutor)
        {
            _servicoCalculo = injecaoConstrutor;
        }

        public double CalculaValorTaxa(double valor)
        {
            return _servicoCalculo.CalculaTaxa(valor);
        }

        public double RetornaValorApagar(Carro carro, Locacao locacao)
        {

            var hora = carro.Saida.Subtract(carro.Entrada);

            return Math.Ceiling(hora.TotalHours) > 12 ?
                   Math.Ceiling(hora.TotalHours) > 24 ? locacao.ValorDia * hora.Days + ((Math.Ceiling(hora.TotalHours) - (24 * hora.Days)) <= 24  ? locacao.ValorDia : 0)
                  : locacao.ValorDia :
                  locacao.ValorHora * Math.Ceiling(hora.TotalHours);
        }
    }
}
