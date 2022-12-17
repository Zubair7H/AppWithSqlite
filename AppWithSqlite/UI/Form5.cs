using AppWithSqlite.Manager;
using AppWithSqlite.Migrations;
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
using AppWithSqlite.UI;
using System.Configuration;
using Dapper;
using Microsoft.Data.Sqlite;

namespace AppWithSqlite
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager();
      
        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SidTextBox.Text))
                {
                    MessageBox.Show("Type name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SidTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PnameTextBox.Text))
                {
                    MessageBox.Show("Type product name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PnameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(BrandTextBox.Text))
                {
                    MessageBox.Show("Type Brand name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BrandTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CostTextBox.Text))
                {
                    MessageBox.Show("Type Cost amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CostTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PriceTextBox.Text))
                {
                    MessageBox.Show("Type Price amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PriceTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TypeTextBox.Text))
                {
                    MessageBox.Show("Type Type of material.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TypeTextBox.Focus();
                    return;
                }
                Product product = new Product();
                product.supplierID = Convert.ToInt32(SidTextBox.Text);
                product.productName = PnameTextBox.Text;
                product.Brand = BrandTextBox.Text;
                product.Cost = Convert.ToDecimal(CostTextBox.Text);
                product.Price = Convert.ToDecimal(PriceTextBox.Text);
                product.Type = TypeTextBox.Text;
                if (_productManager.Add(product))
                {
                    MessageBox.Show("product has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("product saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //customer.CustomerId = Convert.ToInt32(Cidlabel.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            SidTextBox.Text = string.Empty;
            PnameTextBox.Clear();
            BrandTextBox.Clear();
            CostTextBox.Clear();
            PriceTextBox.Clear();
            TypeTextBox.Clear();
            LoadData();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            ProductManager _productManager = new ProductManager();
            var products = _productManager.GetAll();
            ProductGridView.Rows.Clear();
            foreach (var product in products)
            {
                ProductGridView.Rows.Add(product.productID, product.supplierID, product.productName, product.Brand, product.Cost, product.Price, product.Type);
            }
        }

        private void ProductGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = ProductGridView.SelectedRows[0];
                frmProductDetails frm = new frmProductDetails(this);
                //this.Hide();
                //frm.Show();
                frm.pidlbl.Text = dr.Cells[0].Value.ToString();
                frm.SidTextBox.Text = dr.Cells[1].Value.ToString();
                frm.PnameTextBox.Text = dr.Cells[2].Value.ToString();
                frm.BrandTextBox.Text = dr.Cells[3].Value.ToString();
                frm.CostTextBox.Text = dr.Cells[4].Value.ToString();
                frm.PriceTextBox.Text = dr.Cells[5].Value.ToString();
                frm.TypeTextBox.Text = dr.Cells[6].Value.ToString();

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
                DataGridViewRow dr = ProductGridView.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _productManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("customer details has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LoadData();
                        ProductGridView.Rows.Remove(dr);
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

        private void showbtn_Click(object sender, EventArgs e)
        {
       

        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductData form = new ProductData();
            this.Hide();
            form.Show();
        }
    }
    }

    

