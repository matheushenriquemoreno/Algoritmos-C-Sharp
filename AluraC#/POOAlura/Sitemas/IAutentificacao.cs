using POOAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Sitemas
{
    public interface IAutentificacao 
    {
        bool Autentificar(string senha);
        bool TrocarDeSenha(string senhaNova);
    }
}
