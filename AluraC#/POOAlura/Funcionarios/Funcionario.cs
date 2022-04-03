using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Funcionarios
{
    public abstract class Funcionario // funcionario seria uma abstração e as classes concretas as que implementam ela.
    {
        public static int TotalDeFuncionario { get; private set; }

        public virtual string Nome { get; set; }
        public double Salario { get; protected set; }
        public string CPF { get; private set; }

        public Funcionario(string cpf)
        {
            CPF = cpf;
        }

        public Funcionario(string cpf, double salario) : this(cpf)
        {
            Console.WriteLine("criando um Funcionario!");

            Salario = salario;

            TotalDeFuncionario++;
        }

        public void Teste()
        {
            Console.WriteLine("Vai ser executado pra todo mundo");
        }

        /*Quando se cria metodos asbtract as clases que herdarem de Funcionario vão ser obrigadas a implementar esses metodos*/
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

    }
}
