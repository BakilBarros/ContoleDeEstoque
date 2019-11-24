    using System;
    using System.Collections.Generic;
    using Biblioteca.Classes_Basicas;
    using Biblioteca.DAO;
    using Biblioteca.Negocio;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

namespace FCTest.Integracao
{
    [TestClass]
    public class FornecedorNegocioIntegarationTest
    {
        private FornecedorNegocio fornecedorNegocio;
        private Mock<InterfaceFornecedor> mockFornecedorRepository;

        public FornecedorNegocioIntegarationTest()
        {
            fornecedorNegocio = new FornecedorNegocio();
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TesteFornecedorDao()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>
            {
                    new Fornecedor{ Id=1,
                    Cnpj = "12345678901234",
                    Cep= "54220130",
                    RazaoSocial= "razao 1",
                    Logradouro = "rua 1",
                    Cidade = "cidade 1",
                    Estado = "pe",
                    Bairro = "bairro 1",
                    Email = "e-mail 1",
                    Telefone = "12345678",
                    Complemento = "casa 1"},
                new Fornecedor{ Id=2,
                    Cnpj = "23456789012345",
                    Cep= "54220130",
                    RazaoSocial= "razao 2",
                    Logradouro = "rua 2",
                    Cidade = "cidade 2",
                    Estado = "pe",
                    Bairro = "bairro 2",
                    Email = "e-mail 2",
                    Telefone = "12345678",
                    Complemento = "casa 2"},
                new Fornecedor{ Id=3,
                    Cnpj = "34567890123456",
                    Cep= "54220130",
                    RazaoSocial= "razao 3",
                    Logradouro = "rua 3",
                    Cidade = "cidade 3",
                    Estado = "pe",
                    Bairro = "bairro 3",
                    Email = "e-mail 3",
                    Telefone = "12345678",
                    Complemento = "casa 3"}
            };

            this.mockFornecedorRepository = new Mock<InterfaceFornecedor>();
            this.mockFornecedorRepository.Setup(p => p.Select(null)).Returns(fornecedores);

            this.fornecedorNegocio.Dados = this.mockFornecedorRepository.Object;
            List<Fornecedor> resultado = this.fornecedorNegocio.Select(null);
            Assert.AreEqual(fornecedores, resultado);
        }

        [TestMethod]
        public void VerificarDuplicidadeFalse()
        {
            Fornecedor fornecedor =new Fornecedor
            {
                Id = 1,
                Cnpj = "12345678901234",
                Cep = "54220130",
                RazaoSocial = "razao 1",
                Logradouro = "rua 1",
                Cidade = "cidade 1",
                Estado = "pe",
                Bairro = "bairro 1",
                Email = "e-mail 1",
                Telefone = "12345678",
                Complemento = "casa 1"
            };

            this.mockFornecedorRepository = new Mock<InterfaceFornecedor>();
            this.mockFornecedorRepository.Setup(p => p.VerificarDuplicidade(fornecedor)).Returns(false);

            this.fornecedorNegocio.Dados = this.mockFornecedorRepository.Object;
            Boolean resultado = this.fornecedorNegocio.VerificarDuplicidade(fornecedor);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void VerificarDelete()
        {
            Fornecedor fornecedor = new Fornecedor
            {
                Id = 1,
                Cnpj = "12345678901234",
                Cep = "54220130",
                RazaoSocial = "razao 1",
                Logradouro = "rua 1",
                Cidade = "cidade 1",
                Estado = "pe",
                Bairro = "bairro 1",
                Email = "e-mail 1",
                Telefone = "12345678",
                Complemento = "casa 1"
            };

            this.mockFornecedorRepository = new Mock<InterfaceFornecedor>();
            this.mockFornecedorRepository.Setup(p => p.Delete(fornecedor));
            this.mockFornecedorRepository.Setup(p => p.VerificarDuplicidade(fornecedor)).Returns(true);

            this.fornecedorNegocio.Dados = mockFornecedorRepository.Object;
            this.fornecedorNegocio.Delete(fornecedor);
            this.mockFornecedorRepository.Verify(a => a.Delete(It.IsAny<Fornecedor>()));
        }

        [TestMethod]
        public void VerificarInsert()
        {
            Fornecedor fornecedor = new Fornecedor
            {
                Id = 1,
                Cnpj = "12345678901234",
                Cep = "54220130",
                RazaoSocial = "razao 1",
                Logradouro = "rua 1",
                Cidade = "cidade 1",
                Estado = "pe",
                Bairro = "bairro 1",
                Email = "e-mail 1",
                Telefone = "12345678",
                Complemento = "casa 1"
            };

            this.mockFornecedorRepository = new Mock<InterfaceFornecedor>();
            this.mockFornecedorRepository.Setup(p => p.Insert(fornecedor));
            this.mockFornecedorRepository.Setup(p => p.VerificarDuplicidade(fornecedor)).Returns(false);

            this.fornecedorNegocio.Dados = mockFornecedorRepository.Object;
            this.fornecedorNegocio.Insert(fornecedor);
            this.mockFornecedorRepository.Verify(a => a.Insert(It.IsAny<Fornecedor>()));
        }

        [TestMethod]
        public void VerificarUpdate()
        {
            Fornecedor fornecedor = new Fornecedor
            {
                Id = 1,
                Cnpj = "12345678901234",
                Cep = "54220130",
                RazaoSocial = "razao 1",
                Logradouro = "rua 1",
                Cidade = "cidade 1",
                Estado = "pe",
                Bairro = "bairro 1",
                Email = "e-mail 1",
                Telefone = "12345678",
                Complemento = "casa 1"
            };

            this.mockFornecedorRepository = new Mock<InterfaceFornecedor>();
            this.mockFornecedorRepository.Setup(p => p.Update(fornecedor));
            this.mockFornecedorRepository.Setup(p => p.VerificarDuplicidade(fornecedor)).Returns(true);

            this.fornecedorNegocio.Dados = mockFornecedorRepository.Object;
            this.fornecedorNegocio.Update(fornecedor);
            this.mockFornecedorRepository.Verify(a => a.Update(It.IsAny<Fornecedor>()));
        }
    }
}