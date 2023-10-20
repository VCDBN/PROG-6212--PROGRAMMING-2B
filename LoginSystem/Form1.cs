using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;//Install this from Nuget


namespace LoginSystem
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Get your window in center of screen
        }
        public SqlConnection sqlConnection;



        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private bool ValidateUser(string username, string password)
        {

            sqlConnection = new SqlConnection(Connection.Conn);
            sqlConnection.Open();

            string query = "SELECT COUNT(*) FROM LoginCredentials WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            int count = (int)cmd.ExecuteScalar();

            sqlConnection.Close();

            return count > 0;

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;



            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
            txtPassword.Text = "";
            txtUsername.Text = "";

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {
            btnSignup.Visible = true;
            btnSignup.Enabled = true;
            labelDisplay.Visible = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            RegistrationForm form2 = new RegistrationForm();
            this.Hide();
            form2.ShowDialog();
            this.Show();

        }
        private void btnloginHash_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Get the username from your form input
            string query = "SELECT Password FROM LoginCredentials WHERE Username = @Username";

            sqlConnection = new SqlConnection(Connection.Conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@Username", username);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string storedHashedPassword = reader["Password"].ToString();
                // Now, 'storedHashedPassword' contains the hashed password for the given username

                bool passwordMatch = BCrypt.Net.BCrypt.Verify(txtPassword.Text, storedHashedPassword);
              
                MessageBox.Show("HAHA I GOT IN");

            }
            else
            {
                //
            }
            sqlConnection.Close();

        }


    }
}      
           

          

        

            



