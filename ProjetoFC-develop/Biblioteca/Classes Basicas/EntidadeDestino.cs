using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class EntidadeDestino
    {
        private int idDestino;
        private String estadoEndereco;
        private String cidadeEndereco;
        private String ruaEndereco;
        private String bairroEndereco;
        private String cepEndereco;
        [DataMember(IsRequired = true)]
        public int IdDestino { get => idDestino; set => idDestino = value; }
        [DataMember(IsRequired = true)]
        public string EstadoEndereco { get => estadoEndereco; set => estadoEndereco = value; }
        [DataMember(IsRequired = true)]
        public string CidadeEndereco { get => cidadeEndereco; set => cidadeEndereco = value; }
        [DataMember(IsRequired = true)]
        public string RuaEndereco { get => ruaEndereco; set => ruaEndereco = value; }
        [DataMember(IsRequired = true)]
        public string BairroEndereco { get => bairroEndereco; set => bairroEndereco = value; }
        [DataMember(IsRequired = true)]
        public string CepEndereco { get => cepEndereco; set => cepEndereco = value; }
    }
}
