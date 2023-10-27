using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Validation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
          string email= txtInput.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email address is required.");
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Email address must contain the '@' character.");
            }
            else
            {
                // Additional email validation logic can be added here

                MessageBox.Show("Email is valid.");
            }
        }

        private void btnpassword_Click(object sender, RoutedEventArgs e)
        {
            string password = txtInput.Text;

            if (string.IsNullOrWhiteSpace(password))// check if password does exist
            {
                MessageBox.Show("Password is required.");
                return;
            }
            // Regex class is used for regular expressions.
            // One can use this for checking if there is a presence of either: uppercase/lowercase/digit/special character etc

            Regex uppercaseRegex = new Regex(@"[A-Z]");
            Regex lowercaseRegex = new Regex(@"[a-z]");
            Regex digitRegex = new Regex(@"[0-9]");
            Regex specialCharRegex = new Regex(@"[^a-zA-Z0-9]");

            if (!uppercaseRegex.IsMatch(password))
            {
                MessageBox.Show("Password must contain an uppercase letter.");
                return;
            }

            if (!lowercaseRegex.IsMatch(password))
            {
                MessageBox.Show("Password must contain a lowercase letter.");
                return;
            }

            if (!digitRegex.IsMatch(password))
            {
                MessageBox.Show("Password must contain a digit.");
                return;
            }

            if (!specialCharRegex.IsMatch(password))
            {
                MessageBox.Show("Password must contain a special character.");
                return;
            }

            // Additional password validation logic can be added here

            MessageBox.Show("Password is valid.");
        }
    }
}

// Now you can try to allow the user to connect to a database
//Allow the user only 3 attempts to sucessfully login.
//After 3 attempts- 
