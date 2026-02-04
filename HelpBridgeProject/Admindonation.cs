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
    public partial class Admindonation: Form
    {
        public Admindonation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        

        private void Admindonation_Load(object sender, EventArgs e)
        {
            this.refresh();
        }
       

        private void refresh()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "SELECT  Crisis.C_name, Usertb.U_name, Donation.*  " +
                    "FROM Donation INNER JOIN Usertb  ON Usertb.U_ID  = Donation.U_ID " +
                    "INNER JOIN Crisis  ON Crisis.C_ID  = Donation.C_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();


                doidtxt.Text = "";
                unametxt.Text = "";
                uidtxt.Text = "";
                cidtxt.Text = "";
                ltxt.Text = "";
                richTextBox1.Text = "";

                scombo.SelectedItem = null;


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
       

       

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                {
                    dataGridView1.ClearSelection();
                    return;
                }

                int did = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["D_ID"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "SELECT  Crisis.C_name, Usertb.U_name, Donation.*  FROM Donation" +
                    " INNER JOIN Usertb  ON Usertb.U_ID  = Donation.U_ID " +
                    " INNER JOIN Crisis  ON Crisis.C_ID  = Donation.C_ID " +
                          " Where D_ID=" + did;

                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                doidtxt.Text = dt.Rows[0]["D_ID"].ToString();
                unametxt.Text = dt.Rows[0]["U_Name"].ToString();
                uidtxt.Text = dt.Rows[0]["U_ID"].ToString();
                cidtxt.Text = dt.Rows[0]["C_ID"].ToString();
                ltxt.Text = dt.Rows[0]["D_Location"].ToString();
                richTextBox1.Text = dt.Rows[0]["D_item"].ToString();

                scombo.Text = dt.Rows[0]["D_status"].ToString();
                stxt.Text = "";







                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void rbtn_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string status = scombo.SelectedItem == null ? "" : scombo.SelectedItem.ToString();


                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();



                string q = "UPDATE dbo.Donation SET D_status = '" + status + "' WHERE D_ID = " + doidtxt.Text;


                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();

                stxt.Text = "";



                con.Close();

                MessageBox.Show("updated");
                this.refresh();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbttn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source= ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "SELECT  Crisis.C_name, Usertb.U_name, Donation.*  FROM Donation" +
                    " INNER JOIN Usertb  ON Usertb.U_ID  = Donation.U_ID " +
                    " INNER JOIN Crisis  ON Crisis.C_ID  = Donation.C_ID "+
                    " WHERE Donation.D_ID LIKE '" + stxt.Text + "%' " +
                    " OR Donation.U_ID    LIKE '" + stxt.Text + "%' " +
                    " OR Usertb.U_name    LIKE '" + stxt.Text + "%' " +
                    " OR Donation.C_ID    LIKE '" + stxt.Text + "%' " +
                    " OR Crisis.C_name    LIKE '" + stxt.Text + "%'";


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

        private void backbtn_Click(object sender, EventArgs e)
        {
            Adminevent aa = new Adminevent();
            aa.Show();
            this.Hide();
        }

        private void hbtn_Click_1(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void ebtn_Click(object sender, EventArgs e)
        {
          
            Application.Exit();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
