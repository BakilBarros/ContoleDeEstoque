using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class MateriaPrima
    {
        //Declaração dos atributos
        private int id;
        private DateTime validade;
        private string descricao;
        private string lote;
        private string nome;
        private int estoqueAtual;
        private List<Produto> produto;
        private List<Compra> compra;

        public MateriaPrima()
        {
            List<Produto> produto = new List<Produto>();
            List<Compra> compra = new List<Compra>();
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
        public DateTime Validade
        {
            get
            {
                return validade;
            }

            set
            {
                validade = value;
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
        public string Lote
        {
            get
            {
                return lote;
            }

            set
            {
                lote = value;
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

        [DataMember(IsRequired = true)]
        public int EstoqueAtual
        {
            get
            {
                return estoqueAtual;
            }

            set
            {
                estoqueAtual = value;
            }
        }

        [DataMember(IsRequired = true)]
        public List<Produto> Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        [DataMember(IsRequired = true)]
        internal List<Compra> Compra
        {
            get
            {
                return compra;
            }

            set
            {
                compra = value;
            }
        }

    }
}
