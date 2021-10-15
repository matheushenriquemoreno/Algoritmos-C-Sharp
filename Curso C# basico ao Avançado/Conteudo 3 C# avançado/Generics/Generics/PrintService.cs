using System;

namespace Generics
{
    class PrintService<T>
    {

        private T[] _values = new T[10];
        private int _contador = 0;

        public void AddValue(object valor)
        {
            if(_contador == 10)
            {
                throw new InvalidOperationException("Is full");
            }
            _values[_contador] = T;
            _contador++;
        }

        public T First()
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("Is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");

            for(int i = 0; i < _contador - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if(_contador > 0)
            {
                Console.Write(_values[_contador - 1]+"]");
            }

        }


    }
}
