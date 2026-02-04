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
    public partial class Adminevent: Form
    {
        public Adminevent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admindonation aa = new Admindonation();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addcrsis aa = new Addcrsis();
            aa.Show();
            this.Hide();
        }

        private void applibtn_Click(object sender, EventArgs e)
        {
            AdminApplication aa = new AdminApplication();
            aa.Show();
            this.Hide();
        }

        private void Adminevent_Load(object sender, EventArgs e)
        {

        }
    }
}
