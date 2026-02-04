using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;

namespace HelpBridgeProject
{
    public partial class UsereResume: Form
    {
        public UsereResume()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void Clear()
        {
            idtxt.Text = "Auto Generated";
            ntxt.Text = "";
            etxt.Text = "";
            ptxt.Text = "";
            htxt.Text = "";
            mbtn.Checked = fbtn.Checked = false;
            comboBox1.SelectedItem = null;
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idtxt.Text.Trim();
                string name = ntxt.Text.Trim();
                string email = etxt.Text.Trim();
                string phone = ptxt.Text.Trim();
                string history = htxt.Text.Trim();
                string gender = mbtn.Checked ? "Male" : (fbtn.Checked ? "Female" : "");
                string status = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();

                // Basic validation
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Please fill all required fields: Name, Email, Phone, and Gender.");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    if (id == "Auto Generated" || string.IsNullOrEmpty(id))
                    {
                        string query = @"INSERT INTO Resume (Name, Email, Phone, [Medical History], Gender, Status)
                                 VALUES (@Name, @Email, @Phone, @History, @Gender, @Status)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@History", history);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("New resume record inserted successfully!");
                            Clear();
                           
                        }
                        else
                        {
                            MessageBox.Show("Insert failed. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This record already exists. Please use Update instead.");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UsereResume_Load(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Udonarpage p = new Udonarpage();
            p.Show();
            this.Hide();
        }
    }
}
