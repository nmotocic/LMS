﻿using Microsoft.Data.SqlClient;
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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PIKA-DESKTOP;Initial Catalog=Library;Integrated Security=True");
        string connectionString = "Data Source=PIKA-DESKTOP;Initial Catalog=Library;Integrated Security=True";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Register
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UserAdd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", RandomNumber(0, 1000));
                    cmd.Parameters.AddWithValue("@name", firstName.Text);
                    cmd.Parameters.AddWithValue("@surname", surnameBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                    cmd.Parameters.AddWithValue("@password", passwordBox.Text);
                    cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registraiton successfull!");
                    Clear();
                    this.Hide();
                    (new LoginForm()).Show();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear()
        {
            firstName.Text = surnameBox.Text = emailBox.Text = usernameBox.Text = passwordBox.Text = phoneBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
