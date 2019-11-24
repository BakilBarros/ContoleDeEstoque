using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    interface IGerenciadorProduto
    {
        void cadastrarProduto(EntidadeProduto varProduto);
        List<EntidadeProduto> listarTodosOsProdutos();
        void deletarProduto(EntidadeProduto varProduto);
        bool verificarDuplicidade(EntidadeProduto varProduto);
        void editarProduto(EntidadeProduto varProduto);
    }
}
