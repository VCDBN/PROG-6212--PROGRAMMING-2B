using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//CHeck if you have this
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection= new SqlConnection (Connection.conn))
                {
                    connection.Open ();
                    String sql= "Select * from login where username='"+ txtUsername .Text +"'" + 
                        "and password='" + txtPassword.Text + "';";

                    SqlCommand command= new SqlCommand (sql, connection);
                    SqlDataReader reader = command.ExecuteReader ();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Yippy");
                    }
                    else
                    {
                        MessageBox.Show("Sorry- Invalid Credentials");
                    }
                    reader.Close ();
                    command.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
