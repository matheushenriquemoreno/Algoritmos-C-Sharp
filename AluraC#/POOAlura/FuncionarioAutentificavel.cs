using POOAlura.Funcionarios;
using POOAlura.Sitemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura
{
        // essa clase foi criada no intuito de ter somente alguns funcionarios que podem entrar em um sistema especifico da empresa
        // e como a regra de negocio essa entidade que entra tem que implementar o metodo Autentificar.
        // E a interface garante o polimorfismo pois tanto funcionarios e terceiros podem entrar
    public abstract class FuncionarioAutentificavel : Funcionario, IAutentificacao
    {
        public string Senha { get; set; }

        public FuncionarioAutentificavel(string cpf) : base(cpf)
        {

        }

        public FuncionarioAutentificavel(string cpf, double salario, string senha) : base(cpf, salario)
        {
            this.Senha = senha;
        }

        public bool TrocarDeSenha(string senhaNova)
        {
            if (senhaNova.Equals(this.Senha))
            {
                return false;
            }
            this.Senha = senhaNova;
            return true;
        }

        public bool Autentificar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
