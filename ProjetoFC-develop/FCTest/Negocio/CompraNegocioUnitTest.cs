using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Negocio;
using Biblioteca.Classes_Basicas;

namespace FCTest.Negocio
{
    [TestClass]
    public class CompraNegocioUnitTest

    {
        private CompraNegocio compraNegocio = new CompraNegocio();
        [TestMethod]
        public void ValidarPrecoCompra()
        {
            Compra compra = new Compra();
            compra.Preco = 1;

            Assert.IsTrue(compraNegocio.ValidarPreco(compra));
        }
        [TestMethod]
        public void ValidarQuantidadeCompra()
        {
            Compra compra = new Compra();
            compra.Quantidade = 1;

            Assert.IsTrue(compraNegocio.ValidarQuantidade(compra));
        }
        [TestMethod]
        public void ValidarTamanhoPrecoMinimo()
        {
            Compra compra = new Compra();
            compra.Preco = 100;

            Assert.IsTrue(compraNegocio.ValidarTamanhoPreçoMinimo(compra));
        }
        [TestMethod]
        public void ValidarTamanhoPrecoMaximo()
        {
            Compra compra = new Compra();
            compra.Preco = 500000;

            Assert.IsTrue(compraNegocio.ValidarTamanhoPreçoMaximo(compra));
        }

        [TestMethod]
        public void ValidarPrecoCompraNula()
        {
            Compra compra = new Compra();
            compra.Preco = 1;

            Assert.IsTrue(compraNegocio.VerificarPrecoCompraNula(compra));
        }

        [TestMethod]
        public void ValidarQuantidadeCompraNula()
        {
            Compra compra = new Compra();
            compra.Quantidade = 1;

            Assert.IsTrue(compraNegocio.VerificarQuantidadeCompraNula(compra));
        }

        [TestMethod]
        public void ValidarCompraDeletar()
        {
            Compra compra = new Compra();
            compra.Preco = 1;

            Assert.IsTrue(compraNegocio.VerificarCompraDeletar(compra));
        }
        [TestMethod]
        public void ValidarTamanhoQuantidadeMinimo()
        {
            Compra compra = new Compra();
            compra.Quantidade = 100;
            Assert.IsTrue(compraNegocio.VerificarTamanhoQuantidadeMinimo(compra));
        }
        [TestMethod]
        public void ValidarTamanhoQuantidadeMaximo()
        {
            Compra compra = new Compra();
            compra.Quantidade = 11111111;
            Assert.IsTrue(compraNegocio.VerificarTamanhoQuantidadeMaximo(compra));
        }
        [TestMethod]
        public void ValidarTamanhoCompraQantidadeNulaTrim()
        {
            Compra compra = new Compra();
            compra.Quantidade = 1;
            Assert.IsTrue(compraNegocio.VerificarQuantidadeCompraNulaTrim(compra));
        }

        [TestMethod]
        public void ValidarTamanhoCompraPrecoNulaTrim()
        {
            Compra compra = new Compra();
            compra.Quantidade = 1;
            Assert.IsTrue(compraNegocio.VerificarPrecoCompraNulaTrim(compra));
        }
    }


}
