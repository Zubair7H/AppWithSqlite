using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWithSqlite.Gateway;
using AppWithSqlite.Manager;
using AppWithSqlite.Models;
using AppWithSqlite.UI;
using Dapper;



namespace AppWithSqlite
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CustomerManager _customerManager = new CustomerManager();
        ApplicationDBcontext _dbContext2= new ApplicationDBcontext();
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            CustomerManager _customerManager = new CustomerManager();
            var customers = _customerManager.GetAll();
            customerDataGridView.Rows.Clear();
            foreach (var customer in customers)
            {
                customerDataGridView.Rows.Add(customer.CustomerId,customer.Cname,customer.Email,customer.Cnumber,customer.Caddress);
            }
        }

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
                    MessageBox.Show("Type email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmailTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CnumberTextBox.Text))
                {
                    MessageBox.Show("Type number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CnumberTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CaddressTextBox.Text))
                {
                    MessageBox.Show("Type address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CnumberTextBox.Focus();
                    return;
                }
                Customer customer= new Customer();
                customer.Cname = CnameTextBox.Text;
                customer.Email = EmailTextBox.Text;
                customer.Cnumber = CnumberTextBox.Text;
                customer.Caddress = CaddressTextBox.Text;
                if (_customerManager.Add(customer))
                {
                    MessageBox.Show("customer has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
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

        private void Reset()
        {
            CnameTextBox.Text = string.Empty;
            EmailTextBox.Clear();
            CnumberTextBox.Clear();
            CaddressTextBox.Clear();
            LoadData();
        }

        private void customerDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = customerDataGridView.SelectedRows[0];
                frmCustomerDetails frm = new frmCustomerDetails(this);
                //this.Hide();
                //frm.Show();
                frm.Cidlabel.Text = dr.Cells[0].Value.ToString();
                frm.CnameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.EmailTextBox.Text = dr.Cells[2].Value.ToString();
                frm.CnumberTextBox.Text = dr.Cells[3].Value.ToString();
                frm.CaddressTextBox.Text = dr.Cells[4].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = customerDataGridView.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _customerManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("customer details has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LoadData();
                        customerDataGridView.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failiure.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();
        }

        private void Mailbutton_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();
        }
    }
}
