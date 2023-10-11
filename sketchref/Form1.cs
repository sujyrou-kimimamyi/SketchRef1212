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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace sketchref
{
    public partial class Form1 : Form
    {
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM [dbo].[User1]";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string Nome = (string)dr["Name"];
                    string Email = (string)dr["Email"];
                    string tel = (string)dr["Phone"];
                    string senha = (string)dr["Password"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(Nome);
                    lv.SubItems.Add(Email);
                    lv.SubItems.Add(tel);
                    lv.SubItems.Add(senha);
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
                conn.CloseConnection();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try {
                User usobj = new User(
                    txt_name.Text,
                    txt_email.Text,
                    txt_telefone.Text,
                    txt_cadastro.Text
                    ); 
                UserDAO nobj = new UserDAO();
            nobj.InsertUser(usobj);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


           

            string Name = txt_name.Text, 
                   Email = txt_email.Text, 
                   Phone = txt_telefone.Text, 
                   Password = txt_cadastro.Text;
           
            MessageBox.Show(
                "Nome: " + Name + "\nEmail: " + Email + "\nTelefone: " + Phone + "\nSenha: " + Password, "Info"
            );

           
            txt_name.Clear();
            txt_email.Clear();
            txt_telefone.Clear(); 
            txt_cadastro.Clear();    

            UpdateListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txt_name.Text = listView1.Items[index].SubItems[1].Text;
            txt_email.Text = listView1.Items[index].SubItems[2].Text;
            txt_telefone.Text = listView1.Items[index].SubItems[3].Text;
            txt_cadastro.Text = listView1.Items[index].SubItems[5].Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
