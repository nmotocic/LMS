using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=PIKA-DESKTOP;Initial Catalog=Library;Integrated Security=True";
            con.Open();

            string password = passwordBox.Text;
            string username = usernameBox.Text;

            string query = "select * from tbUser where username='" + username + "'and password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                //this.Hide()
                //show whatever needs to be shown
                MessageBox.Show("Login successful!");
            }
            else {
                MessageBox.Show("Invalid login! Please check your username and password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
            {
            }
    }
}
