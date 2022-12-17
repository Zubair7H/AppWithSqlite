using AppWithSqlite.Manager;
using AppWithSqlite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithSqlite.UI
{
    public partial class frmsupplierDetails : Form
    {
        Form4 frm;
        public frmsupplierDetails(Form4 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SupplierManager _SupplierManager = new SupplierManager();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(supplierNameTextBox.Text))
                {
                    MessageBox.Show("Type name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    supplierNameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(supplierphoneTextBox.Text))
                {
                    MessageBox.Show("Type number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    supplierphoneTextBox.Focus();
                    return;
                }
             
                Supplier supplier = new Supplier();
                supplier.supplierID = Convert.ToInt32(idlbl.Text);
                supplier.suppliername = supplierNameTextBox.Text;
                supplier.supplierphone = supplierphoneTextBox.Text;
               
                if (_SupplierManager.Update(supplier))
                {
                    MessageBox.Show("Supplier has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();

                }
                else
                {
                    MessageBox.Show("Supplier saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
