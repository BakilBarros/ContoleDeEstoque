using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    interface InterfaceFormula
    {
        void CadastrarFormula(Produto produto);
        void CadastrarItemFormula(MateriaPrima materiaPrima);
        void DeleteFormula(Produto produto);
        void DeleteItemFormula(MateriaPrima materiaPrima);
        bool VerificarDuplicidadeFormula(Produto produto);
        bool VerificarDuplicidadeItemFormula(MateriaPrima materiaPrima);
        List<MateriaPrima> SelectFormula(Produto filtro);
    }
}
