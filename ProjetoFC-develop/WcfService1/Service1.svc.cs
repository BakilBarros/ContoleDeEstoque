using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Classes_Basicas;
using Biblioteca.Negocio;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region ações Fornecedor
        public void DeleteFornecedor(Fornecedor fornecedor)
        {
            new FornecedorNegocio().Delete(fornecedor);
        }

        public void InsertFornecedor(Fornecedor fornecedor)
        {
            new FornecedorNegocio().Insert(fornecedor);
        }

        public List<Fornecedor> SelectFornecedor(Fornecedor filtro)
        {
           return new FornecedorNegocio().Select(filtro);
        }

        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            new FornecedorNegocio().Update(fornecedor);
        }

        public bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ações Produto
        public void InsertProduto(Produto produto)
        {
            new ProdutoNegocio().Insert(produto);
        }

        public void UpdateProduto(Produto produto)
        {
            new ProdutoNegocio().Update(produto);
        }

        public void DeleteProduto(Produto produto)
        {
            new ProdutoNegocio().Delete(produto);
        }

        public bool VerificarDuplicidadeProduto(Produto produto)
        {
            return new ProdutoNegocio().VerificarDuplicidade(produto);
        }

        public List<Produto> SelectProduto(Produto filtro)
        {
            return new ProdutoNegocio().Select(filtro);
        }
        #endregion

        #region ações Materia Prima
        public void InsertMateriaPrima(MateriaPrima materiaprima)
        {
            new MateriaPrimaNegocio().Insert(materiaprima);
        }

        public void UpdateMateriaPrima(MateriaPrima materiaprima)
        {
            new MateriaPrimaNegocio().Update(materiaprima);
        }

        public void DeleteMateriaPrima(MateriaPrima materiaprima)
        {
            new MateriaPrimaNegocio().Delete(materiaprima);
        }

        public bool VerificarDuplicidadeMateriaPrima(MateriaPrima materiaprima)
        {
            return new MateriaPrimaNegocio().VerificarDuplicidade(materiaprima);
        }

        public List<MateriaPrima> SelectMateriaPrima(MateriaPrima filtro)
        {
            return new MateriaPrimaNegocio().Select(filtro);
        }
        #endregion

        #region ações Formula
        public void CadastrarFormula(Produto produto)
        {
            new FormulaNegocio().CadastrarFormula(produto);
        }

        public void CadastrarItemFormula(MateriaPrima materiaPrima)
        {
            new FormulaNegocio().CadastrarItemFormula(materiaPrima);
        }

        public void DeleteFormula(Produto produto)
        {
            new FormulaNegocio().DeleteFormula(produto);
        }

        public void DeleteItemFormula(MateriaPrima materiaPrima)
        {
            new FormulaNegocio().DeleteItemFormula(materiaPrima);
        }

        public bool VerificarDuplicidadeFormula(Produto produto)
        {
            return new FormulaNegocio().VerificarDuplicidadeFormula(produto);
        }

        public List<MateriaPrima> SelectFormula(Produto filtro)
        {
            return new FormulaNegocio().SelectFormula(filtro);
        }
        #endregion

        #region ações Compra
        public void InsertCompra(Compra compra)
        {
            new CompraNegocio().Insert(compra);
        }

        public void UpdateCompra(Compra compra)
        {
            new CompraNegocio().Update(compra);
        }

        public void DeleteCompra(Compra compra)
        {
            new CompraNegocio().Delete(compra);
        }

        public bool VerificarDuplicidadeCompra(Compra compra)
        {
            return new CompraNegocio().VerificarDuplicidade(compra);
        }

        public List<Compra> SelectCompra(Compra compra)
        {
            return new CompraNegocio().Select(compra);
        }
        #endregion

    }
}
