using LMS.Presenters;
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

namespace LMS.Views
{
    public partial class LoginForm : Form
    {
        ProfilePresenter profilePresenter = new ProfilePresenter();

        public LoginForm()
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

            string query = "select * from Customer where username='" + username + "'and password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                if (username.Equals("admin"))
                {
                    (new AdminForm()).Show();
                }
                else {
                    (new BookCatalogForm(username)).Show();
                }

                

                
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

        

        private void registerBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new RegisterForm()).Show();
        }

        
    }
}
