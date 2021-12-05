using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestesDeUnidadeRhinoMocks;
using Rhino.Mocks; 

namespace UnitTestProject1
{
    [TestClass]
    public class TesteStubProdutoAbstrato
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProdutoBase produto = MockRepository.GenerateStub<ProdutoBase>();
            produto.Nome = "Produto base";
            produto.Preco = 3.25;

            Assert.AreEqual(3.25, produto.Preco);
        }
    }
}
