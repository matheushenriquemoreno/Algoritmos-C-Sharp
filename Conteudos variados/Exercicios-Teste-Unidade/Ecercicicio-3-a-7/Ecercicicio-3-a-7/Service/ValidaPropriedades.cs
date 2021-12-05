using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicicio_3_a_7.Entities
{
    class ValidaPropriedades
    {
        public static bool ValidaCodigoLinha(LinhaDeTransporte linha)
        {
            if (linha.CodigoLinha > 0 && linha.CodigoLinha < 9999)
            {
                return true;
            }
            return false;
        }

        public static bool ValidaDescricao(LinhaDeTransporte linha)
        {
            if (linha.DescricaoLinha.Length <= 100 && linha.DescricaoLinha.Length > 0)
            {
                return true;
            }
            return false;
        }

        public static bool ValidaTipoDaLinha(TipoLinhaTrasporte tipo)
        {
            if (TipoLinhaTrasporte.Barco == tipo)
            {
                return true;
            }
            if (TipoLinhaTrasporte.Metro == tipo)
            {
                return true;
            }
            if (TipoLinhaTrasporte.Onibus == tipo)
            {
                return true;
            }

            return false;
        }

        public static bool ValidaCodigoFornecedor(LinhaDeTransporte linha)
        {

            if (linha.CodigoFornecedor > 0 && linha.CodigoFornecedor < 9999)
            {
                return true;
            }
            return false;
        }

        public static bool ValidaTarifa(LinhaDeTransporte linha)
        {
            if(linha.TarifaLinha > 0.0 && linha.TarifaLinha < 9999.99)
            {
                return true;
            }
            return false;
        }

    }
}
