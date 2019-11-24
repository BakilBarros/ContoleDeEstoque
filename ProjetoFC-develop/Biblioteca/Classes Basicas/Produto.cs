using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class Produto
    {
        //Declaração dos atributos
        private int id;
        private string unidadeFornecimento;
        private List<MateriaPrima> materiaPrima;
        private string descricao;
        private string nome;

        public Produto()
        {
            List<MateriaPrima> materiaPrima = new List<MateriaPrima>();
        }

        //Métodos Gets e Sets
        [DataMember(IsRequired = true)]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string UnidadeFornecimento
        {
            get
            {
                return unidadeFornecimento;
            }

            set
            {
                unidadeFornecimento = value;
            }
        }

        [DataMember(IsRequired = true)]
        public List<MateriaPrima> MateriaPrima
        {
            get
            {
                return materiaPrima;
            }

            set
            {
                materiaPrima = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
