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
    public class DMovimentacao : GerenciadorConexaoSqlServer, IGerenciadorMovimentacao
    {
        public void cadastrarEntrada(EntidadeEntrada varEntrada)
        {
            try
            {
                this.Conectar();
                string sql = "insert into ENTRADA (lote_entrada,quantidade_entrada,valor_total_entrda,data_entrada,validade_entrada,id_estoque,id_produto) ";
                sql += " values(@lote_entrada,@quantidade_entrada,@valor_total_entrda,@data_entrada,@validade_entrada,@id_estoque,@id_produto)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@lote_entrada", SqlDbType.VarChar);
                cmd.Parameters["@lote_entrada"].Value = varEntrada.LoteEntrada;

                cmd.Parameters.Add("@quantidade_entrada", SqlDbType.Int);
                cmd.Parameters["@quantidade_entrada"].Value = varEntrada.QuantidadeEntrada;

                cmd.Parameters.Add("@valor_total_entrda", SqlDbType.Float);
                cmd.Parameters["@valor_total_entrda"].Value = varEntrada.ValorTotalEntrada;

                cmd.Parameters.Add("@data_entrada", SqlDbType.VarChar);
                cmd.Parameters["@data_entrada"].Value = varEntrada.DataEntrada;

                cmd.Parameters.Add("@validade_entrada", SqlDbType.VarChar);
                cmd.Parameters["@validade_entrada"].Value = varEntrada.ValidadeEntrada;

                cmd.Parameters.Add("@id_estoque", SqlDbType.Int);
                cmd.Parameters["@id_estoque"].Value = varEntrada.IdEstoqueEntrada.IdEstoque;

                cmd.Parameters.Add("@id_produto", SqlDbType.Int);
                cmd.Parameters["@id_produto"].Value = varEntrada.IdProdutoEntrada.IdProduto;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void cadastrarSaida(EntidadeSaida varSaida)
        {
            try
            {
                this.Conectar();
                string sql = "insert into SAIDA (data_saida, quantidade_saida, valor_total_saida, id_estoque,id_produto,id_destino) ";
                sql += " values(@data_saida, @quantidade_saida, @valor_total_saida, @id_estoque,@id_produto,@id_destino)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@data_saida", SqlDbType.VarChar);
                cmd.Parameters["@data_saida"].Value = varSaida.DataSaida;

                cmd.Parameters.Add("@quantidade_saida", SqlDbType.Int);
                cmd.Parameters["@quantidade_saida"].Value = varSaida.QuantidadeSaida;

                cmd.Parameters.Add("@valor_total_saida", SqlDbType.Float);
                cmd.Parameters["@valor_total_saida"].Value = varSaida.ValorTatalSaida;

                cmd.Parameters.Add("@id_estoque", SqlDbType.Int);
                cmd.Parameters["@id_estoque"].Value = varSaida.IdEstoqueSaida.IdEstoque;

                cmd.Parameters.Add("@id_produto", SqlDbType.Int);
                cmd.Parameters["@id_produto"].Value = varSaida.IdProdutoSaida.IdProduto;

                cmd.Parameters.Add("@id_destino", SqlDbType.Int);
                cmd.Parameters["@id_destino"].Value = varSaida.IdDestinoSaida.IdDestino;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public List<EntidadeEntrada> consultarTodasAsEntradasDeUmProduto(EntidadeProduto varProduto, EntidadeEntrada varEntrada)
        {
            
            List<EntidadeEntrada> retorno = new List<EntidadeEntrada>();
            try
            {

                this.Conectar();
                string sql = "select * from ENTRADA as e join PRODUTO as p on e.id_produto = p.id_produto where e.id_produto = @id_produto";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();

                cmd.Parameters.Add("@id_produto", SqlDbType.Int);
                cmd.Parameters["@id_produto"].Value = varProduto.IdProduto;

                while (DbReader.Read())
                {
                    EntidadeEntrada entrada = new EntidadeEntrada();
                    
                    entrada.IdEntrada = DbReader.GetInt32(DbReader.GetOrdinal("id_entrada"));
                    entrada.LoteEntrada = DbReader.GetString(DbReader.GetOrdinal("lote_entrada"));
                    entrada.QuantidadeEntrada = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_entrada"));
                    entrada.ValorTotalEntrada = DbReader.GetDouble(DbReader.GetOrdinal("valor_total_entrda"));
                    entrada.DataEntrada = DbReader.GetString(DbReader.GetOrdinal("data_entrada"));
                    entrada.ValidadeEntrada = DbReader.GetString(DbReader.GetOrdinal("validade_entrada"));
                   entrada.IdEstoqueEntrada.IdEstoque = DbReader.GetInt32(DbReader.GetOrdinal("id_estoque"));
                    entrada.IdProdutoEntrada.IdProduto = DbReader.GetInt32(DbReader.GetOrdinal("id_produto"));
                    
                    retorno.Add(entrada);
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

        public List<EntidadeSaida> consultarTodasAsSaidasDeUmProduto(EntidadeProduto varProduto, EntidadeSaida varSaida)
        {

            List<EntidadeSaida> retorno = new List<EntidadeSaida>();
            try
            {

                this.Conectar();
                string sql = "select * from SAIDA as e join PRODUTO as p on e.id_produto = p.id_produto where e.id_produto = @id_produto";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();

                cmd.Parameters.Add("@id_produto", SqlDbType.Int);
                cmd.Parameters["@id_produto"].Value = varProduto.IdProduto;

                while (DbReader.Read())
                {
                    EntidadeSaida saida = new EntidadeSaida();

                    saida.IdSaida = DbReader.GetInt32(DbReader.GetOrdinal("id_saida"));
                    saida.DataSaida = DbReader.GetString(DbReader.GetOrdinal("data_saida"));
                    saida.QuantidadeSaida = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_saida"));
                    saida.ValorTatalSaida = DbReader.GetDouble(DbReader.GetOrdinal("valor_total_saida"));
                    saida.IdEstoqueSaida.IdEstoque = DbReader.GetInt32(DbReader.GetOrdinal("id_estoque"));
                    saida.IdProdutoSaida.IdProduto = DbReader.GetInt32(DbReader.GetOrdinal("id_produto"));
                    saida.IdDestinoSaida.IdDestino = DbReader.GetInt32(DbReader.GetOrdinal("id_destino"));
                    retorno.Add(saida);
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

        public List<EntidadeEntrada> listarTodosAsEntradas()
        {
            List<EntidadeEntrada> retorno = new List<EntidadeEntrada>();
            try
            {

                this.Conectar();
                string sql = "select * from ENTRADA";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    EntidadeEntrada entrada = new EntidadeEntrada();

                    entrada.IdEntrada = DbReader.GetInt32(DbReader.GetOrdinal("id_entrada"));
                    entrada.LoteEntrada = DbReader.GetString(DbReader.GetOrdinal("lote_entrada"));
                    entrada.QuantidadeEntrada = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_entrada"));
                    entrada.ValorTotalEntrada = DbReader.GetDouble(DbReader.GetOrdinal("valor_total_entrda"));
                    entrada.DataEntrada = DbReader.GetString(DbReader.GetOrdinal("data_entrada"));
                    entrada.ValidadeEntrada = DbReader.GetString(DbReader.GetOrdinal("validade_entrada"));
                    entrada.IdEstoqueEntrada.IdEstoque = DbReader.GetInt32(DbReader.GetOrdinal("id_estoque"));
                    entrada.IdProdutoEntrada.IdProduto = DbReader.GetInt32(DbReader.GetOrdinal("id_produto"));

                    retorno.Add(entrada);
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

        public List<EntidadeSaida> listarTodosAsSaidas()
        {
            List<EntidadeSaida> retorno = new List<EntidadeSaida>();
            try
            {

                this.Conectar();
                string sql = "select * from SAIDA ";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader DbReader = cmd.ExecuteReader();

           

                while (DbReader.Read())
                {
                    EntidadeSaida saida = new EntidadeSaida();

                    saida.IdSaida = DbReader.GetInt32(DbReader.GetOrdinal("id_saida"));
                    saida.DataSaida = DbReader.GetString(DbReader.GetOrdinal("data_saida"));
                    saida.QuantidadeSaida = DbReader.GetInt32(DbReader.GetOrdinal("quantidade_saida"));
                    saida.ValorTatalSaida = DbReader.GetDouble(DbReader.GetOrdinal("valor_total_saida"));
                    saida.IdEstoqueSaida.IdEstoque = DbReader.GetInt32(DbReader.GetOrdinal("id_estoque"));
                    saida.IdProdutoSaida.IdProduto = DbReader.GetInt32(DbReader.GetOrdinal("id_produto"));
                    saida.IdDestinoSaida.IdDestino = DbReader.GetInt32(DbReader.GetOrdinal("id_destino"));
                    retorno.Add(saida);
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
