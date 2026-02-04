using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace HelpBridgeProject
{
    public partial class Adminuser: Form
    {
        public Adminuser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void Adminuser_Load(object sender, EventArgs e)
        {
          this.refresh();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        { }


        private void Clear()
        {

            idtxt.Text = "Auto Generated";
            ntxt.Text = "";
            etxt.Text = "";
            mbtn.Checked = fbtn.Checked = false;
            comboBox1.SelectedItem = null;
            stxt.Text = "";





        }

        private void refresh()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "select U_Id, U_Name, U_Email, U_role, U_gender  from dbo.Usertb";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                {
                    dataGridView1.ClearSelection();
                    return;
                }

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["U_Id"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                String q = "select U_Id, U_Name, U_Email, U_role, U_gender from dbo.Usertb Where U_Id=" + id;

                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];


                idtxt.Text = dt.Rows[0]["U_Id"].ToString();

                ntxt.Text = dt.Rows[0]["U_Name"].ToString();
                etxt.Text = dt.Rows[0]["U_Email"].ToString();
               

                string gender = dt.Rows[0]["U_gender"].ToString();

                if (gender =="Male")
                    mbtn.Checked = true;
                else if (gender == "Female")
                    fbtn.Checked = true;



                comboBox1.Text = dt.Rows[0]["U_role"].ToString();






                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = idtxt.Text;
                string Name = ntxt.Text;
                string Email = etxt.Text;

                string role = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();



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
                
                if (string.IsNullOrWhiteSpace(Gender))
                {

                    MessageBox.Show("Error : Select gender");
                    return;

                }




                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                if (ID == "Auto Generated")
                {

                    string q = "INSERT INTO dbo.Usertb (U_Name, U_Email, U_gender,U_role) " +
                               "VALUES ('" + Name + "','" + Email + "','"  + Gender + "','" + role + "')";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = idtxt.Text;
                string Name = ntxt.Text;
                string Email = etxt.Text;

                string role = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();



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

                if (string.IsNullOrWhiteSpace(Gender))
                {

                    MessageBox.Show("Error : Select gender");
                    return;

                }




                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                string q = "UPDATE Usertb SET U_Name='" + Name + "', U_Email='" + Email +
                        "', U_gender='" + Gender + "', U_role='" + role + "' WHERE U_ID=" + idtxt.Text;

                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record updated successfully");
                this.refresh();



                con.Close();

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
                string ID = idtxt.Text;
                string Name = ntxt.Text;
                string Email = etxt.Text;

                string role = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();



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

                if (string.IsNullOrWhiteSpace(Gender))
                {

                    MessageBox.Show("Error : Select gender");
                    return;

                }




                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                string q = "DELETE from dbo.Usertb Where U_Id=" + idtxt.Text;


                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Volunteer :" + ntxt.Text + "," + " (ID: " + idtxt.Text + ")  has been deleted successfully.");
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
                string q = "select * from dbo.Usertb where [U_Id] LIKE '" + stxt.Text + "%' OR [U_name] LIKE '" + stxt.Text + "%'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
    

