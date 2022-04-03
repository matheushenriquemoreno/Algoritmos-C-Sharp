using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base (cpf,3000) 
        {
            Console.WriteLine("criando um Desenvolvedor");
        }

        

        public override void AumentarSalario()
        {
            Salario *= 1.30;
        }

        public override double GetBonificacao()
        {
           return  Salario *= 0.30;
        }
    }
}
