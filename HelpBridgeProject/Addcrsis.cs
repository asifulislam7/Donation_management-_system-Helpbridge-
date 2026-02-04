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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HelpBridgeProject
{
    public partial class Addcrsis: Form
    {
        public Addcrsis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admindash aa = new Admindash();
            aa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminevent aa = new Adminevent();
            aa.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Clear()
        {

            idtxt.Text = "Auto Generated";
            cntxt.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedItem = null;
            stxt.Text = "";

        }

        private void refresh()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "select * from dbo.Crisis";
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();

                this.Refresh();
                this.Clear();
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
                string Name = cntxt.Text;
                string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
                string status = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();



                if (string.IsNullOrWhiteSpace(Name))
                {
                    MessageBox.Show("Error : Enter Name");
                    return;

                }
                if (string.IsNullOrWhiteSpace(status))
                {
                    MessageBox.Show("Error : Select Status");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Date))
                {

                    MessageBox.Show("Error : Select Date");
                    return;
                }
                


           
                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();


                if (ID == "Auto Generated")
                {
                    
                    string q = "insert into Crisis Values('" + Name + "','" + status + "','" + Date+ "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Event Created");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = idtxt.Text;
                string Name = cntxt.Text;
                string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
                string status = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();



                if (string.IsNullOrWhiteSpace(Name))
                {
                    MessageBox.Show("Error : Enter Name");
                    return;

                }
                if (string.IsNullOrWhiteSpace(status))
                {
                    MessageBox.Show("Error : Select Status");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Date))
                {

                    MessageBox.Show("Error : Select Date");
                    return;
                }




                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();



                string q = "UPDATE dbo.Crisis SET C_name='" + Name + "',C_status='" + status + "', C_date='" +
                    Date  + "' WHERE C_ID=" + idtxt.Text;


                SqlCommand cmd = new SqlCommand(q, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Event updated sucessfully.");
                this.refresh();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtxt_Click(object sender, EventArgs e)
        {
            this.refresh();
            this.Clear();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog= Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                string q = "select * from dbo.Crisis where [C_ID] LIKE '" + stxt.Text + "%' OR [C_name] LIKE '" + stxt.Text + "%'";
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

          
       

        private void Addcrsis_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                {
                    dataGridView1.ClearSelection();
                    return;
                }

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["C_ID"].Value.ToString());

                SqlConnection con = new SqlConnection("Data Source=ASIF\\SQLEXPRESS;Initial Catalog=Helpbridge;Integrated Security=True;TrustServerCertificate=True");

                con.Open();
                String q = "select * from dbo.Crisis Where C_ID=" + id;
                SqlDataAdapter adapter = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                idtxt.Text = dt.Rows[0]["C_ID"].ToString();
                cntxt.Text = dt.Rows[0]["C_name"].ToString();
                comboBox1.Text = dt.Rows[0]["C_status"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["C_date"]);






                con.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
    
