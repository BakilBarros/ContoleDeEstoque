using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class NDestino : IGerenciadorDestino
    {
        public void cadastrarDestino(EntidadeDestino verDestino)
        {
            if (verDestino == null)
            {
                throw new Exception("Informar os dados do destino");
            }
                DDestino destino = new DDestino();
                destino.cadastrarDestino(verDestino);
    
        }

        public void deletarDestino(EntidadeDestino verDestino)
        {
            if (verDestino == null)
            {
                throw new Exception("Informar os dados do destino");
            }
            DDestino destino = new DDestino();
            destino.deletarDestino(verDestino);
        }

        public List<EntidadeDestino> listarTodosOsProdutos()
        {
            return new DDestino().listarTodosOsProdutos();
        }

        public bool verificarDuplicidadeDestino(EntidadeDestino verDestino)
        {
            return new DDestino().verificarDuplicidadeDestino(verDestino);
        }
    }
}
