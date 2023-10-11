using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sketchref
{
    internal class UserDAO
    {

        public void DeleteUser(int Id)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM [dbo].[User1] WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                //UpdateListView();
                MessageBox.Show("Dados excluídos.",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                throw new Exception("Não foi possível excluir os dados..\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public void InsertUser(User usobj)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO [dbo].[User1] VALUES(@Name,@Email,@Phone,@Password)";
            sqlCommand.Parameters.AddWithValue("@Name", usobj.Name);
            sqlCommand.Parameters.AddWithValue("@Email", usobj.Email);
            sqlCommand.Parameters.AddWithValue("@Phone", usobj.Phone);
            sqlCommand.Parameters.AddWithValue("@Password", usobj.Password);
            sqlCommand.ExecuteNonQuery();

        }

    }
}
