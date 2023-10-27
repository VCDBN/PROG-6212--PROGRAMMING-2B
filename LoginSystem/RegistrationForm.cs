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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BCrypt.Net;// Install from Nuget packages
using System.Drawing.Text;

namespace LoginSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public SqlConnection sqlConnection;
        private bool passwordMatch;

        private void btnBack_Click(object sender, EventArgs e)
        {//Go back to login from
            Form1 loginPage= new Form1();
            this.Hide();

            loginPage.ShowDialog();
            this.Show();
        }

    

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxPassword2.Text;



            if (password == confirmPassword)
            {
                MessageBox.Show("Passwords match!");
                sqlConnection = new SqlConnection(Connection.Conn);
                sqlConnection.Open();

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);//hash your password

                string query = "Insert into LoginCredentials Values('" + textBoxUsername.Text + "','" + hashedPassword  + "')";//Change hashedPassword to password and test
                
                
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Details Added Successfully");
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                textBoxPassword.Text = "";
                textBoxPassword2.Text = "";
                textBoxUsername.Text = "";

            }

        }
    }
}
