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
    public partial class Uhelppage: Form
    {
        public Uhelppage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            userHelpseeker help = new userHelpseeker();
            help.Show();
            this.Hide();
        }

        private void Uhelppage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usertrack track = new Usertrack();
            track.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ulogin s = new Ulogin();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UhelpID helpID = new UhelpID();
            helpID.Show();
            this.Hide();
        }
    }
}
