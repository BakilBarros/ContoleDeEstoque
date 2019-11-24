using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public interface InterfaceProduto
    {
        void Insert(Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
        bool VerificarDuplicidade(Produto produto);
        List<Produto> Select(Produto filtro);
    }
}
