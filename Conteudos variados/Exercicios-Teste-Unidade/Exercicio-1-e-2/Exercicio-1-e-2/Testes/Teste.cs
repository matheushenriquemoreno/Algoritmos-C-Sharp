using Exercicio_1_e_2.Entities;
using System;
using NUnit.Framework;

namespace Exercicio_1_e_2.Testes
{
    class Teste
    {
      

        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void Teste1()
        {
            Assert.Throws<ArgumentException>(() => Descontos.CalcularDesconto(-1));

        }

        [Test]
        public void Teste2()
        {
            double valorEsperado = 950.00;

            Assert.AreEqual(valorEsperado, Descontos.CalcularDesconto(1000.00));
        }

        [Test]
        public void Teste3()
        {
            double valorEsperado = 4320.00;

            Assert.AreEqual(valorEsperado, Descontos.CalcularDesconto(4800.00));
        }

        [Test]
        public void Teste4()
        {
            double valorEsperado = 5000.00;

            Assert.AreEqual(valorEsperado, Descontos.CalcularDesconto(10000.00));
        }

        [Test]
        public void Teste5()
        {
            double valorEsperado = 20000.01;

            Assert.AreEqual(valorEsperado, Descontos.CalcularDesconto(20000.01));
        }

        [Test, Sequential]
        public void TesteSequencial([Values(500, 1000, 2000, 3000, 7000, 40000)] double valorTotal,
            [Values(500, 950, 1800, 2700, 3500, 40000)] double valorComDesconto,
            [Values(1, 2, 3, 4, 5, 6)] int entradaSwhitch)
        {

            switch (entradaSwhitch)
            {
                case 1:
                    Assert.IsTrue(valorTotal == Descontos.CalcularDesconto(valorComDesconto));
                    break;
                case 2:
                    Assert.IsTrue(valorTotal != Descontos.CalcularDesconto(valorComDesconto));
                    break;
                case 3:
                    Assert.IsTrue(valorTotal != Descontos.CalcularDesconto(valorComDesconto));
                    break;
                case 4:
                    Assert.IsTrue(valorTotal != Descontos.CalcularDesconto(valorComDesconto));
                    break;
                case 5:
                    Assert.IsTrue(valorTotal != Descontos.CalcularDesconto(valorComDesconto));
                    break;
                case 6:
                    Assert.IsTrue(valorTotal == Descontos.CalcularDesconto(valorComDesconto));
                    break;
                default:
                    break;
            }
        }

        
    }

}
