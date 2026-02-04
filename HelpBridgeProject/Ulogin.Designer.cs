namespace HelpBridgeProject
{
    partial class Ulogin
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
            this.label6 = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.logbtn = new System.Windows.Forms.Button();
            this.passtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.passbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email :";
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Blue;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerbtn.Location = new System.Drawing.Point(324, 385);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(116, 39);
            this.registerbtn.TabIndex = 33;
            this.registerbtn.Text = "Sign Up";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(170, 385);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(116, 39);
            this.logbtn.TabIndex = 32;
            this.logbtn.Text = "Log In";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // passtext
            // 
            this.passtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(139, 296);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(334, 34);
            this.passtext.TabIndex = 31;
            // 
            // emailtext
            // 
            this.emailtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtext.Location = new System.Drawing.Point(139, 183);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(334, 34);
            this.emailtext.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(244, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 46);
            this.label4.TabIndex = 28;
            this.label4.Text = "Log in";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(12, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 39);
            this.button3.TabIndex = 35;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passbtn
            // 
            this.passbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passbtn.Location = new System.Drawing.Point(430, 487);
            this.passbtn.Name = "passbtn";
            this.passbtn.Size = new System.Drawing.Size(176, 35);
            this.passbtn.TabIndex = 41;
            this.passbtn.Text = "Password Reset";
            this.passbtn.UseVisualStyleBackColor = false;
            this.passbtn.Click += new System.EventHandler(this.passbtn_Click);
            // 
            // Ulogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelpBridgeProject.Properties.Resources.ulog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 553);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "Ulogin";
            this.Text = "Ulogin";
            this.Load += new System.EventHandler(this.Ulogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button passbtn;
    }
}