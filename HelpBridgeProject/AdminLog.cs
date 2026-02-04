using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpBridgeProject
{
    public partial class AdminLog: Form
    {
        public AdminLog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void AdminLog_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 aa = new Form1();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ntxt.Text == "admin" && textBox2.Text == "123")
            {
                Admindash aa = new Admindash();
                aa.Show();
                this.Hide();
            }
            else if (ntxt.Text == "" || textBox2.Text == ""){
                MessageBox.Show("Please fill up all the information"); }
            
            else {
                MessageBox.Show("Wrong password or username");
                ntxt.Text = "";
                textBox2.Text = "";


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
