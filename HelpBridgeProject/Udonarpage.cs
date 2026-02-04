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
    public partial class Udonarpage: Form
    {
        public Udonarpage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void donationbtn_Click(object sender, EventArgs e)
        {
            userdonation donate = new userdonation();
            donate.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ulogin donate = new Ulogin();
            donate.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsereResume r = new UsereResume();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdonarIDcs donate = new UdonarIDcs();
            donate.Show();
            this.Hide();
        }

        private void Udonarpage_Load(object sender, EventArgs e)
        {

        }
    }
}
