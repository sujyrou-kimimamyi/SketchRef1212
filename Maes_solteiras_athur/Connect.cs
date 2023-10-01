using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maes_solteiras_athur
{
    internal class Connect

    {
        //Propriedades ou atributos
        private readonly SqlConnection connection;
        private readonly string DataBase = "sketchrefdbs";

        //Construtor
        public Connect()                            
        {
            
            string stringConnection = @"Data Source="
                    + Environment.MachineName +
                    @"\SQLEXPRESS;Initial Catalog=" +
                    DataBase + ";Integrated Security=true";

            connection = new SqlConnection(stringConnection);
            connection.Open(); 
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return connection;
        }

    }

}