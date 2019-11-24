using System;
using Biblioteca.Classes_Basicas;
using Biblioteca.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FCTest.Negocio
{
    [TestClass]
    public class MateriaPrimaNegocioUnitTest
    {
        private MateriaPrimaNegocio materiaPrimaNegocio = new MateriaPrimaNegocio();

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoEstoqueAtualZero()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrimaNegocio.ValidarEstoqueAtual(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoValidadeNula()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrimaNegocio.ValidarValidade(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoValidadeAntesAgora()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Validade = DateTime.Now.AddDays(-1);
            materiaPrimaNegocio.ValidarValidade(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoLoteNulo()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrimaNegocio.ValidarLote(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoLoteVazio()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Lote = "";
            materiaPrimaNegocio.ValidarLote(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoLoteMaior10()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Lote = "Lorem ipsum";
            materiaPrimaNegocio.ValidarLote(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoDescricaoNula()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrimaNegocio.ValidarDescricao(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoDescricaoVazio()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Descricao = "";
            materiaPrimaNegocio.ValidarDescricao(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoDescricaoMaior50()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Descricao = "Lorem ipsum dolor sit amet, consectetuer adipiscing";
            materiaPrimaNegocio.ValidarDescricao(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoNomeNulo()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrimaNegocio.ValidarNome(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoNomeNaoVazio()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Nome = "";
            materiaPrimaNegocio.ValidarNome(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoNomeMenorIgaual20()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Nome = "Lorem ipsum dolor sit";
            materiaPrimaNegocio.ValidarNome(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoMateiraPrimaNula()
        {
            materiaPrimaNegocio.ValidarMateriaPrima(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoMateiraPrimaIdNula()
        {
            materiaPrimaNegocio.ValidarMateriaPrimaId(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoMateiraPrimaIdNegativo()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.Id = -1;
            materiaPrimaNegocio.ValidarMateriaPrimaId(materiaPrima);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoMateiraPrimaIdZero()
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrimaNegocio.ValidarMateriaPrimaId(materiaPrima);
        }
    }
}
