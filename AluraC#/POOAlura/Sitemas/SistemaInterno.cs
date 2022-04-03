using POOAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Sitemas
{
    class SistemaInterno
    {
        public bool Loggar(IAutentificacao funcionario, string senha)
        {
            bool usuarioAtutentificar = funcionario.Autentificar(senha);

            if (usuarioAtutentificar)
            {
                Console.WriteLine("Usuario Autentificado!! Type: " + funcionario.GetType());
                return true;
            }

            Console.WriteLine("Usuario não Autentificado!! Type: " + funcionario.GetType());
            return false;
        }


        public void TrocarDeSenha(IAutentificacao alguemQueImplementa, string senhaNova)
        {
            if (alguemQueImplementa.TrocarDeSenha(senhaNova))
            {
                Console.WriteLine("senha atualizado com sucesso");
            }
            else
            {
                Console.WriteLine("senha não trocada pois não se adequou as regras!!");
            }
        }
    }
}
