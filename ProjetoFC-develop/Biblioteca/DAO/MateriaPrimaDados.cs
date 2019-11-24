using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using System.Data;

namespace Biblioteca.DAO
{
    public class MateriaPrimaDados : GerenciadorConexaoSqlServer, InterfaceMateriaPrima
    {
        public void Insert(MateriaPrima materiaprima)
        {
            try
            {
                this.Conectar();
                string sql = "insert into MateriaPrima (Validade, EstoqueAtual, Lote, Nome, Descricao) ";
                sql += " values(@Validade, @EstoqueAtual, @Lote, @Nome, @Descricao)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@Validade", SqlDbType.Date);
                cmd.Parameters["@Validade"].Value = materiaprima.Validade;

                cmd.Parameters.Add("@EstoqueAtual", SqlDbType.Int);
                cmd.Parameters["@EstoqueAtual"].Value = materiaprima.EstoqueAtual;

                cmd.Parameters.Add("@Lote", SqlDbType.VarChar);
                cmd.Parameters["@Lote"].Value = materiaprima.Lote;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = materiaprima.Nome;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = materiaprima.Descricao;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }
    

    public void Update(MateriaPrima materiaprima)
    {
        try
        {
            this.Conectar();
            string sql = "update MateriaPrima set Validade=@Validade, EstoqueAtual=@EstoqueAtual, Lote=@Lote, ";
            sql += " Nome=@nome, Descricao=@Descricao where ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = materiaprima.Id;

            cmd.Parameters.Add("@Validade", SqlDbType.VarChar);
            cmd.Parameters["@Validade"].Value = materiaprima.Validade;

            cmd.Parameters.Add("@EstoqueAtual", SqlDbType.VarChar);
            cmd.Parameters["@EstoqueAtual"].Value = materiaprima.EstoqueAtual;

            cmd.Parameters.Add("@Lote", SqlDbType.VarChar);
            cmd.Parameters["@Lote"].Value = materiaprima.Lote;

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
            cmd.Parameters["@Nome"].Value = materiaprima.Nome;

            cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
            cmd.Parameters["@Descricao"].Value = materiaprima.Descricao;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            this.Desconectar();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao conectar e inserir " + ex.Message);
        }
    }



    

    public void Delete(MateriaPrima materiaprima)
        {
            try
            {
                this.Conectar();
                string sql = "delete from MateriaPrima where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = materiaprima.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e remover " + ex.Message);
            }
        }     


        public bool VerificarDuplicidade(MateriaPrima materiaprima)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT ID ,Validade, EstoqueAtual, Lote, Nome, Descricao ";
                sql += " FROM MateriaPrima where ";

                if (materiaprima.Id != 0)
                {
                    sql += " ID = @ID ";
                }
                else
                {
                    sql += " Nome = @Nome";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (materiaprima.Id != 0)
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int);
                    cmd.Parameters["@ID"].Value = materiaprima.Id;
                }
                else
                {
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@Nome"].Value = materiaprima.Nome;
                }

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

        public List<MateriaPrima> Select(MateriaPrima filtro)
        {
            List<MateriaPrima> retorno = new List<MateriaPrima>();
            try
            {
                this.Conectar();
                string sql = "SELECT ID ,Validade, EstoqueAtual, Lote, Nome, Descricao ";
                sql += " FROM MateriaPrima where ID = ID ";

                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    sql += " and Nome like @Nome ";
                }
                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    sql += " and Descricao like @Descricao ";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                    cmd.Parameters["@Nome"].Value = "%" + filtro.Nome + "%";
                }
                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                    cmd.Parameters["@Descricao"].Value = "%"+filtro.Descricao+"%";
                }
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    MateriaPrima materiaprima = new MateriaPrima();
                    materiaprima.Id = DbReader.GetInt32(DbReader.GetOrdinal("Id"));
                    materiaprima.Validade = DbReader.GetDateTime(DbReader.GetOrdinal("Validade"));
                    materiaprima.EstoqueAtual = DbReader.GetInt32(DbReader.GetOrdinal("EstoqueAtual"));
                    materiaprima.Lote = DbReader.GetString(DbReader.GetOrdinal("lote"));
                    materiaprima.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    materiaprima.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    retorno.Add(materiaprima);
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

