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
    public partial class Admindash: Form
    {
        public Admindash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void Admindash_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AdminLog aa = new AdminLog();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Advolunteer aa = new Advolunteer();
            aa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminevent aa = new Adminevent();
            aa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminuser aa = new Adminuser();
            aa.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
