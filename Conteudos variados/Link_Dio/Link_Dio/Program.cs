using System;
using System.Linq;

namespace Link_Dio
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ArrayNumeros = new int[18] { 1, 2, 3, 8, 9, 18, 19, 25, 29, 38,42,59,64,78,9,18,25,38};


            var numeroPares =
                from numeros in ArrayNumeros
                where numeros % 2 == 0
                orderby numeros
                select numeros;

            var numerosImpares =
                from impar in ArrayNumeros
                where impar % 2 != 0
                orderby impar descending
                select impar;

            var numeroPares2 = ArrayNumeros.Where(x => x % 2 == 0).OrderByDescending(x => x).ToList();


            var menor = ArrayNumeros.Min(); // retorna o menor valor de uma coleção
            var maior = ArrayNumeros.Where(x => x < 50).Max(); // retorna o maior elemento
            maior = ArrayNumeros.Max();
            var media = ArrayNumeros.Average(); // retorna a media dos elementos
            var soma = ArrayNumeros.Sum();// resultado da soma de todos os elementos  
            var distinct = ArrayNumeros.Distinct().ToList(); // retorna um novo array sem os valores repetidos

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Numeros do array Original: " + string.Join(", ", ArrayNumeros));
            Console.WriteLine("---------------------------------");


            Console.WriteLine($"Menor: {menor} \nMaior: {maior} \nMedia: {media:F2} \nSoma: {soma} \nArray sem numeros repetidos: {string.Join(", ", distinct)}");
            Console.WriteLine("numeros pares de dentro do array: " + string.Join(", ", numeroPares));
            Console.WriteLine("numeros impares de dentro do array: " + string.Join(", ", numerosImpares));


        }
    }
}
