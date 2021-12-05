using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TreinamentoTestesUnidade
{
    [SetUpFixture]
    public class Class1
    {
        [SetUp]
        public void MetodoDEInicializacao()
        {

        }

        [TearDown]
        public void MetodoDeFinalizacao()
        {
            // Tudo o que ser finalizado ao termino da execução dos testes.
        }

        [Test]
        public void MetodoDeValidacaoDeCenario()
        {
            // Cenário de teste.
        }

        [Test, Sequential]
        public void MetodoDeValidacaoDeCenarioComSequencial([Values(1,2,3,4,0)] int valor, [Values(true, true, true, true, false)]
                    bool ValorehValido)
        {
            if (ValorehValido)
            {

            }
            else
            {

            }

            // Cenário de teste.
        }

    }
}
