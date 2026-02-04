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

namespace HelpBridgeProject.Resources
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }


        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked) MessageBox.Show("You selected: Male");

        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked) MessageBox.Show("You selected: Female");

        }

        private void lblRole_Click(object sender, EventArgs e)
        {
            this.Text = "Role form";
            this.Size = new System.Drawing.Size(400, 300);

        }

        private void rdoDoner_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDoner.Checked) MessageBox.Show("You selected : Donar");

        }

        private void rdoHelpSeeker_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHelpSeeker.Checked) MessageBox.Show("You selected: HelpSeeker");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtUserName.Text.ToString();
                string Email = txtEmail.Text.ToString();
                string Password = txtPassword.Text.ToString();
                string Gender = "";
                string Role = "";

                if (chkMale.Checked)
                    Gender = "Male";
                else if (chkFemale.Checked)
                    Gender = "Female";

                if (rdoDoner.Checked)
                    Role = "Donar";
                else if (rdoHelpSeeker.Checked)
                    Role = "HelpSeeker";

                if (string.IsNullOrWhiteSpace(Name))
                {
                    MessageBox.Show("Please enter your username.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Email))
                {
                    MessageBox.Show("Please enter your email.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Please enter your password.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Gender))
                {
                    MessageBox.Show("Please select gender.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Role))
                {
                    MessageBox.Show("Please select role.");
                    return;
                }





                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = "INSERT INTO Usertb (U_Name, U_email, U_Pass, U_gender, U_role) " +
                                   "VALUES (@Name, @Email, @Password, @Gender, @Role)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@Role", Role);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUserName.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    chkMale.Checked = false;
                    chkFemale.Checked = false;
                    rdoDoner.Checked = false;
                    rdoHelpSeeker.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ulogin log = new Ulogin();
            log.Show();
            this.Hide();
        }
    }
}
