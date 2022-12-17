using AppWithSqlite.Gateway;
using AppWithSqlite.Manager;
using AppWithSqlite.Models;
using AppWithSqlite.UI;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using System.Data;

namespace AppWithSqlite
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        SellerManager _sellerManager=new SellerManager();   

        private void Form1_Load(object sender, EventArgs e)
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
            SellerManager _sellerManager = new SellerManager();
            var seller = _sellerManager.GetAll();
            sellerDataGridView.Rows.Clear();
            foreach (var sellers in seller)
            {
                sellerDataGridView.Rows.Add(sellers.ID, sellers.Name, sellers.Number, sellers.Sallary);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(NameTextBox.Text))
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
                sellers.Name =NameTextBox.Text;
                sellers.Number = NumberTextBox.Text;
                sellers.Sallary= SallaryTextBox.Text;
               
                if (_sellerManager.Add(sellers))
                {
                    MessageBox.Show("Seller has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Seller saved has been failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            NameTextBox.Text= string.Empty;
            NumberTextBox.Clear();
            SallaryTextBox.Clear();
            LoadData();

        }

 

        private void sellerDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = sellerDataGridView.SelectedRows[0];
                frmSellerDetails frm = new frmSellerDetails(this);
                //this.Hide();
                //frm.Show();
                frm.IdLabel.Text = dr.Cells[0].Value.ToString();
                frm.NameTextBox.Text = dr.Cells[1].Value.ToString() ;
                frm.NumberTextBox.Text = dr.Cells[2].Value.ToString();
                frm.SallaryTextBox.Text= dr.Cells[3].Value.ToString();
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
                DataGridViewRow dr = sellerDataGridView.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete=_sellerManager.Delete(id);
                    if(isDelete)
                    {
                        MessageBox.Show("Seller details has been deleted.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //LoadData();
                        sellerDataGridView.Rows.Remove(dr);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Data form = new Data();
            this.Hide();
            form.Show();
        }
    }
}

