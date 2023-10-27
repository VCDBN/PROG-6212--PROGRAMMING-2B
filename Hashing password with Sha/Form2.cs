using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;// this should be imported if you get errors
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2POE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public SqlConnection sqlConnection;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            string hashedPassword = GetSHA256Hash(password);// hashing the password


            using (SqlConnection connection = new SqlConnection(Connection.conn))
            {
                connection.Open();

                string query = "INSERT INTO LoginDetails values('"+textBox1 .Text +"','"+ hashedPassword +"')";
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show("Record added into Database");
                connection.Close();

            }
         
        }


        static string GetSHA256Hash(string input)// This can be setup in your custom Class library
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        



        private void btnPopulate_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT ModuleCode FROM ModuleDetails";

            using (SqlConnection connection = new SqlConnection(Connection.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string moduleCode = reader["ModuleCode"].ToString();
                    comboBox1.Items.Add(moduleCode);
                }

                reader.Close();
                connection.Close();
                MessageBox.Show("Combobox is loaded ");
                comboBox1.Text = "Please select a module";
            }
            
        }
    }
}
