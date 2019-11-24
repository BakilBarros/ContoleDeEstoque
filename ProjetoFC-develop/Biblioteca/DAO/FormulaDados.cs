using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.DAO
{
    public class FormulaDados : GerenciadorConexaoSqlServer, InterfaceFormula
    {
        public void CadastrarFormula(Produto produto)
        {
            try
            {
                foreach (MateriaPrima materiaPrima in produto.MateriaPrima)
                {
                this.Conectar();
                string sql = "insert into Compoe (ID_Produto, ID_MateriaPrima) ";
                sql += " values(@IdProduto, @IdMateriaPrima)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@IdProduto", SqlDbType.Int);
                cmd.Parameters["@IdProduto"].Value = produto.Id;

                cmd.Parameters.Add("@IdMateriaPrima", SqlDbType.Int);
                cmd.Parameters["@IdMateriaPrima"].Value = materiaPrima.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public void CadastrarItemFormula(MateriaPrima materiPrima)
        {
            try
            {
                this.Conectar();
                string sql = "insert into Compoe (ID_Produto, ID_MateriaPrima) ";
                sql += " values(@IdProduto, @IdMateriaPrima)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@IdProduto", SqlDbType.Int);
                cmd.Parameters["@IdProduto"].Value = materiPrima.Produto.First().Id;

                cmd.Parameters.Add("@IdMateriaPrima", SqlDbType.Int);
                cmd.Parameters["@IdMateriaPrima"].Value = materiPrima.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public void DeleteFormula(Produto produto)
        {
            try
            {
                this.Conectar();
                string sql = "delete from Compoe where ID_Produto = @ID_Produto ";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@ID_Produto", SqlDbType.Int);
                cmd.Parameters["@ID_Produto"].Value = produto.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public void DeleteItemFormula(MateriaPrima materiPrima)
        {
            try
            {
                this.Conectar();
                string sql = "delete from Compoe where ID_Produto = @ID_Produto ";
                sql += " and ID_MateriaPrima = @ID_MateriaPrima";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@ID_Produto", SqlDbType.Int);
                cmd.Parameters["@ID_Produto"].Value = materiPrima.Produto.First().Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = materiPrima.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public List<MateriaPrima> SelectFormula(Produto filtro)
        {
            List<MateriaPrima> retorno = new List<MateriaPrima>();
            try
            {
                this.Conectar();
                string sql = "SELECT MateriaPrima.Id AS IdMateriaPrima, MateriaPrima.Nome AS NomeMateriaPrima, ";
                sql += " Produto.Id AS IdProduto, Produto.Nome AS NomeProduto FROM Compoe ";
                sql += " INNER JOIN MateriaPrima ON Compoe.Id_MateriaPrima = MateriaPrima.Id ";
                sql += " INNER JOIN Produto ON Compoe.Id_Produto = Produto.Id ";
                sql += " where compoe.Id_Produto = compoe.Id_Produto";

                if (filtro.Id > 0)
                {
                    sql += " and compoe.Id_Produto = @Id_Produto ";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (filtro.Id > 0)
                {
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int);
                    cmd.Parameters["@Id_Produto"].Value = filtro.Id;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();
                
                while (DbReader.Read())
                {
                    MateriaPrima materiaPrima = new MateriaPrima();
                    materiaPrima.Produto = new List<Produto>();
                    Produto produto = new Produto();

                    materiaPrima.Id = DbReader.GetInt32(DbReader.GetOrdinal("IdMateriaPrima"));
                    materiaPrima.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeMateriaPrima"));
                    produto.Id = DbReader.GetInt32(DbReader.GetOrdinal("IdProduto"));
                    produto.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeProduto"));
                    materiaPrima.Produto.Add(produto);
                    retorno.Add(materiaPrima);
                }

                DbReader.Close();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }

        public bool VerificarDuplicidadeFormula(Produto produto)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT ID_Produto, ID_MateriaPrima ";
                sql += " FROM Compoe where ID_Produto = @ID_Produto ";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@ID_Produto", SqlDbType.Int);
                cmd.Parameters["@ID_Produto"].Value = produto.Id;

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }

                DbReader.Close();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }

        public bool VerificarDuplicidadeItemFormula(MateriaPrima materiaPrima)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT ID_Produto, ID_MateriaPrima ";
                sql += " FROM Compoe where ID_Produto = @ID_Produto ";
                sql += " and ID_MateriaPrima = @ID_MateriaPrima";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@ID_Produto", SqlDbType.Int);
                cmd.Parameters["@ID_Produto"].Value = materiaPrima.Produto.First().Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = materiaPrima.Id;

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }

                DbReader.Close();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }
    }
}
