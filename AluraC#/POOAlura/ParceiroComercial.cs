using POOAlura.Sitemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura
{
    public class ParceiroComercial : IAutentificacao
    {
        public string Nome { get; set; }
        public int Matricula { get; private set; }
        public string Senha { get; set; }


        public ParceiroComercial(string nome, int matricula, string senha)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Senha = senha;
        }

        public bool Autentificar(string senha)
        {
            return this.Senha == senha;
        }

        public bool TrocarDeSenha(string senhaNova)
        {
            if (senhaNova.Equals(this.Senha) && senhaNova.Length >= 8)
            {
                return false;
                
            }
            this.Senha = senhaNova;
            return true;
        }
    }
}
