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
    public class FornecedorDados : GerenciadorConexaoSqlServer, InterfaceFornecedor
    {

        public void Insert(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                string sql = "insert into Fornecedor(CNPJ,RazaoSocial,Email,CEP,Telefone,Estado,Cidade,Bairro,Logradouro,Complemento) ";
                sql += " values(@CNPJ,@RazaoSocial,@Email,@CEP,@Telefone,@Estado,@Cidade,@Bairro,@Logradouro,@Complemento)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar);
                cmd.Parameters["@CNPJ"].Value = fornecedor.Cnpj;

                cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar);
                cmd.Parameters["@RazaoSocial"].Value = fornecedor.RazaoSocial;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = fornecedor.Email;

                cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                cmd.Parameters["@CEP"].Value = fornecedor.Cep;

                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                cmd.Parameters["@Telefone"].Value = fornecedor.Telefone;

                cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
                cmd.Parameters["@Estado"].Value = fornecedor.Estado;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = fornecedor.Cidade;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = fornecedor.Bairro;

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = fornecedor.Logradouro;

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = fornecedor.Complemento;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void Update(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                string sql = "update Fornecedor set CNPJ = @CNPJ,RazaoSocial = @RazaoSocial,Email = @Email, ";
                sql += " CEP = @CEP,Telefone = @Telefone,Estado = @Estado,";
                sql += " Cidade = @Cidade,Bairro = @Bairro,Logradouro = @Logradouro,Complemento = @Complemento";
                sql += " Where ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = fornecedor.Id;

                cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar);
                cmd.Parameters["@CNPJ"].Value = fornecedor.Cnpj;

                cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar);
                cmd.Parameters["@RazaoSocial"].Value = fornecedor.RazaoSocial;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = fornecedor.Email;

                cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                cmd.Parameters["@CEP"].Value = fornecedor.Cep;

                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                cmd.Parameters["@Telefone"].Value = fornecedor.Telefone;

                cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
                cmd.Parameters["@Estado"].Value = fornecedor.Estado;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = fornecedor.Cidade;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = fornecedor.Bairro;

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = fornecedor.Logradouro;

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = fornecedor.Complemento;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        
        public void Delete(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                string sql = "delete from Fornecedor where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = fornecedor.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e remover " + ex.Message);
            }
        }

        public bool VerificarDuplicidade(Fornecedor fornecedor)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT ID,CNPJ,RazaoSocial,Email,CEP,Telefone,";
                sql += " Estado,Cidade,Bairro,Logradouro,Complemento FROM Fornecedor where ";
                                               
                if (fornecedor.Id != 0)
                {
                    sql += " ID = @ID ";
                }
                else 
                {
                    sql += " CNPJ = @CNPJ";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = fornecedor.Id;

                cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar);
                cmd.Parameters["@CNPJ"].Value = fornecedor.Cnpj;

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

        public List<Fornecedor> Select(Fornecedor filtro)
        {
            List<Fornecedor> retorno = new List<Fornecedor>();
            try
            {
                this.Conectar();
                string sql = "SELECT ID,CNPJ,RazaoSocial,Email,CEP,Telefone,";
                sql += " Estado,Cidade,Bairro,Logradouro,Complemento ";
                sql +=" FROM Fornecedor where id = id";

                if (filtro.Cnpj != null && filtro.Cnpj.Trim().Equals("") == false)
                {
                    sql += " and CNPJ = @CNPJ ";
                }
                if (filtro.RazaoSocial != null && filtro.RazaoSocial.Trim().Equals("") == false)
                {
                    sql += " and RazaoSocial like @RazaoSocial";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (filtro.Cnpj != null && filtro.Cnpj.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar);
                    cmd.Parameters["@CNPJ"].Value = filtro.Cnpj;
                }
                if (filtro.RazaoSocial != null && filtro.RazaoSocial.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar);
                    cmd.Parameters["@RazaoSocial"].Value = "%"+filtro.RazaoSocial+"%";
                }
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Id = DbReader.GetInt32(DbReader.GetOrdinal("Id"));
                    fornecedor.Cnpj= DbReader.GetString(DbReader.GetOrdinal("CNPJ"));
                    fornecedor.RazaoSocial= DbReader.GetString(DbReader.GetOrdinal("RazaoSocial"));
                    fornecedor.Logradouro = DbReader.GetString(DbReader.GetOrdinal("Logradouro"));
                    fornecedor.Complemento= DbReader.GetString(DbReader.GetOrdinal("Complemento"));
                    fornecedor.Bairro= DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    fornecedor.Cidade= DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    fornecedor.Estado= DbReader.GetString(DbReader.GetOrdinal("Estado"));
                    fornecedor.Cep= DbReader.GetString(DbReader.GetOrdinal("CEP"));
                    fornecedor.Email= DbReader.GetString(DbReader.GetOrdinal("Email"));
                    fornecedor.Telefone= DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    retorno.Add(fornecedor);
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
