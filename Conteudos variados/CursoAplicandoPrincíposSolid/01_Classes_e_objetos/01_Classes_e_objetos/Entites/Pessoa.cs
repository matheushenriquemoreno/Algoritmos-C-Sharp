using System;

namespace _01_Classes_e_objetos
{
    partial class Program
    {
        class Pessoa
        {
            public string nome;
            public int idade;
            public string genero;

            public Pessoa() // contrutor padrao 
            {
                /*  quando se chama um objeto o popula 
                    tipo de referência = null
                    tipo valor = 0
                 */

            }

            public Pessoa(string nome, int idade, string genero)
            {
                this.nome = nome;
                this.idade = idade;
                this.genero = genero;
            }

            public override string ToString()
            {
                return $"olá, sou {nome}, tenho {idade} anos é sou do sexo {genero}";
            }

        }
    }
}
