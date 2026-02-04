using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HelpBridgeProject
{
    public partial class Adminapproval: Form
    {
        public Adminapproval()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void Clear()
        {
            idtxt.Text = "";
            ptxt.Text = "";
            etxt.Text = "";
            htxt.Text = "";
            ntxt.Text = "";
            mbtn.Checked = fbtn.Checked = false;
            comboBox1.SelectedItem = null;
            stxt.Text = "";
            checkBox1.Checked  = false;
            
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

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Resume_code"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "select * from dbo.Resume Where Resume_Code=" + id;

                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];


                idtxt.Text = dt.Rows[0]["Resume_code"].ToString();

                ntxt.Text = dt.Rows[0]["Name"].ToString();
                etxt.Text = dt.Rows[0]["Email"].ToString();
                ptxt.Text = dt.Rows[0]["Phone"].ToString();
                htxt.Text = dt.Rows[0]["Medical History"].ToString();


                string gender = dt.Rows[0]["gender"].ToString();

                if (gender == "Male")
                    mbtn.Checked = true;
                else if (gender == "Female")
                    fbtn.Checked = true;



                comboBox1.Text = dt.Rows[0]["Status"].ToString();






                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            try
            {
               

                string status = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();





           


                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                string q = "UPDATE Resume SET Status='" + status  + "' WHERE Resume_code=" + idtxt.Text;
              

                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();



             

               
                if (checkBox1.Checked)   
                {
                    string ID = idtxt.Text;
                    string Name = ntxt.Text;
                    string Email = etxt.Text;
                    string phone = ptxt.Text;




                    string Gender = "";


                    if (mbtn.Checked)
                    {

                        Gender = mbtn.Text;
                    }
                    else if (fbtn.Checked)
                    {
                        Gender = fbtn.Text;
                    }




                    if (string.IsNullOrWhiteSpace(Name))
                    {
                        MessageBox.Show("Error : Enter Name");
                        return;

                    }
                    if (string.IsNullOrWhiteSpace(Email))
                    {
                        MessageBox.Show("Error : Enter Email");
                        return;

                    }
                    if (string.IsNullOrWhiteSpace(phone))
                    {
                        MessageBox.Show("Error : Enter Name");
                        return;

                    }
                    if (string.IsNullOrWhiteSpace(Gender))
                    {

                        MessageBox.Show("Error : Select gender");
                        return;

                    }




             

                    string qu = "INSERT INTO dbo.Volunteer (V_Name, V_Email, V_phone, V_gender) " +
                               "VALUES ('" + Name + "','" + Email + "','" + phone + "','" + Gender + "')";

                    SqlCommand cmd2 = new SqlCommand(qu, con);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Status Updated & Assigned as Volunteer");
                }
                else
                {
                    MessageBox.Show("Status Updated Only");
                }

                con.Close();
                this.refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Clear();
        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Appbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void taskbtn_Click(object sender, EventArgs e)
        {
            Advolunteer aa = new Advolunteer();
            aa.Show();
            this.Hide();
        }

        private void hbtn_Click(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void Adminapproval_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void refresh()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "select* from dbo.Resume";

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
