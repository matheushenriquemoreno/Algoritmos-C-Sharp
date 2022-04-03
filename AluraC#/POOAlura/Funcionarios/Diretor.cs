using POOAlura.Sitemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Funcionarios
{
    public class Diretor : FuncionarioAutentificavel
    {

        // sobrescrevendo a propriedade nome do funcionario para que so seja registrado diretores com o nome maior que 50 caracteres
        public override string Nome { get => base.Nome; set => base.Nome = value.Length >= 30 ? value : throw new InvalidOperationException(); }

        /* Sintaxe similiar a de cima
        public override string Nome
        {
            get => base.Nome;
            set
            {
                if(value.Length >= 30)
                {
                   base.Nome = value;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
        */

        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("criando um diretor!");
        }

        public Diretor(string cpf, string senha) : base(cpf, 5000, senha)
        {

        }

        // a palavra reservada Base faz referencia a classe Mãe ou que e erdada
        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
