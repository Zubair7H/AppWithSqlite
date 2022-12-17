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
    public partial class frmSellerDetails : Form
    {
       
        Form1 frm;

        public frmSellerDetails(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SellerManager _sellerManager= new SellerManager();

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    MessageBox.Show("Type name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NumberTextBox.Text))
                {
                    MessageBox.Show("Type number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NumberTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(SallaryTextBox.Text))
                {
                    MessageBox.Show("Type Sallary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SallaryTextBox.Focus();
                    return;
                }
                Sellers sellers = new Sellers();
                sellers.ID=Convert.ToInt32(IdLabel.Text);
                sellers.Name = NameTextBox.Text;
                sellers.Number = NumberTextBox.Text;
                sellers.Sallary = SallaryTextBox.Text;

                if (_sellerManager.Update(sellers))
                {
                    MessageBox.Show("Seller has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();

                }
                else
                {
                    MessageBox.Show("Seller saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
