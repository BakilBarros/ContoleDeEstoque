using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using System.Data;
using Biblioteca.Util;

namespace Biblioteca.DAO
{
    public class CompraDados : GerenciadorConexaoSqlServer, InterfaceCompra
    {
        

        public void Insert(Compra compra)
        {
          try
            {
                this.Conectar();
                string sql = "insert into Compra (Preco,Quantidade,ID_Fornecedor,ID_MateriaPrima) ";
                sql += " values(@Preco,@Quantidade,@ID_Fornecedor,@ID_MateriaPrima)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@Preco", SqlDbType.Decimal);
                cmd.Parameters["@Preco"].Value = compra.Preco;

                cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar);
                cmd.Parameters["@Quantidade"].Value = compra.Quantidade;

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void Update(Compra compra)
        {
            try
            {
                this.Conectar();
                string sql = "update Compra set Preco = @Preco,Quantidade = @Quantidade  ";
                sql += " Where ID_Fornecedor = @ID_Fornecedor and ID_MateriaPrima = @ID_MateriaPrima";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@Preco", SqlDbType.Decimal);
                cmd.Parameters["@Preco"].Value = compra.Preco;

                cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar);
                cmd.Parameters["@Quantidade"].Value = compra.Quantidade;

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public void Delete(Compra compra)
        {
            try
            {
                this.Conectar();
                string sql = "delete from Compra where ID_Fornecedor = @ID_Fornecedor and ID_MateriaPrima = @ID_MateriaPrima";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.VarChar);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public bool VerificarDuplicidade(Compra compra)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT Preco,Quantidade,ID_Fornecedor,ID_MateriaPrima ";
                sql += " FROM Compra where ID_Fornecedor=@ID_Fornecedor ";
                sql += " and ID_MateriaPrima=@ID_MateriaPrima";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.VarChar);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;

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
        public List<Compra> Select(Compra filtro)
        {
            List<Compra> retorno = new List<Compra>();
            try
            {
                this.Conectar();
                string sql = "SELECT Compra.Quantidade, Compra.Preco, Compra.ID_Fornecedor, Compra.ID_MateriaPrima, ";
                sql += " MateriaPrima.Nome AS NomeMateriaPrima, Fornecedor.RazaoSocial AS RazaoSocialFornecedor FROM Compra ";
                sql += " inner join MateriaPrima on Compra.ID_MateriaPrima = MateriaPrima.ID ";
                sql += " inner join Fornecedor on Compra.ID_Fornecedor = Fornecedor.ID where Compra.ID_Fornecedor = Compra.ID_Fornecedor ";

                if (filtro.Fornecedor != null && filtro.Fornecedor.Id > 0)
                {
                    sql += " and compra.ID_Fornecedor = @IdFornecedor ";
                }

                if (filtro.MateriaPrima != null && filtro.MateriaPrima.Id > 0)
                {
                    sql += " and compra.ID_MateriaPrima = @IdMateriaPrima ";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (filtro.Fornecedor != null && filtro.Fornecedor.Id > 0)
                {
                    cmd.Parameters.Add("@IdFornecedor", SqlDbType.Int);
                    cmd.Parameters["@IdFornecedor"].Value = filtro.Fornecedor.Id;
                }

                if (filtro.MateriaPrima != null && filtro.MateriaPrima.Id > 0)
                {
                    cmd.Parameters.Add("@IdMateriaPrima", SqlDbType.Int);
                    cmd.Parameters["@IdMateriaPrima"].Value = filtro.MateriaPrima.Id;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Compra compra = new Compra();
                    compra.Fornecedor = new Fornecedor();
                    compra.MateriaPrima = new MateriaPrima();
                    compra.Quantidade = DbReader.GetInt32(DbReader.GetOrdinal("Quantidade"));
                    compra.Preco = Convert.ToDouble(DbReader.GetDecimal(DbReader.GetOrdinal("Preco")));
                    compra.Fornecedor.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID_Fornecedor"));
                    compra.Fornecedor.RazaoSocial = DbReader.GetString(DbReader.GetOrdinal("RazaoSocialFornecedor"));
                    compra.MateriaPrima.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID_MateriaPrima"));
                    compra.MateriaPrima.Nome = DbReader.GetString(DbReader.GetOrdinal("NomeMateriaPrima"));
                    retorno.Add(compra);
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
