using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class MateriaPrimaNegocio

    {
        private InterfaceMateriaPrima dados;

        public MateriaPrimaNegocio()
        {
            Dados = new MateriaPrimaDados();
        }

        public InterfaceMateriaPrima Dados
        {
            get
            {
                return dados;
            }

            set
            {
                dados = value;
            }
        }

        public void Delete(MateriaPrima materiaprima)
        {
            ValidarMateriaPrimaId(materiaprima);

            if (this.VerificarDuplicidade(materiaprima) == false)
            {
                throw new Exception("A materia prima não esta cadastrado");
            }

            this.Dados.Delete(materiaprima);
        }

        public void Insert(MateriaPrima materiaprima)
        {
            ValidarMateriaPrima(materiaprima);

            if (this.VerificarDuplicidade(materiaprima) == true)
            {
                throw new Exception("a materia já se encontra cadastrada");
            }

            this.Dados.Insert(materiaprima);
        }

        public List<MateriaPrima> Select(MateriaPrima filtro)
        {
            return this.Dados.Select(filtro);
        }

        public void Update(MateriaPrima materiaprima)
        {
            ValidarMateriaPrima(materiaprima);

            if (this.VerificarDuplicidade(materiaprima) == false)
            {
                throw new Exception("a materia prima não esta cadastrada");
            }

            this.Dados.Update(materiaprima);
        }

        public bool VerificarDuplicidade(MateriaPrima materiaprima)
        {
            return this.dados.VerificarDuplicidade(materiaprima);
        }

        public void ValidarMateriaPrimaId(MateriaPrima materiaprima)
        {
            if (materiaprima == null)
            {
                throw new Exception("Informar os dados do fornecedor");
            }
            if (materiaprima.Id <= 0)
            {
                throw new Exception("O Id da Materia não poderá ser menor ou igual a zero");
            }
        }

        public void ValidarMateriaPrima(MateriaPrima materiaprima)
        {
            if (materiaprima == null)
            {
                throw new Exception("Informar os dados da materia prima");
            }

            ValidarNome(materiaprima);

            ValidarDescricao(materiaprima);

            ValidarLote(materiaprima);

            ValidarValidade(materiaprima);

            ValidarEstoqueAtual(materiaprima);
        }

        public void ValidarNome(MateriaPrima materiaprima)
        {
            if (materiaprima.Nome == null)
            {
                throw new Exception("Informar o Nome da materia prima");
            }

            if (materiaprima.Nome.Length > 20)
            {
                throw new Exception("O nome da materia prima não pode ter mais de 20 caracteres");
            }

            if (materiaprima.Nome.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Nome da Materia prima");
            }
        }

        public void ValidarDescricao(MateriaPrima materiaprima)
        {
            if (materiaprima.Descricao == null)
            {
                throw new Exception("Informar a descrição da materia prima");
            }

            if (materiaprima.Descricao.Trim().Equals("") == true)
            {
                throw new Exception("Informar a descricao da materia prima");
            }

            if (materiaprima.Descricao.Length > 50)
            {
                throw new Exception("A descricao da materia prima não pode ter mais de 50 caracteres");
            }
        }

        public void ValidarLote(MateriaPrima materiaprima)
        {
            if (materiaprima.Lote == null)
            {
                throw new Exception("Informar o lote da materia prima");
            }

            if (materiaprima.Lote.Trim().Equals("") == true)
            {
                throw new Exception("Informar o lote da materia prima");
            }

            if (materiaprima.Lote.Length > 10)
            {
                throw new Exception("O lote da materia prima não pode ter mais de 10 caracteres");
            }
        }

        public void ValidarValidade(MateriaPrima materiaprima)
        {
            if (materiaprima.Validade == null)
            {
                throw new Exception("Informar a validade da materia prima");
            }

            if (materiaprima.Validade < DateTime.Now)
            {
                throw new Exception("Data da validade da materia prima não pode ser anterior ao agora");
            }
        }

        public void ValidarEstoqueAtual(MateriaPrima materiaprima)
        {
            if (materiaprima.EstoqueAtual == 0)
            {
                throw new Exception("Informar o estoque atual");
            }
        }
    }
}
