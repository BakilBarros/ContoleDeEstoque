using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public interface InterfaceMateriaPrima
    {
        void Insert(MateriaPrima materiaprima);
        void Update(MateriaPrima materiaprima);
        void Delete(MateriaPrima materiaprima);
        bool VerificarDuplicidade(MateriaPrima materiaprima);
        List<MateriaPrima> Select(MateriaPrima filtro);
    }
}
