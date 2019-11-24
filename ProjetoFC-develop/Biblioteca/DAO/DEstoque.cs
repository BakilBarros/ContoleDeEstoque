using Biblioteca.Classes_Basicas;
using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public class DEstoque : GerenciadorConexaoSqlServer, IGerenciadorEstoque
    {
        public void alterarEstoque(EntidadeEstoque varEstoque)
        {
            try
            {
                this.Conectar();
                string sql = "update ESTOQUE set nome_estoque = @nome_estoque  ";
                sql += " Where id_estoque = @id_estoque";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@id_estoque", SqlDbType.Int);
                cmd.Parameters["@id_estoque"].Value = varEstoque.IdEstoque;

                cmd.Parameters.Add("@nome_estoque", SqlDbType.VarChar);
                cmd.Parameters["@nome_estoque"].Value = varEstoque.NomeEstoque;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public void cadastrarEstoque(EntidadeEstoque varEstoque)
        {
            try
            {
                this.Conectar();
                string sql = "insert into ESTOQUE (nome_estoque,quantidade_estoque,status_estoque) ";
                sql += " values(@nome_estoque,@quantidade_estoque,@status_estoque)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@nome_estoque", SqlDbType.VarChar);
                cmd.Parameters["@nome_estoque"].Value = varEstoque.NomeEstoque;

                cmd.Parameters.Add("@quantidade_estoque", SqlDbType.VarChar);
                cmd.Parameters["@quantidade_estoque"].Value = varEstoque.QuantidadeEstoque;

                cmd.Parameters.Add("@status_estoque", SqlDbType.VarChar);
                cmd.Parameters["@status_estoque"].Value = varEstoque.StatusEstoque;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public int consultarQuantidadeDeUmProdutoNoEstoque(EntidadeProduto varProduto, EntidadeEstoque varEstoque)
        {
            throw new NotImplementedException();
        }

        public void inativarEstoque(EntidadeEstoque varEstoque)
        {
            try
            {
                this.Conectar();
                string sql = "update ESTOQUE set status_estoque = @status_estoque  ";
                sql += " Where id_estoque = @id_estoque";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@id_estoque", SqlDbType.Int);
                cmd.Parameters["@id_estoque"].Value = varEstoque.IdEstoque;

                cmd.Parameters.Add("@status_estoque", SqlDbType.VarChar);
                cmd.Parameters["@status_estoque"].Value = varEstoque.StatusEstoque;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public List<EntidadeEstoque> listarTodosOsEstoques()
        {
            List<EntidadeEstoque> retorno = new List<EntidadeEstoque>();
            try
            {

                this.Conectar();
                string sql = "select * from ESTOQUE";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    EntidadeEstoque estoque = new EntidadeEstoque();
                    estoque.IdEstoque = DbReader.GetInt32(DbReader.GetOrdinal("id_estoque"));
                    estoque.NomeEstoque = DbReader.GetString(DbReader.GetOrdinal("nome_estoque"));
                    estoque.QuantidadeEstoque = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_estoque"));
                    estoque.StatusEstoque = DbReader.GetString(DbReader.GetOrdinal("status_estoque"));
                    retorno.Add(estoque);
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

        public bool verificarDuplicidadeEstoque(EntidadeProduto varProduto)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT * from ESTOQUE where nome_estoque = @nome_estoque";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@nome_estoque", SqlDbType.VarChar);
                cmd.Parameters["@nome_estoque"].Value = varProduto.NomeProduto;

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

