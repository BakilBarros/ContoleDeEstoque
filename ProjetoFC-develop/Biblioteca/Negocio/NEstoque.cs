using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class NEstoque : IGerenciadorEstoque
    {
        public void alterarEstoque(EntidadeEstoque varEstoque)
        {
            throw new NotImplementedException();
        }

        public void cadastrarEstoque(EntidadeEstoque varEstoque)
        {
            if (varEstoque == null)
            {
                throw new Exception("Informar os dados do estoque");
            }
            DEstoque estoque = new DEstoque();
            estoque.cadastrarEstoque(varEstoque);

        }

        public int consultarQuantidadeDeUmProdutoNoEstoque(EntidadeProduto varProduto, EntidadeEstoque varEstoque)
        {
            throw new NotImplementedException();
        }

        public void inativarEstoque(EntidadeEstoque varEstoque)
        {
            if (varEstoque == null)
            {
                throw new Exception("Informar os dados do estoque");
            }
            DEstoque estoque = new DEstoque();
            estoque.inativarEstoque(varEstoque);
        }

        public List<EntidadeEstoque> listarTodosOsEstoques()
        {
            return new DEstoque().listarTodosOsEstoques();
        }

        public bool verificarDuplicidadeEstoque(EntidadeProduto varProduto)
        {
            return new DEstoque().verificarDuplicidadeEstoque(varProduto);
        }
    }
}
