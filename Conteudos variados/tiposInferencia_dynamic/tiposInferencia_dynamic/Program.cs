using System;

namespace tiposInferencia_dynamic
{
    class Program
    {

        public class Conennction
        {
            public string ConectionString;
            public void Conectar()
            {
                Console.WriteLine("Conectando...");
            }

            public void Encerrar()
            {
                Console.WriteLine("Encerrando...");
            }
        }

        public static class Fabrica
        {
            public static Conennction CriarConection()
            {
                return new Conennction();
            }
        }


        static void Main(string[] args)
        {

            Conennction Exemplo1 = new Conennction() { ConectionString = "BANCO" };

            /*inferencia de tipos OBS: não utilizado com polimorfismo*/

            var Exemplo2 = new Conennction() { ConectionString = "BANCO" };

            var Exemplo3 = Fabrica.CriarConection();

            Exemplo3.Conectar();
            Exemplo2.Encerrar();

            /*
              dynamic e pra ser usado somente pra objetos que a aplicação vai conhecer em tempo de execução.
            */

            dynamic Exemplo4 = Fabrica.CriarConection();

            Exemplo4.XXXXXX = "Banco";
            Exemplo4.EsseMEtadoNaoExisteEnaoDaErroEmTempoDeCompilacao();
        }
    }
}
