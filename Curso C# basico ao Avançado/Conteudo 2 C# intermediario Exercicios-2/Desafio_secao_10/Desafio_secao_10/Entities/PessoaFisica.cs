using System;


namespace Desafio_secao_10.Entities
{
    class PessoaFisica : Pessoa
    {

        public double GastoSaude { get; set; }

        public PessoaFisica(string name, double renda, double gasto) : base(name, renda)
        {
            GastoSaude = gasto;
        }


        public override double CalculoImposto()
        {
          if(Renda < 20000)
            {
                return (Renda * 0.15) - (GastoSaude * 0.5);
            }
            else
            {
                return (Renda * 0.25) - (GastoSaude * 0.5);
            }
        }
    }
}
