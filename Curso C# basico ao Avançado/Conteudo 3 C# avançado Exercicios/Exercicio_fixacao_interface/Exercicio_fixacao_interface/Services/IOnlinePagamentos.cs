

namespace Exercicio_fixacao_interface.Services
{
    interface IOnlinePagamentos
    {

        double Interest(double valor, int mes);
        double PagamentoTaxa(double valor);
  
    }
}
