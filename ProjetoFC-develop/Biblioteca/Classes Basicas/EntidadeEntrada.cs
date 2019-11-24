using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class EntidadeEntrada
    {

        private int idEntrada;
        private String loteEntrada;
        private int quantidadeEntrada;
        private Double valorTotalEntrada;
        private String dataEntrada;
        private String validadeEntrada;
        private EntidadeEstoque idEstoqueEntrada;
        private EntidadeProduto idProdutoEntrada;

        public EntidadeEntrada()
        {
            EntidadeEstoque entidadeEstoque = new EntidadeEstoque();
            EntidadeProduto entidadeProduto = new EntidadeProduto();
        }

        [DataMember(IsRequired = true)]
        public int IdEntrada { get => idEntrada; set => idEntrada = value; }
        [DataMember(IsRequired = true)]
        public string LoteEntrada { get => loteEntrada; set => loteEntrada = value; }
        [DataMember(IsRequired = true)]
        public int QuantidadeEntrada { get => quantidadeEntrada; set => quantidadeEntrada = value; }
        [DataMember(IsRequired = true)]
        public double ValorTotalEntrada { get => valorTotalEntrada; set => valorTotalEntrada = value; }
        [DataMember(IsRequired = true)]
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        [DataMember(IsRequired = true)]
        public string ValidadeEntrada { get => validadeEntrada; set => validadeEntrada = value; }
        [DataMember(IsRequired = true)]
        public EntidadeEstoque IdEstoqueEntrada { get => idEstoqueEntrada; set => idEstoqueEntrada = value; }
        [DataMember(IsRequired = true)]
        public EntidadeProduto IdProdutoEntrada { get => idProdutoEntrada; set => idProdutoEntrada = value; }


       

    }
}
