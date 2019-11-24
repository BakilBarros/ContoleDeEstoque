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
    public class DProduto : GerenciadorConexaoSqlServer, IGerenciadorProduto
    {
        public void cadastrarProduto(EntidadeProduto varProduto)
        {
            try
            {
                this.Conectar();
                string sql = "insert into PRODUTO (nome_produto, descricao_produto, tipo_produto, preco_produto) ";
                sql += " values(@nome_produto, @descricao_produto, @tipo_produto, @preco_produto)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@nome_produto", SqlDbType.VarChar);
                cmd.Parameters["@nome_produto"].Value = varProduto.NomeProduto;

                cmd.Parameters.Add("@descricao_produto", SqlDbType.VarChar);
                cmd.Parameters["@descricao_produto"].Value = varProduto.DescricaoProduto;

                cmd.Parameters.Add("@tipo_produto", SqlDbType.VarChar);
                cmd.Parameters["@tipo_produto"].Value = varProduto.TipoProduto;

                cmd.Parameters.Add("@preco_produto", SqlDbType.Float);
                cmd.Parameters["@preco_produto"].Value = varProduto.PrecoProduto;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void deletarProduto(EntidadeProduto varProduto)
        {
            try
            {
                this.Conectar();
                string sql = "delete from PRODUTO where id_produto = @id_produto";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@id_produto", SqlDbType.Int);
                cmd.Parameters["@id_produto"].Value = varProduto.IdProduto;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public void editarProduto(EntidadeProduto varProduto)
        {
            try
            {
                this.Conectar();
                string sql = "update PRODUTO set nome_produto = @nome_produto, descricao_produto = @descricao_produto, tipo_produto = @tipo_produto, preco_produto = @preco_produto";
                sql += " Where id_produto = @id_produto";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@id_produto", SqlDbType.Int);
                cmd.Parameters["@id_produto"].Value = varProduto.IdProduto;

                cmd.Parameters.Add("@nome_produto", SqlDbType.VarChar);
                cmd.Parameters["@nome_produto"].Value = varProduto.NomeProduto;

                cmd.Parameters.Add("@descricao_produto", SqlDbType.VarChar);
                cmd.Parameters["@descricao_produto"].Value = varProduto.DescricaoProduto;

                cmd.Parameters.Add("@tipo_produto", SqlDbType.VarChar);
                cmd.Parameters["@tipo_produto"].Value = varProduto.TipoProduto;

                cmd.Parameters.Add("@preco_produto", SqlDbType.Float);
                cmd.Parameters["@preco_produto"].Value = varProduto.PrecoProduto;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public List<EntidadeProduto> listarTodosOsProdutos()
        {
            List<EntidadeProduto> retorno = new List<EntidadeProduto>();
            try
            {

                this.Conectar();
                string sql = "select * from produto";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    EntidadeProduto produto = new EntidadeProduto();
                    produto.IdProduto = DbReader.GetInt32(DbReader.GetOrdinal("id_produto"));
                    produto.NomeProduto = DbReader.GetString(DbReader.GetOrdinal("nome_produto"));
                    produto.DescricaoProduto = DbReader.GetString(DbReader.GetOrdinal("descricao_produto"));
                    produto.PrecoProduto = DbReader.GetDouble(DbReader.GetOrdinal("preco_produto"));
                    produto.TipoProduto = DbReader.GetString(DbReader.GetOrdinal("tipo_produto"));
                    retorno.Add(produto);
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

        public bool verificarDuplicidade(EntidadeProduto varProduto)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT * from PRODUTO where nome_produto = @nome_produto";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@nome_produto", SqlDbType.VarChar);
                cmd.Parameters["@nome_produto"].Value = varProduto.NomeProduto;

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
