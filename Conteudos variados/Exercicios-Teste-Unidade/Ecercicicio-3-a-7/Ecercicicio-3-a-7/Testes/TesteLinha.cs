using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exercicicio_3_a_7.Entities;

namespace Exercicicio_3_a_7.Testes
{
    [TestFixture]
    class TesteLinha
    {

        LinhaDeTransporte linhaErrada = new LinhaDeTransporte
        {
            CodigoLinha = 9999,
            DescricaoLinha = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            Tipo = TipoLinhaTrasporte.Metro,
            CodigoFornecedor = 9999,
            TarifaLinha = 9999.99
        };

        LinhaDeTransporte linhaCerta = new LinhaDeTransporte
        {
            CodigoLinha = 1455,
            DescricaoLinha = "Fim do mundo / UFG Samambaia",
            Tipo = TipoLinhaTrasporte.Barco,
            CodigoFornecedor = 8933,
            TarifaLinha = 10.00
        };

        // Teste Unitarios para cada propriedades da linha de transporte.

        [Test, Sequential]
        public void Teste1([Values(true, false)] bool cenarioEValido,
            [Values(1010, 101000)] int codigoDaLinha)
        {
            LinhaDeTransporte linha = new LinhaDeTransporte { CodigoLinha = codigoDaLinha };
            if (cenarioEValido)
            {
                Assert.IsTrue(ValidaPropriedades.ValidaCodigoLinha(linha));
            }
            else
            {
                Assert.IsFalse(ValidaPropriedades.ValidaCodigoLinha(linha));
            }
        }

        [Test]
        public void Teste3()
        {
            Assert.IsTrue(ValidaPropriedades.ValidaDescricao(linhaCerta));
        }

        [Test]
        public void Teste4()
        {
            Assert.IsFalse(ValidaPropriedades.ValidaDescricao(linhaErrada));
        }

        [Test, Sequential]
        public void Teste5([Values(true, true, true, false)] bool tipoEValido,
            [Values(1, 2, 3, 4)] int tipoDaLinha)
        {
            if (tipoEValido)
            {
                Assert.IsTrue(ValidaPropriedades.ValidaTipoDaLinha((TipoLinhaTrasporte)Enum.ToObject(typeof(TipoLinhaTrasporte),tipoDaLinha)));
            } 
            else
            {
                Assert.IsFalse(ValidaPropriedades.ValidaTipoDaLinha((TipoLinhaTrasporte)Enum.ToObject(typeof(TipoLinhaTrasporte), tipoDaLinha)));
            }
        }

        [Test]
        public void Teste6()
        {
            Assert.IsFalse(ValidaPropriedades.ValidaTipoDaLinha(linhaErrada.Tipo));
        }


        [Test]
        public void Teste7()
        {
            Assert.IsTrue(ValidaPropriedades.ValidaCodigoFornecedor(linhaCerta));
        }

        [Test]
        public void Teste8()
        {
            Assert.IsFalse(ValidaPropriedades.ValidaCodigoFornecedor(linhaErrada));
        }

        [Test]
        public void Teste9()
        {
            Assert.IsTrue(ValidaPropriedades.ValidaTarifa(linhaCerta));
        }

        [Test]
        public void Teste10()
        {
            Assert.IsFalse(ValidaPropriedades.ValidaTarifa(linhaErrada));
        }

        [Test, Sequential]
        public void TesteSequencial()
        {
            // A implementar
        }

    }
}
