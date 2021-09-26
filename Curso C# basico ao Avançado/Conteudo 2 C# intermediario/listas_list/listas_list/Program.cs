using System;
using System.Collections.Generic;
namespace listas_list {
    class Program {
        static void Main(string[] args) {

            /* link da documentação oficial
             https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=net-5.0
            */

            List<string> list = new List<string>(); // estancinado uma lista. a lista começa vazia
              //suporta qualquer tipo            
            List<string> list2 = new List<string> { "maria", "matheus", "adrieela" };

            list.Add("Jão"); // se fosse de produto list.Add(new Product());
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Maria");

            list.Insert(2, "Marco"); // insere um intem na posicao desejada
            list.Add("Adriella");

            foreach (string obj in list) { // le a lista
                Console.WriteLine(obj);
            }

            Console.WriteLine("List cout: " + list.Count); // tamanho da lista 

            // expressao lambda   // predicado e uma função que pega um valor, é retorna verdadeiro ou falso comforme a logica implementadada.
            string s1 = list.Find(x => x[0] == 'A'); // pega um elemento da lista
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Lalst 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First possition 'A' " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First possition 'A' " + pos2);

            List<string> list3 = list.FindAll(x => x.Length == 5); // essa operacao pegou os valores de uma lista com base em um paramentro e coloca em outra lista
            
            Console.WriteLine("--------------------------");
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }


            list.RemoveRange(2, 2);
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }



            list.Remove("Jão");
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }


            list.RemoveAt(0);
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            

        }


    }
}
