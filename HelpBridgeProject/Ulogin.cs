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
using HelpBridgeProject.Resources;

namespace HelpBridgeProject
{
    public partial class Ulogin: Form
    {
        public Ulogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string email = emailtext.Text.ToString();
            string password = passtext.Text.ToString();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = "SELECT U_role FROM Usertb WHERE U_Email = @Email AND U_Pass = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role.ToLower() == "donar")
                        {
                            MessageBox.Show("Login Successful! Welcome Donor.");
                            Udonarpage donorForm = new Udonarpage();
                            donorForm.Show();
                            this.Hide();
                        }
                        else if (role.ToLower() == "helpseeker")
                        {
                            MessageBox.Show("Login Successful! Welcome Helpseeker.");
                            Uhelppage helpForm = new Uhelppage();
                            helpForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role detected.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void passbtn_Click(object sender, EventArgs e)
        {
            Upassword u = new Upassword();
            u.Show();
            this.Hide();
        }

        private void Ulogin_Load(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            UserRegistration aa = new UserRegistration();
            aa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
