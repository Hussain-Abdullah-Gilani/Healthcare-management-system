namespace Semester_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pLogin = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.lLForgot = new System.Windows.Forms.LinkLabel();
            this.bLogin = new System.Windows.Forms.Button();
            this.tBPassword = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBEmail = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pLogin.Controls.Add(this.bClose);
            this.pLogin.Controls.Add(this.lLForgot);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.tBPassword);
            this.pLogin.Controls.Add(this.tBEmail);
            this.pLogin.Controls.Add(this.pBLogo);
            this.pLogin.Location = new System.Drawing.Point(29, 12);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(305, 523);
            this.pLogin.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(285, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(17, 25);
            this.bClose.TabIndex = 14;
            this.bClose.Text = "X";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lLForgot
            // 
            this.lLForgot.AutoSize = true;
            this.lLForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lLForgot.Location = new System.Drawing.Point(106, 235);
            this.lLForgot.Name = "lLForgot";
            this.lLForgot.Size = new System.Drawing.Size(92, 13);
            this.lLForgot.TabIndex = 4;
            this.lLForgot.TabStop = true;
            this.lLForgot.Text = "Forgot Password?";
            // 
            // bLogin
            // 
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLogin.Location = new System.Drawing.Point(92, 284);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(120, 33);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tBPassword
            // 
            this.tBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBPassword.Location = new System.Drawing.Point(74, 192);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(156, 20);
            this.tBPassword.TabIndex = 2;
            this.tBPassword.UseSystemPasswordChar = true;
            this.tBPassword.WaterMark = "Password";
            this.tBPassword.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBEmail
            // 
            this.tBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBEmail.Location = new System.Drawing.Point(74, 150);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(156, 20);
            this.tBEmail.TabIndex = 1;
            this.tBEmail.WaterMark = "Email";
            this.tBEmail.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBEmail.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // pBLogo
            // 
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.Location = new System.Drawing.Point(92, 21);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(120, 60);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(363, 547);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private ChreneLib.Controls.TextBoxes.CTextBox tBEmail;
        private System.Windows.Forms.PictureBox pBLogo;
        private ChreneLib.Controls.TextBoxes.CTextBox tBPassword;
        private System.Windows.Forms.LinkLabel lLForgot;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bClose;
    }
}