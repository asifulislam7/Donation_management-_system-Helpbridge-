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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;

namespace HelpBridgeProject
{
    public partial class userHelpseeker: Form
    {
        public userHelpseeker()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void userHelpseeker_Load(object sender, EventArgs e)
        {
            this.crisistable();
            this.Requesttable();
            this.Clear();
        }
        private void crisistable()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "select * from Crisis";
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

        private void Requesttable()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "select * from Request";
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
                dataGridView2.ClearSelection();


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            rtxt.Text = "Auto Generated";
           
            cid.Text = "(Select from Crisis table)";
            uid.Text = "";
            ltxt.Text = "";
            richTextBox1.Text = "";
            cvtxt.Text = "(Select from Crisis table)";
            

            food.Checked = false;
            mb.Checked = false;
            cb.Checked = false;
            medi.Checked = false;
            ob.Checked = false;

            
            scombo.SelectedItem = null;


        }


        private void subdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string location = ltxt.Text.ToString();
                string comment = richTextBox1.Text.ToString();
                string status = scombo.SelectedItem == null ? "" : scombo.SelectedItem.ToString();
                string items = "";
                string DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
                string id = rtxt.Text.ToString();

                if (food.Checked) items += "Food ";
                if (mb.Checked) items += "Money ";
                if (cb.Checked) items += "Cloths ";
                if (medi.Checked) items += "Medicine ";
                if (ob.Checked) items += "Others ";

                if (cid.Text == "" || uid.Text == "" || location == "")
                {
                    MessageBox.Show("Please fill all required fields (User ID, Crisis ID, and Location).");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string roleQuery = "SELECT U_role FROM Usertb WHERE U_ID = @UserID";
                    SqlCommand roleCmd = new SqlCommand(roleQuery, con);
                    roleCmd.Parameters.AddWithValue("@UserID", uid.Text);

                    object roleResult = roleCmd.ExecuteScalar();

                    if (roleResult == null)
                    {
                        MessageBox.Show("User not found! Please check the User ID.");
                        return;
                    }

                    string userRole = roleResult.ToString();

                    if (!userRole.Equals("HelpSeeker", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Only Helpseekers are allowed to submit requests.");
                        return;
                    }

                    if (id == "Auto Generated")
                    {
                        string insertQuery = @"INSERT INTO Request (U_ID, C_ID, R_Location, R_item, R_comment, R_status, R_date)
                                       VALUES (@U_ID, @C_ID, @R_Location, @R_item, @R_comment, @R_status, @R_date)";

                        SqlCommand cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@U_ID", uid.Text);
                        cmd.Parameters.AddWithValue("@C_ID", cid.Text);
                        cmd.Parameters.AddWithValue("@R_Location", location);
                        cmd.Parameters.AddWithValue("@R_item", items.Trim());
                        cmd.Parameters.AddWithValue("@R_comment", comment);
                        cmd.Parameters.AddWithValue("@R_status", status);
                        cmd.Parameters.AddWithValue("@R_date", DOB);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("New request inserted successfully!");
                            Clear();
                            this.Requesttable();
                        }
                        else
                        {
                            MessageBox.Show("Insertion failed. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This record already exists. Use Update instead.");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                {
                    dataGridView1.ClearSelection();
                    return;
                }

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["C_ID"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "select * from dbo.Crisis Where C_ID=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                cid.Text = dt.Rows[0]["C_ID"].ToString();
                cvtxt.Text = dt.Rows[0]["C_name"].ToString();





                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uhelppage aa = new Uhelppage();
            aa.Show();
            this.Hide();
        }
    }
}
