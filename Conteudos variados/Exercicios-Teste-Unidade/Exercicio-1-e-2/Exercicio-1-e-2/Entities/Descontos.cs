using System;

namespace Exercicio_1_e_2.Entities
{
    class Descontos
    {
      public static double CalcularDesconto(double valor)
        {
            if (valor <= 0.0)
            {
                throw new ArgumentException();
            }
            if (valor >= 1000.00 && valor < 2000.00)
            {
                return valor - (valor * 0.05);
            }
            if (valor >= 2000.00 && valor < 5000.00)
            {
                return valor - (valor * 0.1);
            }
            if (valor >= 5000.00 && valor < 20000.00)
            {
                return valor - (valor * 0.50);
            }
            return valor;
        }
    }
}
