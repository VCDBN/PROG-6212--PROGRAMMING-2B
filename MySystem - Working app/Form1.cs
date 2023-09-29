using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{


    public partial class Form1 : Form
    {
        //First create your instance of your table here
        Customer CustomerModel = new Customer();

        public Form1()
        {
            InitializeComponent();
            PopulateGridView();
        }

        void clear()
        {
            txtFirstname.Text = txtLastname.Text = txtCity.Text = txtAddress.Text = "";
            CustomerModel.CustomerID = 0;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerModel.FirstName=txtFirstname.Text.Trim();
            CustomerModel.LastName = txtLastname.Text.Trim();
            CustomerModel.City = txtCity.Text.Trim();
            CustomerModel.Address = txtAddress.Text.Trim();

           using (EFDBEntities3 db = new EFDBEntities3())
            {
                db.Customers.Add(CustomerModel);
                db.SaveChanges();

            }
           clear();
            PopulateGridView();
            MessageBox.Show("Record loaded successfully");

        }

        void PopulateGridView()
        {
            using(EFDBEntities3 db = new EFDBEntities3())
            {
                GridViewCustomer.DataSource = db.Customers.ToList<Customer>();
            }
        }
        private void GridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (GridViewCustomer.CurrentRow.Index != -1) {
                CustomerModel.CustomerID = Convert.ToInt32(GridViewCustomer.CurrentRow.Cells["CustomerID"].Value);

                using (EFDBEntities3 db = new EFDBEntities3())
                {
           CustomerModel= db.Customers.Where(x=> x.CustomerID == CustomerModel.CustomerID).FirstOrDefault();   
                    //
                    txtFirstname.Text = CustomerModel.FirstName;
                    txtLastname.Text = CustomerModel.LastName;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                    txtCity.Text = CustomerModel.City;
                    txtAddress.Text = CustomerModel.Address;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerModel.FirstName = txtFirstname.Text.Trim();
            CustomerModel.LastName = txtLastname.Text.Trim();
            CustomerModel.City = txtCity.Text.Trim();
            CustomerModel.Address = txtAddress.Text.Trim();

            using (EFDBEntities3 db = new EFDBEntities3())
            {
                db.Entry(CustomerModel).State = EntityState.Modified;//You might have to import this
                db.SaveChanges();
            }
            clear();
            PopulateGridView();
            MessageBox.Show("Record loaded successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Delete this record?","Exit Menu",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (EFDBEntities3 db = new EFDBEntities3 ())
                {
                    var entry = db.Entry(CustomerModel);
                    if (entry.State == EntityState.Detached)
                        db.Customers.Attach(CustomerModel);
                    db.Customers.Remove(CustomerModel);
                    db.SaveChanges();
                    PopulateGridView();             
                clear();

                    MessageBox.Show("Record is Deleted successfully");
                }
            }
        }

    }
}
