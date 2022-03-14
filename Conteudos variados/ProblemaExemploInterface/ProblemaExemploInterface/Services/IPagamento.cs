using System;
using System.Collections.Generic;
using System.Text;
using ProblemaExemploInterface.Entities;

namespace ProblemaExemploInterface.Services
{
    interface IPagamento
    {

        double CalculaTaxa(double valor);

    }
}
