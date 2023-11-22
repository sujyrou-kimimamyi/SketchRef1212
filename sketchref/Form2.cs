using System; 
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

            UserDAO nobj = new UserDAO();
            nobj.DeleteUser(Id);
            
            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();
           

            UpdateListView();
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


            //sqlCommand.Parameters.AddWithValue("@ID", text4.Text);
            sqlCommand.Parameters.AddWithValue("@Name", text1.Text);
            sqlCommand.Parameters.AddWithValue("@Email", text2.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", text3.Text);
            sqlCommand.Parameters.AddWithValue("@Password", text4.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Dados atualizados.",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();
          

            UpdateListView();
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            text1.Text = listView1.Items[index].SubItems[1].Text;
            text2.Text = listView1.Items[index].SubItems[2].Text;
            text3.Text = listView1.Items[index].SubItems[3].Text;
            text4.Text = listView1.Items[index].SubItems[4].Text;
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

        private void lbl_edic_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User(text1.Text,
                   text2.Text,
                   text4.Text,
                   text3.Text);

            UserDAO insertuser = new UserDAO();
            insertuser.InsertUser(user);

            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();


            UpdateListView();
        }
    }
}
