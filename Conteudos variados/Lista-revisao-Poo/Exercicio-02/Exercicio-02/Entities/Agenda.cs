using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02.Entities
{
    class Agenda
    {
        Pessoa[] VetorPessoa;

        public Agenda(int numerovetor)
        {
            VetorPessoa = new Pessoa[numerovetor];
        }
        

        public void ArmazenaPessoa(string name, int idade, double altura)
        {
            for (int i = 0; i < VetorPessoa.Length; i++)
            {
                VetorPessoa[i] = new Pessoa(name, idade, altura);
            }
        }

        public void RemovePessoa(string name)
        {

            for (int i = 0; i < VetorPessoa.Length; i++)
            {
                if (VetorPessoa[i].Nome.Equals(name))
                {
                    VetorPessoa[i] = null;
                }
            }

        }

        public void BuscaPessoa(string name)
        {
            for (int i = 0; i < VetorPessoa.Length; i++)
            {
                if (VetorPessoa[i].Nome.Equals(name))
                {
                    Console.WriteLine("Pesso na posição = " + i);
                }
                else
                {
                    Console.WriteLine("Pessoa não localizada");
                }
            }
        }

        public void ImprimeAgenda()
        {
            foreach(var pessoa in VetorPessoa)
            {
                Console.WriteLine(pessoa);
            }
        }

        public void ImprimePessoa(int localizacao)
        {
            for(int i = 0; i < VetorPessoa.Length; i++)
            {
               if(i == localizacao)
                {
                    Console.WriteLine(VetorPessoa[i]);
                }
                else
                {
                    Console.WriteLine("Pessoa não encontrada!!");
                }
            }
        }


    }
}
