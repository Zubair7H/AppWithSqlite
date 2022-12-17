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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            this.Hide();
            form.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Hide();
            form.Show();
        }
    }
}
