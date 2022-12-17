using AppWithSqlite.Manager;
using AppWithSqlite.Repos;
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

namespace AppWithSqlite
{
    public partial class Data : Form
    {
        ISellersRepository sellersRepository;

        public Data()
        {
            InitializeComponent();
        }

        SellerManager _sellerManager = new SellerManager();

        private void Data_Load(object sender, EventArgs e)
        {
          
            sellersRepository =new sellerRepo();
            dataGridView1.DataSource= sellersRepository.GetSellers();
            lblTotalRecords.Text = $"Total records:{dataGridView1.RowCount}";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
