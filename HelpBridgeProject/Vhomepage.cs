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
    public partial class Vhomepage: Form
    {
        public Vhomepage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Volunteertask aa = new Volunteertask();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Volunteerapplication aa = new Volunteerapplication();
            aa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Volunteerdonation aa = new Volunteerdonation();
            aa.Show();
            this.Hide();
        }

        private void Vhomepage_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 aa = new Form1();
            aa.Show();
            this.Hide();
        }
    }
}
