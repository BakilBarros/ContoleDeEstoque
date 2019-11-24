using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class Compra
    {
        //Declaração dos atributos
        private double preco;
        private int quantidade;
        private Fornecedor fornecedor;
        private MateriaPrima materiaPrima;

        public Compra()
        {
            Fornecedor fornecedor = new Fornecedor();
            MateriaPrima materiaPrima = new MateriaPrima();
        }

        //Métodos Gets e Sets
        [DataMember(IsRequired = true)]
        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        [DataMember(IsRequired = true)]
        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        [DataMember(IsRequired = true)]
        public Fornecedor Fornecedor
        {
            get
            {
                return fornecedor;
            }

            set
            {
                fornecedor = value;
            }
        }

        [DataMember(IsRequired = true)]
        public MateriaPrima MateriaPrima
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
        
    }
}
