using POOAlura.Sitemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Funcionarios
{
    class GerenteDeConta : FuncionarioAutentificavel
    {

        public GerenteDeConta(string cpf) : base(cpf)
        {

        }
 
        public GerenteDeConta(string cpf,string senha) : base(cpf, 4000,senha)
        {
            Console.WriteLine("Criando um GerenteDeConta!");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario += 1.05;
        }

    }
}
