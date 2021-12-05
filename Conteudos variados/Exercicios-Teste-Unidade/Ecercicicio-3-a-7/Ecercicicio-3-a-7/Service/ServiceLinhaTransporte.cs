using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicicio_3_a_7.Entities;

namespace Exercicicio_3_a_7.Service
{
    class ServiceLinhaTransporte
    {
        List<LinhaDeTransporte> ListLinha { get; set; }

        public ServiceLinhaTransporte()
        {
            ListLinha = new List<LinhaDeTransporte>();
        }

        public void CadastrarLinha(LinhaDeTransporte linha)
        {
            
            ListLinha.Add(linha);
        }

        public void ModificaLinha(LinhaDeTransporte linha)
        {


        }
            
        public void Excluirlinha(LinhaDeTransporte linha)
        {
            ListLinha.Remove(linha);
        }

        public void ReajusteTarifa(LinhaDeTransporte linha, string tipo)
        {
            if(tipo.Equals(TipoLinhaTrasporte.Onibus))
            {
                linha.TarifaLinha = linha.TarifaLinha + (linha.TarifaLinha * 0.1); 
            }
            if (tipo.Equals(TipoLinhaTrasporte.Metro))
            {
                linha.TarifaLinha = linha.TarifaLinha + (linha.TarifaLinha * 0.2);
            }
            if (tipo.Equals(TipoLinhaTrasporte.Onibus))
            {
                linha.TarifaLinha = linha.TarifaLinha + (linha.TarifaLinha * 0.05);
            }
        }


    }
}
