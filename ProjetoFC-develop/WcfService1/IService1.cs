using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region ações Fornecedor
        [OperationContract]
        void InsertFornecedor(Fornecedor fornecedor);
        [OperationContract]
        void UpdateFornecedor(Fornecedor fornecedor);
        [OperationContract]
        void DeleteFornecedor(Fornecedor fornecedor);
        [OperationContract]
        bool VerificarDuplicidadeFornecedor(Fornecedor fornecedor);
        [OperationContract]
        List<Fornecedor> SelectFornecedor(Fornecedor filtro);
        #endregion

        #region ações Produto
        [OperationContract]
        void InsertProduto(Produto produto);
        [OperationContract]
        void UpdateProduto(Produto produto);
        [OperationContract]
        void DeleteProduto(Produto produto);
        [OperationContract]
        bool VerificarDuplicidadeProduto(Produto produto);
        [OperationContract]
        List<Produto> SelectProduto(Produto filtro);
        #endregion

        #region ações Materia Prima
        [OperationContract]
        void InsertMateriaPrima(MateriaPrima materiaprima);
        [OperationContract]
        void UpdateMateriaPrima(MateriaPrima materiaprima);
        [OperationContract]
        void DeleteMateriaPrima(MateriaPrima materiaprima);
        [OperationContract]
        bool VerificarDuplicidadeMateriaPrima(MateriaPrima materiaprima);
        [OperationContract]
        List<MateriaPrima> SelectMateriaPrima(MateriaPrima filtro);
        #endregion

        #region ações Formula
        [OperationContract]
        void CadastrarFormula(Produto produto);
        [OperationContract]
        void CadastrarItemFormula(MateriaPrima materiaPrima);
        [OperationContract]
        void DeleteFormula(Produto produto);
        [OperationContract]
        void DeleteItemFormula(MateriaPrima materiaPrima);
        [OperationContract]
        bool VerificarDuplicidadeFormula(Produto produto);
        [OperationContract]
        List<MateriaPrima> SelectFormula(Produto filtro);
        #endregion

        #region ações Compra
        [OperationContract]
        void InsertCompra(Compra compra);
        [OperationContract]
        void UpdateCompra(Compra compra);
        [OperationContract]
        void DeleteCompra(Compra compra);
        [OperationContract]
        bool VerificarDuplicidadeCompra(Compra compra);
        [OperationContract]
        List<Compra> SelectCompra(Compra compra);
        #endregion

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
