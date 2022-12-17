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
using Dapper;

namespace AppWithSqlite.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SupplierManager _SupplierManager = new SupplierManager();
        ApplicationDBcontext _dbContext2 = new ApplicationDBcontext();

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
                    MessageBox.Show("Type supplier phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    supplierphoneTextBox.Focus();
                    return;
                }
               
                Supplier supplier = new Supplier();
                supplier.suppliername = supplierNameTextBox.Text;
                supplier.supplierphone = supplierphoneTextBox.Text;
                if (_SupplierManager.Add(supplier))
                {
                    MessageBox.Show("supplier has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("supplier saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            supplierNameTextBox.Text = string.Empty;
            supplierphoneTextBox.Clear();
            LoadData();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            SupplierManager _SupplierManager = new SupplierManager();
            var suppliers = _SupplierManager.GetAll();
            dataGridView1.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                dataGridView1.Rows.Add(supplier.supplierID, supplier.suppliername, supplier.supplierphone);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                frmsupplierDetails frm = new frmsupplierDetails(this);
                //this.Hide();
                //frm.Show();
                frm.idlbl.Text = dr.Cells[0].Value.ToString();
                frm.supplierNameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.supplierphoneTextBox.Text = dr.Cells[2].Value.ToString();
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
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _SupplierManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("customer details has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LoadData();
                        dataGridView1.Rows.Remove(dr);
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
    }
}
