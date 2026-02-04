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
using System.Security.Cryptography;

namespace HelpBridgeProject
{
    public partial class Volunteerdonation: Form
    {
        public Volunteerdonation()
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

        private void Volunteerdonation_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "SELECT * FROM Donation ";
                    
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

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(did.Text))
                {
                    MessageBox.Show("Please enter a Donation ID.");
                    return;
                }

                if (combo.SelectedItem == null)
                {
                    MessageBox.Show("Please select a status.");
                    return;
                }

                string newStatus = combo.SelectedItem.ToString();

                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "UPDATE Donation SET D_status = @status WHERE D_ID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", did.Text);

                    int updated = cmd.ExecuteNonQuery();

                    if (updated > 0)
                        MessageBox.Show("Donation status updated!");
                    else
                        MessageBox.Show("No record found for that ID.");
                }

                // Refresh the table and clear fields

                try
                {

                    SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                    con.Open();

                    String q = "SELECT * FROM Donation ";

                    SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.ClearSelection();




                    con.Close();
                    did.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
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

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["D_ID"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "SELECT *  FROM Donation  Where D_ID =" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                did.Text = dt.Rows[0]["D_ID"].ToString();
                cid.Text = dt.Rows[0]["U_ID"].ToString();
                uid.Text = dt.Rows[0]["C_ID"].ToString();
                location.Text = dt.Rows[0]["D_Location"].ToString();
                richTextBox1.Text = dt.Rows[0]["D_comment"].ToString();

                combo.Text = dt.Rows[0]["D_status"].ToString();



                string item = dt.Rows[0]["D_item"].ToString();
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
    }
}

