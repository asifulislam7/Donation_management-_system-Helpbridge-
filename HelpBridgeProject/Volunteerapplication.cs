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
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HelpBridgeProject
{
    public partial class Volunteerapplication: Form
    {
        public Volunteerapplication()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vhomepage aa = new Vhomepage();
            aa.Show();
            this.Hide();
        }

        private void Volunteerapplication_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "SELECT * FROM Request ";
                          
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                String q = "SELECT *  FROM Request  Where R_code =" + Rid;
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                rid.Text = dt.Rows[0]["R_code"].ToString();
                cid.Text = dt.Rows[0]["U_ID"].ToString();
                uid.Text = dt.Rows[0]["C_ID"].ToString();
                location.Text = dt.Rows[0]["R_Location"].ToString();
                richTextBox1.Text = dt.Rows[0]["R_comment"].ToString();

                combo.Text = dt.Rows[0]["R_status"].ToString();



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

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = "";
                if (combo.SelectedItem != null)
                {
                    selectedStatus = combo.SelectedItem.ToString();
                }

                using (SqlConnection connection = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();

                    string query = "UPDATE Request SET R_status = @status WHERE R_code = @code";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", selectedStatus);
                        command.Parameters.AddWithValue("@code", rid.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with that code.");
                        }
                    }
                }

              
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                    con.Open();
                    String q = "SELECT * FROM Request ";

                    SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.ClearSelection();




                    con.Close();

                    rid.Text = "";
                    richTextBox1.Text = "";
                    uid.Text = "";
                    cid.Text = "";
                    
                    location.Text = "";
                    food.Checked = mb.Checked = cb.Checked = ob.Checked = medi.Checked = false;
                    combo.SelectedItem = null;
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }

        }
    }
}
