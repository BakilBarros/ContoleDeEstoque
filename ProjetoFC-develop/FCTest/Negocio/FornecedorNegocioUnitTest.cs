using System;
using Biblioteca.Classes_Basicas;
using Biblioteca.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FCTest.Negocio
{
    [TestClass]
    public class FornecedorNegocioUnitTest
    {
        private FornecedorNegocio fornecedorNegocio = new FornecedorNegocio();

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoIdMenorQueZero()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = -0;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoIdIgualAZero()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 0;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoCnpjNull()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 3;
            fornecedor.Cnpj = "null";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RazaoSocialNull()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "null";
            fornecedor.Id = 4;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LogadouroNull()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 5;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "null";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoCnpjMaior14()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 6;
            fornecedor.Cnpj = "50268796547444445222000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoCnpjMenor14()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 7;
            fornecedor.Cnpj = "123";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoFornecedorIdNegativo()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = -8;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoRazaoSocialMaiorQueCem()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Fornecedor de Materiais elétricos e produtos Eletrônicos e muito mais";
            fornecedor.Id = 9;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);

        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoRazaoSocialVazio()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "";
            fornecedor.Id = 10;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoLogadouroVazio()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 11;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoComplementoVazio()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 12;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoEstadoMaiorQueDois()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 13;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "Pernambuco";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoEstadoMenorQueDois()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja um";
            fornecedor.Id = 14;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "P";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoCepMaiorQueNove()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 15;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50655545454544874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoEstadoMenorQueNove()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 16;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoEmailVazio()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 17;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoTelefoneVazio()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 18;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "";
            fornecedor.Complemento = "N/A";
            fornecedorNegocio.Insert(fornecedor);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoComplementoMaiorQueVinte()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 19;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "Fica ao lado da loja dois";
            fornecedorNegocio.Insert(fornecedor);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidacaoBairroMaiorQueVinte()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = "Loja Um";
            fornecedor.Id = 20;
            fornecedor.Cnpj = "50268796000154";
            fornecedor.Cep = "50654874";
            fornecedor.Logradouro = "Avenida Um";
            fornecedor.Cidade = "Recife";
            fornecedor.Estado = "PE";
            fornecedor.Bairro = "Curado um, dois três, quatro e cinco";
            fornecedor.Email = "lojaum@gmail.com";
            fornecedor.Telefone = "81 35479854";
            fornecedor.Complemento = "Fica ao lado da loja dois";
            fornecedorNegocio.Insert(fornecedor);
        }
    }
}