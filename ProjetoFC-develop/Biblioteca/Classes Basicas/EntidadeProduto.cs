using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class EntidadeProduto
    {
       

        private int idProduto;
        private String nomeProduto;
        private double precoProduto;
        private String tipoProduto;
        private String descricaoProduto;
        [DataMember(IsRequired = true)]
        public int IdProduto { get => idProduto; set => idProduto = value; }
        [DataMember(IsRequired = true)]
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        [DataMember(IsRequired = true)]
        public double PrecoProduto { get => precoProduto; set => precoProduto = value; }
        [DataMember(IsRequired = true)]
        public string TipoProduto { get => tipoProduto; set => tipoProduto = value; }
        [DataMember(IsRequired = true)]
        public string DescricaoProduto { get => descricaoProduto; set => descricaoProduto = value; }
    }
}
