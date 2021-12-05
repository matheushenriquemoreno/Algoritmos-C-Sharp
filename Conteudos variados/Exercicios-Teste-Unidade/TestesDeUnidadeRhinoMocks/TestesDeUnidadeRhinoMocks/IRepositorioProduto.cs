using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeUnidadeRhinoMocks
{
    public interface IRepositorioProduto
    {

            /*
             * obtenha produto pela indentificação
             */
        IProduto ObtenhaProduto(int CodigoDoProduto);

        /*
         Obtem uma lista de conceito produto, retorna uma lista de produtos.
         */
        IEnumerable<IProduto> ObtenhaTodosProdutos();

        /*
         Insire Um Produto, retorna true caso sucesso e false caso não
         */
        bool Salvar(IProduto produto);
    }
}
