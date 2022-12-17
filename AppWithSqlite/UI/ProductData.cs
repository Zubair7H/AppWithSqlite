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
using Dapper;
namespace AppWithSqlite.UI
{

    public partial class ProductData : Form
    {
        IProductRepository productRepository;
        public ProductData()
        {
            InitializeComponent();
        }

        private void ProductData_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            productRepository =new ProductRepo();
            dataGridView1.DataSource = productRepository.GetProduct();
            lblprofit.Text = $"Total records:{dataGridView1.RowCount}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridView e)
        {


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
