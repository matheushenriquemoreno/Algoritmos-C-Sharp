using System;

namespace exercicio_condicional_04 {
    class Program {
        static void Main(string[] args) {
            int hora_inicial, hora_final, resultado;
            Console.WriteLine("digite a hora que você entrou e a que saio ");
            hora_inicial = int.Parse(Console.ReadLine());
            hora_final = int.Parse(Console.ReadLine());

            if (hora_inicial < hora_final) {
                resultado = hora_final - hora_inicial; // 2 16 // 16 - 2 = 14
            } else {
                resultado = 24 - hora_inicial + hora_final; // 24 - 16 = 8 + 2 = 10
            }

            Console.WriteLine("o jogo durou {0} horas", resultado);
        }
    }
}
