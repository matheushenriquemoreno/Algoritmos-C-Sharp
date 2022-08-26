using System;
using Extensio_methods.Extensions;

namespace Extensio_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            var enumteste = testeEnum.teste;

            var nome = enumteste.ObtemNomeEnum();

            Console.WriteLine(nome);


            DateTime dt = new DateTime(2021, 9, 20, 8, 10, 30);
            Console.WriteLine(dt.ElapedTime());

            DateTime dataNascimento1 = new DateTime(1999, 11, 21);
            DateTime dataNascimento2 = new DateTime(2008, 12, 23);

            Console.WriteLine(dataNascimento1.EhMaiorQue18());
            Console.WriteLine(dataNascimento2.EhMaiorQue18());
            Console.WriteLine(dataNascimento2.RetornaUmObjeto());


            string s1 = "GOOD Morning Dear Students! ";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
