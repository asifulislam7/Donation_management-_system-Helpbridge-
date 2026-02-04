using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HelpBridgeProject
{
    public partial class UhelpID : Form
    {
        public UhelpID()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void subdbtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                string q = "select U_ID,U_Name,U_gender,U_role,U_email from dbo.Usertb where [U_email] LIKE '" + stxt.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();



                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Uhelppage udonarpage = new Uhelppage();
            udonarpage.Show();
            this.Hide();
        }

        private void UhelpID_Load(object sender, EventArgs e)
        {

        }
    }
}
