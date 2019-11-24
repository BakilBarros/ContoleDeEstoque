using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Util
{
    public class GerenciadorConexaoSqlServer
    {
        public SqlConnection sqlcon;
        private const string dataBase = "FabricaCosmeticos";
        private const string local = "localhost";
        private const string usuario = "aluno";
        private const string senha = "aluno";
        
            
        string strCon = @"Data Source="+local+";Initial Catalog="+dataBase+";UId="+usuario+";Password="+senha+";";


        public void Conectar()
        {
            this.sqlcon = new SqlConnection(strCon);
            this.sqlcon.Open();
        }

        public void Desconectar()
        {
            sqlcon.Close();
            sqlcon.Dispose();
        }
    }
}
