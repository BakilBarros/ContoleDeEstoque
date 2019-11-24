using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class EntidadeEstoque
    {
       private int idEstoque;
        private String nomeEstoque;
        private int quantidadeEstoque;
        private String statusEstoque;
        [DataMember(IsRequired = true)]
        public int IdEstoque { get => idEstoque; set => idEstoque = value; }
        [DataMember(IsRequired = true)]
        public string NomeEstoque { get => nomeEstoque; set => nomeEstoque = value; }
        [DataMember(IsRequired = true)]
        public int QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        [DataMember(IsRequired = true)]
        public string StatusEstoque { get => statusEstoque; set => statusEstoque = value; }
    }
}
