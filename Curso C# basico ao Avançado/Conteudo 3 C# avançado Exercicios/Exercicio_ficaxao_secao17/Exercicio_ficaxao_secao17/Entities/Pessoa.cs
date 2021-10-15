using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_ficaxao_secao17.Entities
{
    class Pessoa
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }


        public Pessoa(string name, string email, double valor)
        {
            Name = name;
            Email = email;
            Salary = valor;
        }

    }
}
