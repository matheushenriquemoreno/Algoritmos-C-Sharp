using System;


namespace Desafio_secao_10.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionario { get; set; }

        public PessoaJuridica(string name, double renda, int funcionarios) : base(name, renda)
        {
            NumeroFuncionario = funcionarios;
        }



        public override double CalculoImposto()
        {
            if(NumeroFuncionario > 10)
            {
                return Renda * 0.14;
            }
            else
            {
                return Renda * 0.16;
            }
        }
    }
}
