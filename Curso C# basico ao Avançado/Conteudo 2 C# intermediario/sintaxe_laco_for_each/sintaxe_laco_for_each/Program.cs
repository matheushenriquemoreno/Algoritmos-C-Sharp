using System;
using System.Collections.Generic;
namespace sintaxe_laco_for_each {
    class Program {
        static void Main(string[] args) {
            string[] vetor = new string[] { "maria", "Alex", "bob", "Matheus" };
            for(int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i]);
            }
            Console.WriteLine("-----------------------------");

            // tipo do vetor -> apelido pra cada elemento do vetor 
            foreach (string obj in vetor) {
                Console.WriteLine(obj);
            }

            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers) {
                Console.Write($"{element} ");
            }
            // Output:
            // 0 1 1 2 3 5 8 13

        }
    }
}
