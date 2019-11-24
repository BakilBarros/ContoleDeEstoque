using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class NProduto : IGerenciadorProduto
    {
        public void cadastrarProduto(EntidadeProduto varProduto)
        {
            if (varProduto == null)
            {
                throw new Exception("Informar os dados do produto");
            }
            DProduto aux = new DProduto();
            aux.cadastrarProduto(varProduto);
            
        }

        public void deletarProduto(EntidadeProduto varProduto)
        {
            if (varProduto == null)
            {
                throw new Exception("Informar os dados do produto");
            }
            DProduto aux = new DProduto();
            aux.deletarProduto(varProduto);
        }

        public void editarProduto(EntidadeProduto varProduto)
        {
            if (varProduto == null)
            {
                throw new Exception("Informar os dados do produto");
            }
            DProduto aux = new DProduto();
            aux.editarProduto(varProduto);
            
        }

        public List<EntidadeProduto> listarTodosOsProdutos()
        {
            return new DProduto().listarTodosOsProdutos();
        }

        public bool verificarDuplicidade(EntidadeProduto varProduto)
        {
            return new DProduto().verificarDuplicidade(varProduto);
        }
    }
}
