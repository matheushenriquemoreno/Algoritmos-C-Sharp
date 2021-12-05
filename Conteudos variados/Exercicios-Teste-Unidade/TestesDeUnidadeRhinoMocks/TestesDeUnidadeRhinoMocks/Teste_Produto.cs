using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeUnidadeRhinoMocks
{
    public class Teste_Produto
    {
        private IEnumerable<IProduto> _falsosProdutos = new List<IProduto>
        {
            new Produto{ Nome = "bolacha", Valor = 3.0},
            new Produto { Nome = "Arroz 5kg",Valor = 15.25},
            new Produto {Nome = "Macarrão", valor = 3.15}
        };


        public void TesteProdutoInterface()
        {
            MockRe
        }
    }
}
