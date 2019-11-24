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
    public class DDestino : GerenciadorConexaoSqlServer, IGerenciadorDestino
    {
        public void cadastrarDestino(EntidadeDestino verDestino)
        {
            try
            {
                this.Conectar();
                string sql = "insert into DESTINO (cidade_endereco,rua_endereco,bairro_endereco,estado_endereco,cep_endereco) ";
                sql += " values(@cidade_endereco,@rua_endereco,@bairro_endereco,@estado_endereco,@cep_endereco)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@cidade_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cidade_endereco"].Value = verDestino.CidadeEndereco;

                cmd.Parameters.Add("@rua_endereco", SqlDbType.VarChar);
                cmd.Parameters["@rua_endereco"].Value = verDestino.RuaEndereco;

                cmd.Parameters.Add("@bairro_endereco", SqlDbType.VarChar);
                cmd.Parameters["@bairro_endereco"].Value = verDestino.BairroEndereco;

                cmd.Parameters.Add("@estado_endereco", SqlDbType.VarChar);
                cmd.Parameters["@estado_endereco"].Value = verDestino.EstadoEndereco;

                cmd.Parameters.Add("@cep_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cep_endereco"].Value = verDestino.CepEndereco;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void deletarDestino(EntidadeDestino verDestino)
        {
            try
            {
                this.Conectar();
                string sql = "delete from DESTINO where cep_endereco = @cep_endereco";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@cep_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cep_endereco"].Value = verDestino.CepEndereco;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public List<EntidadeDestino> listarTodosOsProdutos()
        {
            List<EntidadeDestino> retorno = new List<EntidadeDestino>();
            try
            {

                this.Conectar();
                string sql = "select * from destino";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    EntidadeDestino destino = new EntidadeDestino();
                    destino.IdDestino = DbReader.GetInt32(DbReader.GetOrdinal("id_destino"));
                    destino.RuaEndereco = DbReader.GetString(DbReader.GetOrdinal("rua_endereco"));
                    destino.EstadoEndereco = DbReader.GetString(DbReader.GetOrdinal("estado_endereco"));
                    destino.CidadeEndereco = DbReader.GetString(DbReader.GetOrdinal("cidade_endereco"));
                    destino.CepEndereco = DbReader.GetString(DbReader.GetOrdinal("cep_endereco"));
                    destino.CidadeEndereco = DbReader.GetString(DbReader.GetOrdinal("cidade_endereco"));
                    destino.BairroEndereco = DbReader.GetString(DbReader.GetOrdinal("beirro_endereco"));
                    retorno.Add(destino);
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

        public bool verificarDuplicidadeDestino(EntidadeDestino verDestino)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT * from DESTINO where cep_endereco = @cep_endereco";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@cep_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cep_endereco"].Value = verDestino.CepEndereco;

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
