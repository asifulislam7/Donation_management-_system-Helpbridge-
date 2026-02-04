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
    public partial class Upassword: Form
    {
        public Upassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void Upassword_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Ulogin u = new Ulogin();
            u.Show();
            this.Hide();
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            string id = idtext.Text.ToString();
            string email = etext.Text.ToString();
            string newPassword = passtext.Text.ToString();

            if (id == "" || email == "" || newPassword == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Usertb WHERE U_ID = @id AND U_email = @Email";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", id);
                    checkCmd.Parameters.AddWithValue("@Email", email);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        string updateQuery = "UPDATE Usertb SET U_pass = @Password WHERE U_ID = @id AND U_email = @Email";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@Password", newPassword);
                        updateCmd.Parameters.AddWithValue("@id", id);
                        updateCmd.Parameters.AddWithValue("@Email", email);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully!");

                        idtext.Text = "";
                        etext.Text = "";
                        passtext.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No record found with this ID and Email.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
