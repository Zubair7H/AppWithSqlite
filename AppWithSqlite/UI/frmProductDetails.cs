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

namespace AppWithSqlite.UI
{
    public partial class frmProductDetails : Form
    {
        Form5 frm;
        public frmProductDetails(Form5 frm)
        {
            InitializeComponent();
            this.frm = frm;
           
        }
        ProductManager _productManager = new ProductManager();

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SidTextBox.Text))
                {
                    MessageBox.Show("Type supplierid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Type brand name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BrandTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CostTextBox.Text))
                {
                    MessageBox.Show("Type cost amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CostTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PriceTextBox.Text))
                {
                    MessageBox.Show("Type price amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PriceTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TypeTextBox.Text))
                {
                    MessageBox.Show("Type the type of material.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TypeTextBox.Focus();
                    return;
                }
                Product product = new Product();
                product.productID = Convert.ToInt32(pidlbl.Text);
                product.supplierID = Convert.ToInt32(SidTextBox.Text);
                product.productName = PnameTextBox.Text;
                product.Brand = BrandTextBox.Text;
                product.Cost = Convert.ToDecimal(CostTextBox.Text);
                product.Price = Convert.ToDecimal(PriceTextBox.Text);
                product.Type = TypeTextBox.Text;
              

                    if (_productManager.Update(product))
                {
                    MessageBox.Show("Product has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();

                }
                else
                {
                    MessageBox.Show("product saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
