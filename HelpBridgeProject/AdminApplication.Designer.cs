namespace HelpBridgeProject
{
    partial class AdminApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cvtxt = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uidtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ob = new System.Windows.Forms.CheckBox();
            this.medi = new System.Windows.Forms.CheckBox();
            this.mb = new System.Windows.Forms.CheckBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.food = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ltxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clrbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.stxt = new System.Windows.Forms.TextBox();
            this.subdbtn = new System.Windows.Forms.Button();
            this.scombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hbtn = new System.Windows.Forms.Button();
            this.Vbtn = new System.Windows.Forms.Button();
            this.ebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cvtxt);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.uidtxt);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.ob);
            this.panel1.Controls.Add(this.medi);
            this.panel1.Controls.Add(this.mb);
            this.panel1.Controls.Add(this.cb);
            this.panel1.Controls.Add(this.food);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.ltxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.clrbtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.subdbtn);
            this.panel1.Controls.Add(this.scombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.unametxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.codetxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(413, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 746);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 236);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cvtxt
            // 
            this.cvtxt.Location = new System.Drawing.Point(16, 195);
            this.cvtxt.Name = "cvtxt";
            this.cvtxt.Size = new System.Drawing.Size(211, 57);
            this.cvtxt.TabIndex = 74;
            this.cvtxt.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(676, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 30);
            this.textBox1.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "Crisis ID :";
            // 
            // uidtxt
            // 
            this.uidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidtxt.Location = new System.Drawing.Point(673, 185);
            this.uidtxt.Name = "uidtxt";
            this.uidtxt.Size = new System.Drawing.Size(185, 30);
            this.uidtxt.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(579, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 67;
            this.label14.Text = "User ID :";
            // 
            // ob
            // 
            this.ob.AutoSize = true;
            this.ob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ob.Location = new System.Drawing.Point(379, 212);
            this.ob.Name = "ob";
            this.ob.Size = new System.Drawing.Size(75, 22);
            this.ob.TabIndex = 66;
            this.ob.Text = "Others";
            this.ob.UseVisualStyleBackColor = true;
            // 
            // medi
            // 
            this.medi.AutoSize = true;
            this.medi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medi.Location = new System.Drawing.Point(275, 212);
            this.medi.Name = "medi";
            this.medi.Size = new System.Drawing.Size(89, 22);
            this.medi.TabIndex = 65;
            this.medi.Text = "Medicine";
            this.medi.UseVisualStyleBackColor = true;
            // 
            // mb
            // 
            this.mb.AutoSize = true;
            this.mb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb.Location = new System.Drawing.Point(458, 171);
            this.mb.Name = "mb";
            this.mb.Size = new System.Drawing.Size(75, 22);
            this.mb.TabIndex = 64;
            this.mb.Text = "Money";
            this.mb.UseVisualStyleBackColor = true;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(379, 171);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(73, 22);
            this.cb.TabIndex = 63;
            this.cb.Text = "Cloths";
            this.cb.UseVisualStyleBackColor = true;
            // 
            // food
            // 
            this.food.AutoSize = true;
            this.food.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food.Location = new System.Drawing.Point(275, 171);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(65, 22);
            this.food.TabIndex = 62;
            this.food.Text = "Food";
            this.food.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "Request Items :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 25);
            this.label13.TabIndex = 60;
            this.label13.Text = "Tell Us Your Need :";
            // 
            // ltxt
            // 
            this.ltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt.Location = new System.Drawing.Point(676, 239);
            this.ltxt.Name = "ltxt";
            this.ltxt.Size = new System.Drawing.Size(185, 30);
            this.ltxt.TabIndex = 57;
            this.ltxt.TextChanged += new System.EventHandler(this.ltxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "User Name : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.Teal;
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clrbtn.Location = new System.Drawing.Point(742, 330);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(104, 40);
            this.clrbtn.TabIndex = 53;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(229)))), ((int)(((byte)(194)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 38);
            this.label6.TabIndex = 32;
            this.label6.Text = "Requested Application :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(176)))), ((int)(((byte)(189)))));
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.stxt);
            this.panel3.Location = new System.Drawing.Point(0, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 71);
            this.panel3.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(18, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = "(Search by Request code )";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(699, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 52;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stxt
            // 
            this.stxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxt.Location = new System.Drawing.Point(22, 32);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(645, 30);
            this.stxt.TabIndex = 42;
            // 
            // subdbtn
            // 
            this.subdbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.subdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subdbtn.Location = new System.Drawing.Point(597, 330);
            this.subdbtn.Name = "subdbtn";
            this.subdbtn.Size = new System.Drawing.Size(109, 40);
            this.subdbtn.TabIndex = 48;
            this.subdbtn.Text = "Submit";
            this.subdbtn.UseVisualStyleBackColor = false;
            this.subdbtn.Click += new System.EventHandler(this.subdbtn_Click);
            // 
            // scombo
            // 
            this.scombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scombo.FormattingEnabled = true;
            this.scombo.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected",
            "Processing",
            "Delivered"});
            this.scombo.Location = new System.Drawing.Point(274, 330);
            this.scombo.Name = "scombo";
            this.scombo.Size = new System.Drawing.Size(197, 30);
            this.scombo.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Request Status :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 293);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 93);
            this.richTextBox1.TabIndex = 45;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Location :";
            // 
            // unametxt
            // 
            this.unametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametxt.Location = new System.Drawing.Point(676, 84);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(185, 30);
            this.unametxt.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Crisis Event Name :";
            // 
            // codetxt
            // 
            this.codetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(16, 132);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(197, 30);
            this.codetxt.TabIndex = 34;
            this.codetxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Request Code :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(176)))), ((int)(((byte)(189)))));
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1322, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Admin Panel>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Times of Crisis ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(229, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 46);
            this.label11.TabIndex = 6;
            this.label11.Text = "Hope in";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(139)))));
            this.label12.Location = new System.Drawing.Point(23, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 46);
            this.label12.TabIndex = 5;
            this.label12.Text = "HelpBridge :";
            // 
            // hbtn
            // 
            this.hbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbtn.Location = new System.Drawing.Point(119, 578);
            this.hbtn.Name = "hbtn";
            this.hbtn.Size = new System.Drawing.Size(133, 40);
            this.hbtn.TabIndex = 8;
            this.hbtn.Text = "Home";
            this.hbtn.UseVisualStyleBackColor = false;
            this.hbtn.Click += new System.EventHandler(this.hbtn_Click);
            // 
            // Vbtn
            // 
            this.Vbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Vbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vbtn.Location = new System.Drawing.Point(119, 515);
            this.Vbtn.Name = "Vbtn";
            this.Vbtn.Size = new System.Drawing.Size(133, 43);
            this.Vbtn.TabIndex = 9;
            this.Vbtn.Text = "Back";
            this.Vbtn.UseVisualStyleBackColor = false;
            this.Vbtn.Click += new System.EventHandler(this.Vbtn_Click);
            // 
            // ebtn
            // 
            this.ebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebtn.Location = new System.Drawing.Point(119, 639);
            this.ebtn.Name = "ebtn";
            this.ebtn.Size = new System.Drawing.Size(133, 34);
            this.ebtn.TabIndex = 11;
            this.ebtn.Text = "Exit";
            this.ebtn.UseVisualStyleBackColor = false;
            this.ebtn.Click += new System.EventHandler(this.ebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HelpBridgeProject.Properties.Resources.apply1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 235);
            this.panel2.TabIndex = 0;
            // 
            // AdminApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1320, 740);
            this.Controls.Add(this.ebtn);
            this.Controls.Add(this.Vbtn);
            this.Controls.Add(this.hbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminApplication";
            this.Text = "AdminApplication";
            this.Load += new System.EventHandler(this.AdminApplication_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subdbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button hbtn;
        private System.Windows.Forms.Button Vbtn;
        private System.Windows.Forms.Button ebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ltxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ob;
        private System.Windows.Forms.CheckBox medi;
        private System.Windows.Forms.CheckBox mb;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.CheckBox food;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uidtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox scombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox cvtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}