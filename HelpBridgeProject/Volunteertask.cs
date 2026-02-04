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
    public partial class Volunteertask: Form
    {
        public Volunteertask()
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

        private void Volunteertask_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

          
            try
            {
                if (string.IsNullOrWhiteSpace(searchtxt.Text))
                {
                    MessageBox.Show("Please enter Volunteer ID or Name to search.");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();


                    string q = "select * from Volunteer where [V_Id] LIKE '" + searchtxt.Text + "%' OR [V_name] LIKE '" + searchtxt.Text + "%'";
                    SqlCommand cmd = new SqlCommand(q, con);
                  

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) 
                    {
                        IDtxt.Text = reader["V_Id"].ToString();
                        nametxt.Text = reader["V_Name"].ToString();
                        emailtxt.Text = reader["V_Email"].ToString();
                        richTextBox1.Text = reader["V_task"].ToString();

                       
                    }
                    else
                    {
                        MessageBox.Show("No volunteer found with this ID or Name.");
                       
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}


