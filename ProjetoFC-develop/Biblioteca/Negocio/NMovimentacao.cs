using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class NMovimentacao : IGerenciadorMovimentacao
    {
        public void cadastrarEntrada(EntidadeEntrada varEntrada)
        {
            if (varEntrada == null)
            {
                throw new Exception("Informar os dados do Entrada");
            }
            DMovimentacao aux = new DMovimentacao();
            aux.cadastrarEntrada(varEntrada);
        }

        public void cadastrarSaida(EntidadeSaida varSaida)
        {
            if (varSaida == null)
            {
                throw new Exception("Informar os dados do Entrada");
            }
            DMovimentacao aux = new DMovimentacao();
            aux.cadastrarSaida(varSaida);
        }

        public List<EntidadeEntrada> consultarTodasAsEntradasDeUmProduto(EntidadeProduto varProduto, EntidadeEntrada varEntrada)
        {
            return new DMovimentacao().consultarTodasAsEntradasDeUmProduto(varProduto, varEntrada);
        }

        public List<EntidadeSaida> consultarTodasAsSaidasDeUmProduto(EntidadeProduto varProduto, EntidadeSaida varSaida)
        {
            return new DMovimentacao().consultarTodasAsSaidasDeUmProduto(varProduto, varSaida);
        }

        public List<EntidadeEntrada> listarTodosAsEntradas()
        {
            return new DMovimentacao().listarTodosAsEntradas();
        }

        public List<EntidadeSaida> listarTodosAsSaidas()
        {
            return new DMovimentacao().listarTodosAsSaidas();
        }
    }
}
