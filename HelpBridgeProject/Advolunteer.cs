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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace HelpBridgeProject
{
    public partial class Advolunteer: Form
    {
        public Advolunteer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Advolunteer_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear()
        {

            idtxt.Text = "Auto Generated";
            nametxt.Text = "";
            etxt.Text = "";
            ptxt.Text = "";
            mbuttn.Checked = fbuttn.Checked = false;
            richTextBox1.Text = "";
            
            
            

        }

        private void refresh()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "select V_Id, V_Name, V_Email, V_phone, V_gender, V_task from dbo.Volunteer";

                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();


                this.Clear();
                stxt.Text = "";

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["V_Id"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "select V_Id, V_Name, V_Email, V_phone, V_gender, V_task from dbo.Volunteer Where V_Id=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                idtxt.Text = dt.Rows[0]["V_Id"].ToString();
                nametxt.Text = dt.Rows[0]["V_Name"].ToString();
                etxt.Text = dt.Rows[0]["V_Email"].ToString();
                ptxt.Text = dt.Rows[0]["V_phone"].ToString();
                richTextBox1.Text = dt.Rows[0]["V_task"].ToString();

                string gender = dt.Rows[0]["V_gender"].ToString();
                if (gender == "Male")
                    mbuttn.Checked = true;  
                else if (gender == "Female")
                    fbuttn.Checked = true;  

               




                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                
                string Name = nametxt.Text;
                string Email = etxt.Text;
                string phone = ptxt.Text;
                string task = richTextBox1.Text;



                string Gender = "";


                if (mbuttn.Checked)
                {

                    Gender = mbuttn.Text;
                }
                else if (fbuttn.Checked)
                {
                    Gender = fbuttn.Text;
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




                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                string q = "UPDATE Volunteer SET V_Name='" + Name + "', V_Email='" + Email + "', V_phone='" +
                      phone + "', V_gender='" + Gender + "', V_task='" + task + "' WHERE V_Id=" + idtxt.Text;

                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record updated successfully");
                this.refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            try
            {

                string Name = nametxt.Text;
                string Email = etxt.Text;
                string phone = ptxt.Text;
                



                string Gender = "";


                if (mbuttn.Checked)
                {

                    Gender = mbuttn.Text;
                }
                else if (fbuttn.Checked)
                {
                    Gender = fbuttn.Text;
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




                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                string q = "DELETE from dbo.Volunteer Where V_Id=" + idtxt.Text;


                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Volunteer :" + nametxt.Text+"," + " (ID: " + idtxt.Text + ")  has been deleted successfully.");
                this.refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void applibtn_Click(object sender, EventArgs e)
        {
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.refresh();
            stxt.Text = "";
        }

        private void adbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = idtxt.Text;
                string Name = nametxt.Text;
                string Email = etxt.Text;
                string phone = ptxt.Text;
                string task = richTextBox1.Text;



                string Gender = "";
                

                if (mbuttn.Checked)
                {

                    Gender = mbuttn.Text;
                }
                else if (fbuttn.Checked)
                {
                    Gender = fbuttn.Text;
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
               


                
                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                if (ID == "Auto Generated")
                {
                   
                    string q = "INSERT INTO dbo.Volunteer (V_Name, V_Email, V_phone, V_gender,V_task) " +
                               "VALUES ('" + Name + "','" + Email + "','" + phone + "','" + Gender + "','" + task + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Record Inserted");
                }
                else
                {
                 
                    MessageBox.Show("This record already exists. Use Update instead.");
                    return;
                }



                con.Close();

                this.refresh();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                string q = "select V_Id, V_Name, V_Email, V_phone, V_gender from dbo.Volunteer where [V_Id] LIKE '" + stxt.Text + "%' OR [V_Name] LIKE '" + stxt.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();


                stxt.Text = "";

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rebtn_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void sbtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                string q = "select * from dbo.Volunteer where [V_Id] LIKE '" + stxt.Text + "%' OR [V_name] LIKE '" + stxt.Text + "%'";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Adminapproval aa = new Adminapproval();
            aa.Show();
            this.Hide();
        }

        private void ebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }

