using ProblemaExemploInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaExemploInterface.Services
{
    class Calculataxa : IPagamento
    {
        public double CalculaTaxa(double valor)
        {
            var taxa = 0.0;
 
            if(valor > 100.00)
            {
                taxa = valor * 0.15;
                return taxa;
            }

            taxa = valor * 0.20;
            return taxa;
        }
    }
}
