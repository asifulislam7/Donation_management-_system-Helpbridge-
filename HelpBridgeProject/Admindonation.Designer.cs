namespace HelpBridgeProject
{
    partial class Admindonation
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.stxt = new System.Windows.Forms.TextBox();
            this.rbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ltxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cidtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uidtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scombo = new System.Windows.Forms.ComboBox();
            this.doidtxt = new System.Windows.Forms.TextBox();
            this.sbtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.hbtn = new System.Windows.Forms.Button();
            this.ebtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::HelpBridgeProject.Properties.Resources.donate;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.stxt);
            this.panel3.Controls.Add(this.rbtn);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(-4, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 519);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbtn.Location = new System.Drawing.Point(521, 90);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(109, 35);
            this.searchbtn.TabIndex = 41;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.sbttn_Click);
            // 
            // stxt
            // 
            this.stxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxt.Location = new System.Drawing.Point(28, 90);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(475, 30);
            this.stxt.TabIndex = 40;
            // 
            // rbtn
            // 
            this.rbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtn.Location = new System.Drawing.Point(655, 90);
            this.rbtn.Name = "rbtn";
            this.rbtn.Size = new System.Drawing.Size(96, 35);
            this.rbtn.TabIndex = 42;
            this.rbtn.Text = "Refresh";
            this.rbtn.UseVisualStyleBackColor = false;
            this.rbtn.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 42);
            this.label5.TabIndex = 39;
            this.label5.Text = "Donation History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(761, 238);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // unametxt
            // 
            this.unametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametxt.Location = new System.Drawing.Point(178, 71);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(185, 30);
            this.unametxt.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Location :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "User Name : ";
            // 
            // ltxt
            // 
            this.ltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxt.Location = new System.Drawing.Point(178, 261);
            this.ltxt.Name = "ltxt";
            this.ltxt.Size = new System.Drawing.Size(185, 30);
            this.ltxt.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(81, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 78;
            this.label14.Text = "User ID :";
            // 
            // cidtxt
            // 
            this.cidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidtxt.Location = new System.Drawing.Point(175, 207);
            this.cidtxt.Name = "cidtxt";
            this.cidtxt.Size = new System.Drawing.Size(185, 30);
            this.cidtxt.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Crisis ID :";
            // 
            // uidtxt
            // 
            this.uidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidtxt.Location = new System.Drawing.Point(178, 159);
            this.uidtxt.Name = "uidtxt";
            this.uidtxt.Size = new System.Drawing.Size(185, 30);
            this.uidtxt.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 82;
            this.label9.Text = "Donation Items :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "D_ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Donation Status :";
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
            this.scombo.Location = new System.Drawing.Point(47, 463);
            this.scombo.Name = "scombo";
            this.scombo.Size = new System.Drawing.Size(197, 30);
            this.scombo.TabIndex = 89;
            // 
            // doidtxt
            // 
            this.doidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doidtxt.Location = new System.Drawing.Point(178, 113);
            this.doidtxt.Name = "doidtxt";
            this.doidtxt.Size = new System.Drawing.Size(185, 30);
            this.doidtxt.TabIndex = 91;
            // 
            // sbtn
            // 
            this.sbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.sbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sbtn.Location = new System.Drawing.Point(275, 415);
            this.sbtn.Name = "sbtn";
            this.sbtn.Size = new System.Drawing.Size(109, 41);
            this.sbtn.TabIndex = 42;
            this.sbtn.Text = "Submit";
            this.sbtn.UseVisualStyleBackColor = false;
            this.sbtn.Click += new System.EventHandler(this.sbtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(48, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(179, 46);
            this.richTextBox1.TabIndex = 92;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.sbtn);
            this.panel1.Controls.Add(this.doidtxt);
            this.panel1.Controls.Add(this.scombo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.uidtxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cidtxt);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.ltxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.unametxt);
            this.panel1.Location = new System.Drawing.Point(792, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(171)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Controls.Add(this.hbtn);
            this.panel2.Controls.Add(this.ebtn);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 51);
            this.panel2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Admin Panel>>";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(816, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(110, 29);
            this.backbtn.TabIndex = 39;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // hbtn
            // 
            this.hbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.hbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbtn.Location = new System.Drawing.Point(955, 7);
            this.hbtn.Name = "hbtn";
            this.hbtn.Size = new System.Drawing.Size(110, 31);
            this.hbtn.TabIndex = 38;
            this.hbtn.Text = "Home";
            this.hbtn.UseVisualStyleBackColor = false;
            this.hbtn.Click += new System.EventHandler(this.hbtn_Click_1);
            // 
            // ebtn
            // 
            this.ebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebtn.Location = new System.Drawing.Point(1093, 7);
            this.ebtn.Name = "ebtn";
            this.ebtn.Size = new System.Drawing.Size(110, 31);
            this.ebtn.TabIndex = 40;
            this.ebtn.Text = "Exit";
            this.ebtn.UseVisualStyleBackColor = false;
            this.ebtn.Click += new System.EventHandler(this.ebtn_Click);
            // 
            // Admindonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1211, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Admindonation";
            this.Text = "Admindonation";
            this.Load += new System.EventHandler(this.Admindonation_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.Button rbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox unametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ltxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cidtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uidtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox scombo;
        private System.Windows.Forms.TextBox doidtxt;
        private System.Windows.Forms.Button sbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button hbtn;
        private System.Windows.Forms.Button ebtn;
    }
}