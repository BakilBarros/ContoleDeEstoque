using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{

    [Serializable]
    public class EntidadeSaida
    {
        private int idSaida;
        private String dataSaida;
        private int quantidadeSaida;
        private double valorTatalSaida;
        private EntidadeEstoque idEstoqueSaida;
        private EntidadeProduto idProdutoSaida;
        private EntidadeDestino idDestinoSaida;

        public EntidadeSaida()
        {
            EntidadeEstoque entidadeEstoque = new EntidadeEstoque();
            EntidadeProduto entidadeProduto = new EntidadeProduto();
            EntidadeDestino entidadeDestino = new EntidadeDestino();
            
        }

        [DataMember(IsRequired = true)]
        public int IdSaida { get => idSaida; set => idSaida = value; }
        [DataMember(IsRequired = true)]
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        [DataMember(IsRequired = true)]
        public int QuantidadeSaida { get => quantidadeSaida; set => quantidadeSaida = value; }
        [DataMember(IsRequired = true)]
        public double ValorTatalSaida { get => valorTatalSaida; set => valorTatalSaida = value; }
        [DataMember(IsRequired = true)]
        public EntidadeEstoque IdEstoqueSaida { get => idEstoqueSaida; set => idEstoqueSaida = value; }
        [DataMember(IsRequired = true)]
        public EntidadeProduto IdProdutoSaida { get => idProdutoSaida; set => idProdutoSaida = value; }
        [DataMember(IsRequired = true)]
        public EntidadeDestino IdDestinoSaida { get => idDestinoSaida; set => idDestinoSaida = value; }

        
  
    }
}
