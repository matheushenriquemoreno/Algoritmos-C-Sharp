using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_ficaxao_secao17.Entities;


namespace Exercicio_ficaxao_secao17
{
    class Program
    {
        static void Main(string[] args)
        {  // C:\Users\mathe\source\Curso C# basico ao Avançado\Conteudo 3 C# avançado Exercicios\Exercicio_ficaxao_secao17\arquivo-dados.txt

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salarioBusca = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Pessoa> listPessoas = new List<Pessoa>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] vetor = sr.ReadLine().Split(',');
                    string name = vetor[0];
                    string email = vetor[1];
                    double salario = double.Parse(vetor[2], CultureInfo.InvariantCulture);
                    listPessoas.Add(new Pessoa(name, email, salario));
                }
            }

            var busca = listPessoas.Where(p => p.Salary > salarioBusca).OrderBy(p => p.Email).Select(p => p.Email);

            foreach(string emails in busca)
            {
                Console.WriteLine(emails);
            }

            var soma = listPessoas.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M' : " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
