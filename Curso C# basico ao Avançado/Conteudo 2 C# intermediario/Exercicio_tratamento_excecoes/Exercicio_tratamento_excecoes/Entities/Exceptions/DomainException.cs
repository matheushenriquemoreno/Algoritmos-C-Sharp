using System;


namespace Exercicio_tratamento_excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException 
    {
        public DomainException(string message) : base(message)
        {

        }

    }
}
