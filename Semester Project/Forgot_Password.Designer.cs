namespace Semester_Project
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.pLogin = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.tBEmail = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pLogin.Controls.Add(this.bClose);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.tBEmail);
            this.pLogin.Controls.Add(this.pBLogo);
            this.pLogin.Location = new System.Drawing.Point(10, 10);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(240, 277);
            this.pLogin.TabIndex = 1;
            // 
            // bClose
            // 
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.Location = new System.Drawing.Point(3, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(26, 38);
            this.bClose.TabIndex = 14;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bLogin
            // 
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLogin.Location = new System.Drawing.Point(62, 201);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(120, 33);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Next";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // pBLogo
            // 
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.Location = new System.Drawing.Point(0, 27);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(240, 90);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // tBEmail
            // 
            this.tBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBEmail.Location = new System.Drawing.Point(45, 144);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(156, 20);
            this.tBEmail.TabIndex = 1;
            this.tBEmail.WaterMark = "Enter Your Email";
            this.tBEmail.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBEmail.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(262, 299);
            this.Controls.Add(this.pLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bLogin;
        private ChreneLib.Controls.TextBoxes.CTextBox tBEmail;
        private System.Windows.Forms.PictureBox pBLogo;
    }
}