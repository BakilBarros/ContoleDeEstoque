using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public interface InterfaceCompra
    {
        void Insert(Compra compra);
        void Update(Compra compra);
        void Delete(Compra compra);
        bool VerificarDuplicidade(Compra compra);
        List<Compra> Select(Compra compra);
     }
}
