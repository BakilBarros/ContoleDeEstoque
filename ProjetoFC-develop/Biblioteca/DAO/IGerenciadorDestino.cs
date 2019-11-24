using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public  interface IGerenciadorDestino
    {
        void cadastrarDestino (EntidadeDestino verDestino);
        List<EntidadeDestino> listarTodosOsProdutos();
        void deletarDestino(EntidadeDestino verDestino);
        bool verificarDuplicidadeDestino(EntidadeDestino verDestino);
    }
}
