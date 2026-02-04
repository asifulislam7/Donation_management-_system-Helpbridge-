using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace HelpBridgeProject
{
    public partial class AdminApplication : Form
    {
        public AdminApplication()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hbtn_Click(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void Vbtn_Click(object sender, EventArgs e)
        {
            Adminevent aa = new Adminevent();
            aa.Show();
            this.Hide();
        }

        private void taskbtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminApplication_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void ebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
     

        private void refresh()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "SELECT Crisis.C_name,Usertb.U_Name, Request.*   FROM Request " +
                          "INNER JOIN Crisis ON Crisis.C_ID = Request.C_ID  INNER JOIN Usertb ON Usertb.U_ID = Request.U_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

                this.Clear();
                

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.Clear();

        }
        private void Clear()
        {

            cvtxt.Text = "";
            unametxt.Text = "";
            uidtxt.Text = "";
            codetxt.Text = "";
            textBox1.Text = "";
            ltxt.Text = "";
            food.Checked = mb.Checked = cb.Checked = ob.Checked = medi.Checked = false;
            scombo.SelectedItem = null;
            stxt.Text = "";
            richTextBox1.Text = "";


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

                int Rid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["R_code"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "SELECT Crisis.C_name,Usertb.U_Name, Request.*  FROM Request " +
                          "INNER JOIN Crisis ON Crisis.C_ID = Request.C_ID " +
                          "INNER JOIN Usertb ON Usertb.U_ID = Request.U_ID" +
                          " Where R_code =" + Rid;
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                codetxt.Text = dt.Rows[0]["R_code"].ToString();
                unametxt.Text = dt.Rows[0]["U_Name"].ToString();
                uidtxt.Text = dt.Rows[0]["U_ID"].ToString();
                textBox1.Text = dt.Rows[0]["C_ID"].ToString();
                ltxt.Text = dt.Rows[0]["R_Location"].ToString();
                richTextBox1.Text = dt.Rows[0]["R_comment"].ToString();
                cvtxt.Text = dt.Rows[0]["C_name"].ToString();

                scombo.Text = dt.Rows[0]["R_status"].ToString();



                string item = dt.Rows[0]["R_item"].ToString();
                food.Checked = item.Contains("Food");
                cb.Checked = item.Contains("Cloths");
                mb.Checked = item.Contains("Money");
                medi.Checked = item.Contains("Medicine");
                ob.Checked = item.Contains("Others");



                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void subdbtn_Click(object sender, EventArgs e)
        { 

            try
        {
            string status = scombo.SelectedItem == null ? "" :scombo .SelectedItem.ToString();
            

            SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

            con.Open();



            string q = "UPDATE Request SET R_status = '" + status + "' WHERE R_code = " + codetxt.Text;


                SqlCommand cmd = new SqlCommand(q, con);

            cmd.ExecuteNonQuery();

             stxt.Text ="";
                


            con.Close();

            MessageBox.Show("updated");
            this.refresh();



        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "SELECT Crisis.C_name,Usertb.U_Name, Request.*  FROM Request " +
                          "INNER JOIN Crisis ON Crisis.C_ID = Request.C_ID " +
                          "INNER JOIN Usertb ON Usertb.U_ID = Request.U_ID" +
                    " WHERE Request.R_code LIKE '" + stxt.Text + "%' ";
                    


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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
