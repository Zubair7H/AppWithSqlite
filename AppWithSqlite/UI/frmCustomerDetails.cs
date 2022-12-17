using AppWithSqlite.Manager;
using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithSqlite.UI
{
    public partial class frmCustomerDetails : Form
    {
        Form2 frm;
        public frmCustomerDetails(Form2 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        CustomerManager _customerManager = new CustomerManager();

        private void CSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CnameTextBox.Text))
                {
                    MessageBox.Show("Type name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CnameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(EmailTextBox.Text))
                {
                    MessageBox.Show("Type number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmailTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CnumberTextBox.Text))
                {
                    MessageBox.Show("Type Sallary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CnumberTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CaddressTextBox.Text))
                {
                    MessageBox.Show("Type Sallary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CaddressTextBox.Focus();
                    return;
                }
                Customer customer = new Customer();
                customer.CustomerId = Convert.ToInt32(Cidlabel.Text);
                customer.Cname = CnameTextBox.Text;
                customer.Email = EmailTextBox.Text;
                customer.Cnumber = CnumberTextBox.Text;
                customer.Caddress = CaddressTextBox.Text;

                if (_customerManager.Update(customer))
                {
                    MessageBox.Show("Customer has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();

                }
                else
                {
                    MessageBox.Show("Customer saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
