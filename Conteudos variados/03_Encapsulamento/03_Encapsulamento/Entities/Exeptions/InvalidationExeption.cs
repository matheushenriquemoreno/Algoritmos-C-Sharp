using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Encapsulamento.Entities
{
    class InvalidationExeption : Exception
    {

       public InvalidationExeption(string Erro) : base(Erro)
        {


        } 


    }
}
