using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sketchref
{
    public partial class Form2 : Form
    {
        private int Id;
        public Form2()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();
            Connect connection = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = connection.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM [dbo].[User1]";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string Name = (string)dr["Name"];
                    string Email = (string)dr["Email"];
                    string Phone = (string)dr["Phone"];
                    string Password = (string)dr["Password"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(Name);
                    lv.SubItems.Add(Email);
                    lv.SubItems.Add(Phone);
                    lv.SubItems.Add(Password);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM [dbo].[User1] WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                UpdateListView();
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

        private void btn1_Click(object sender, EventArgs e)
        {

            Connect connection = new Connect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE [dbo].[User1] SET 
                 Name       = @Name, 
                 Email      = @Email,
                 Phone   = @Phone, 
                 Password      = @Password
                 WHERE ID   = @ID";

            sqlCommand.Parameters.AddWithValue("@Name", text1.Text);
            sqlCommand.Parameters.AddWithValue("@Email", text2.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", text3.Text);
           
            sqlCommand.Parameters.AddWithValue("@Password", text4.Text);
            sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Dados atualizados.",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();
            txtID.Clear();

            UpdateListView();
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txtID.Text = listView1.Items[index].SubItems[0].Text;
            text1.Text = listView1.Items[index].SubItems[1].Text;
            text2.Text = listView1.Items[index].SubItems[2].Text;
            text3.Text = listView1.Items[index].SubItems[3].Text;
            text4.Text = listView1.Items[index].SubItems[5].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
