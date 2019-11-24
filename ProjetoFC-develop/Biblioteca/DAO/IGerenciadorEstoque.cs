using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public interface IGerenciadorEstoque
    {
        void cadastrarEstoque(EntidadeEstoque varEstoque);
        void inativarEstoque(EntidadeEstoque varEstoque);
        List<EntidadeEstoque> listarTodosOsEstoques();
        void alterarEstoque(EntidadeEstoque varEstoque);
        bool verificarDuplicidadeEstoque(EntidadeProduto varProduto);
        int consultarQuantidadeDeUmProdutoNoEstoque(EntidadeProduto varProduto, EntidadeEstoque varEstoque);
        
    }
}
