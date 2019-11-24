using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public interface InterfaceFornecedor
    {
        void Insert(Fornecedor fornecedor);
        void Update(Fornecedor fornecedor);
        void Delete(Fornecedor fornecedor);
        bool VerificarDuplicidade(Fornecedor fornecedor);
        List<Fornecedor> Select(Fornecedor filtro);
    }
}
