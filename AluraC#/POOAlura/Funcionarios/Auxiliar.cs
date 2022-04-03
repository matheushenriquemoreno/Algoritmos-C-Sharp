﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAlura.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine(" criando um Auxiliar");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
    }
}
