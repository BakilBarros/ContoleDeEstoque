using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using Biblioteca.Util;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.DAO
{
    public class ProdutoDados : GerenciadorConexaoSqlServer, InterfaceProduto
    {   
        public void Insert(Produto produto)
        {
            try
            {
                this.Conectar();

                string sql = "insert into Produto (nome, unidadeFornecimento, descricao) ";
                sql += " values (@nome, @unidadeFornecimento, @descricao);";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = produto.Nome;

                cmd.Parameters.Add("@unidadeFornecimento", SqlDbType.VarChar);
                cmd.Parameters["@unidadeFornecimento"].Value = produto.UnidadeFornecimento;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = produto.Descricao;
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void Update(Produto produto)
        {
            try
            {
                this.Conectar();
                string sql = "update Produto set nome = @nome, unidadeFornecimento = @unidadeFornecimento, ";
                sql += " descricao = @descricao Where id = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = produto.Id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = produto.Nome;

                cmd.Parameters.Add("@unidadeFornecimento", SqlDbType.VarChar);
                cmd.Parameters["@unidadeFornecimento"].Value = produto.UnidadeFornecimento;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = produto.Descricao;
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public void Delete(Produto produto)
        {
            try
            {
                this.Conectar();
                string sql = "delete from Produto where id=@id";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = produto.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e remover " + ex.Message);
            }
        }

        public bool VerificarDuplicidade(Produto produto)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT id, nome, unidadeFornecimento, descricao ";
                sql += " FROM Produto where id = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = produto.Id;

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

        public List<Produto> Select(Produto filtro)
        {
            List<Produto> retorno = new List<Produto>();
            try
            {
                this.Conectar();
                string sql = "SELECT id, nome, unidadeFornecimento, descricao ";
                sql += " FROM Produto where id = id ";

                if (filtro.Id > 0)
                {
                    sql += " and id = @id ";
                }
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    sql += " and nome like @nome ";
                }

                
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (filtro.Id > 0)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters["@id"].Value = filtro.Id;
                }
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = "%" + filtro.Nome + "%";
                }
                
                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    produto.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    produto.UnidadeFornecimento = DbReader.GetString(DbReader.GetOrdinal("UnidadeFornecimento"));
                    produto.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
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
    }
}
