using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando um Designer!");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
