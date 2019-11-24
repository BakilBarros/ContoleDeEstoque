using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public interface IGerenciadorMovimentacao
    {


       void cadastrarEntrada(EntidadeEntrada varEntrada);
        void cadastrarSaida(EntidadeSaida varSaida);
        List<EntidadeEntrada> listarTodosAsEntradas();
        List<EntidadeSaida> listarTodosAsSaidas();
        List<EntidadeEntrada> consultarTodasAsEntradasDeUmProduto(EntidadeProduto varProduto, EntidadeEntrada varEntrada);
        List<EntidadeSaida> consultarTodasAsSaidasDeUmProduto(EntidadeProduto varProduto, EntidadeSaida varSaida);



    }
}
