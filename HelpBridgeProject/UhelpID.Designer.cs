namespace HelpBridgeProject
{
    partial class UhelpID
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
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.subdbtn = new System.Windows.Forms.Button();
            this.stxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 130;
            this.label1.Text = "(Search your email to see user details)";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backbtn.Location = new System.Drawing.Point(643, 282);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(109, 40);
            this.Backbtn.TabIndex = 129;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // subdbtn
            // 
            this.subdbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.subdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subdbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subdbtn.Location = new System.Drawing.Point(549, 55);
            this.subdbtn.Name = "subdbtn";
            this.subdbtn.Size = new System.Drawing.Size(109, 40);
            this.subdbtn.TabIndex = 128;
            this.subdbtn.Text = "Search";
            this.subdbtn.UseVisualStyleBackColor = false;
            this.subdbtn.Click += new System.EventHandler(this.subdbtn_Click);
            // 
            // stxt
            // 
            this.stxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxt.Location = new System.Drawing.Point(37, 58);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(475, 30);
            this.stxt.TabIndex = 127;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 89);
            this.dataGridView1.TabIndex = 126;
            // 
            // UhelpID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.subdbtn);
            this.Controls.Add(this.stxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UhelpID";
            this.Text = "UhelpID";
            this.Load += new System.EventHandler(this.UhelpID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button subdbtn;
        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}