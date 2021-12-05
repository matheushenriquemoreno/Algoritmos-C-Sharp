using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicicio_3_a_7.Entities
{
    class LinhaDeTransporte
    {

        public int CodigoLinha { get; set; }
        public string DescricaoLinha { get; set; }
        public TipoLinhaTrasporte Tipo { get; set; }
        public int CodigoFornecedor { get; set; }
        public double TarifaLinha { get; set; }

        public LinhaDeTransporte()
        {

        }
        public LinhaDeTransporte(int codigoLinha, string descricaoLinha, TipoLinhaTrasporte tipo, int codigoFornecedor, double tarifaLinha)
        {
            CodigoLinha = codigoLinha;
            DescricaoLinha = descricaoLinha;
            Tipo = tipo;
            CodigoFornecedor = codigoFornecedor;
            TarifaLinha = tarifaLinha;
        }
    }
}
