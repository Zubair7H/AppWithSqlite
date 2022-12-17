using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using AppWithSqlite.UI;


namespace AppWithSqlite
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("zubairhussain19@gmail.com");
                msg.To.Add(textBox1.Text);
                msg.Subject = textBox3.Text;
                msg.Body = textBox2.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "zubairhussain09@gmail.com";
                ntcd.Password = "";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sent");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }
    }
    }

