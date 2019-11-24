using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;

namespace Biblioteca.Negocio
{
    public class ProdutoNegocio : InterfaceProduto
    {
        public void Insert(Produto produto)
        {
            if (produto == null)
            {
                throw new Exception("Informar os dados do produto");
            }

            if (produto.Nome == null)
            {
                throw new Exception("Informar o nome do produto");
            }

            if (produto.Nome.Length > 50)
            {
                throw new Exception("O nome do produto não pode ter mais de 50 caracteres");
            }

            if (produto.Nome.Trim().Equals("") == true)
            {
                throw new Exception("Informar o nome do produto");
            }

            if (produto.UnidadeFornecimento == null)
            {
                throw new Exception("Informar a unidade de fornecimento do produto");
            }

            if (produto.UnidadeFornecimento.Length > 10)
            {
                throw new Exception("A unidade de fornecimento do produto não pode ter mais de 10 caracteres");
            }

            if (produto.UnidadeFornecimento.Trim().Equals("") == true)
            {
                throw new Exception("Informar a unidade de fornecimento do produto");
            }

            if (produto.Descricao == null)
            {
                throw new Exception("Informar a descrição do produto");
            }

            if (produto.Descricao.Length > 300)
            {
                throw new Exception("A descrição do produto não pode ter mais de 300 caracteres");
            }

            if (produto.Descricao.Trim().Equals("") == true)
            {
                throw new Exception("Informar a descrição do produto");
            }

            ProdutoDados dados = new ProdutoDados();

            dados.Insert(produto);
        }

        public void Update(Produto produto)
        {
            if (produto == null)
            {
                throw new Exception("Informar os dados do produto");
            }

            if (produto.Id <= 0)
            {
                throw new Exception("O Id do produto não poderá ser menor ou igual a zero");
            }

            if (produto.Nome == null)
            {
                throw new Exception("Informar o nome do produto");
            }

            if (produto.Nome.Length > 50)
            {
                throw new Exception("O nome do produto não pode ter mais de 50 caracteres");
            }

            if (produto.Nome.Trim().Equals("") == true)
            {
                throw new Exception("Informar o nome do produto");
            }

            if (produto.UnidadeFornecimento == null)
            {
                throw new Exception("Informar a unidade de fornecimento do produto");
            }

            if (produto.UnidadeFornecimento.Length > 10)
            {
                throw new Exception("A unidade de fornecimento do produto não pode ter mais de 10 caracteres");
            }

            if (produto.UnidadeFornecimento.Trim().Equals("") == true)
            {
                throw new Exception("Informar a unidade de fornecimento do produto");
            }

            if (produto.Descricao == null)
            {
                throw new Exception("Informar a descrição do produto");
            }

            if (produto.Descricao.Length > 300)
            {
                throw new Exception("A descrição do produto não pode ter mais de 300 caracteres");
            }

            if (produto.Descricao.Trim().Equals("") == true)
            {
                throw new Exception("Informar a descrição do produto");
            }

            ProdutoDados dados = new ProdutoDados();

            if (this.VerificarDuplicidade(produto) == false)
            {
                throw new Exception("O produto não esta cadastrado");
            }

            dados.Update(produto);
        }

        public void Delete(Produto produto)
        {
            if (produto == null)
            {
                throw new Exception("Informar os dados do produto");
            }
            if (produto.Id <= 0)
            {
                throw new Exception("O Id do produto não poderá ser menor ou igual a zero");
            }
            ProdutoDados dados = new ProdutoDados();

            if (this.VerificarDuplicidade(produto) == false)
            {
                throw new Exception("O produto não esta cadastrado");
            }

            dados.Delete(produto);
        }

        public bool VerificarDuplicidade(Produto produto)
        {
            return new ProdutoDados().VerificarDuplicidade(produto);
        }

        public List<Produto> Select(Produto filtro)
        {
            return new ProdutoDados().Select(filtro);
        }
    }
}
