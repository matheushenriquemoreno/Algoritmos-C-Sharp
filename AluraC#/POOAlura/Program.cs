using POOAlura.Funcionarios;
using POOAlura.Sitemas;
using System;
using System.Collections.Generic;

namespace POOAlura
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Funcionario teste = roberta;
                //listaFuncionario.Add(teste);

                //MostraFuncionariosEBonificacao();

                UsarSistema();

                Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionario);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor roberta = new Diretor("555.667.623.66") { Nome = "Robertar Fernandez da silva costa " };
            roberta.Senha = "1234";

            GerenteDeConta carlos = new GerenteDeConta("888.565.456-56", "carlos123") { Nome = "Carlos Barbosa" };

            ParceiroComercial parceiro = new ParceiroComercial("marcelo",162785, "asd1234");

            Funcionario joao = new Auxiliar("888-99") { Nome = "João" };

            sistema.Loggar(roberta,"1234");
            sistema.TrocarDeSenha(roberta, "1234");

            sistema.Loggar(carlos, "carlos123");

            sistema.Loggar(parceiro, "123456");
        }

        public static void MostraFuncionariosEBonificacao()
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            Funcionario carlos = new GerenteDeConta("888.565.456-56") { Nome = "Carlos Barbosa" };
            Funcionario roberta = new Diretor("555.667.623.66") { Nome = "Robertar Fernandez da silva costa " };
            Funcionario matheus = new Diretor("896.444.888-99") { Nome = "Matheus Henrique Soares moreno" };
            Funcionario joao = new Auxiliar("888-99") { Nome = "João" };
            Funcionario sergio = new Designer("896.444.888-99") { Nome = "Sergio" };
            Funcionario guilherme = new Desenvolvedor("896.444.888-99") { Nome = "Guilherme" };

            carlos.AumentarSalario();

            listaFuncionario.Add(carlos);
            listaFuncionario.Add(roberta);
            listaFuncionario.Add(matheus);
            listaFuncionario.Add(joao);
            listaFuncionario.Add(sergio);
            listaFuncionario.Add(guilherme);

            foreach (var funcionario in listaFuncionario)
            {
               // funcionario.Teste();
                Console.WriteLine($"Nome: {funcionario.Nome} | Salario: {funcionario.Salario} | Bonificação: {funcionario.GetBonificacao():F2} |Type: {funcionario.GetType()}");
                GerenciadorBonificacao.Registrar(funcionario);
            }
            Console.WriteLine("Total de Bonificações: " + GerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
