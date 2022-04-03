using POOAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura
{
    public static class GerenciadorBonificacao
    {
        private static double _totalBonificacao;

        public static void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public static double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
