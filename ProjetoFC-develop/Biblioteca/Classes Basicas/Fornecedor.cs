using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class Fornecedor
    {
        //Declaração dos atributos
        private int id;
        private string cnpj;
        private string cep;
        private string razaoSocial;
        private string logradouro;
        private string cidade;
        private string estado;
        private string bairro;
        private string email;
        private string telefone;
        private string complemento;
        private List<Compra> compra;

        public Fornecedor()
        {
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
        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }

            set
            {
                razaoSocial = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                logradouro = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        [DataMember(IsRequired = true)]
        public List<Compra> Compra
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

        [DataMember(IsRequired = true)]
        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }
    }
}
