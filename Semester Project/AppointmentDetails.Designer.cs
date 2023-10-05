namespace Semester_Project
{
    partial class AppointmentDetails
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
            this.pPayments = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.DGVPayments = new System.Windows.Forms.DataGridView();
            this.lPayments = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // pPayments
            // 
            this.pPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pPayments.Controls.Add(this.bReset);
            this.pPayments.Controls.Add(this.DGVPayments);
            this.pPayments.Controls.Add(this.lPayments);
            this.pPayments.Location = new System.Drawing.Point(4, 12);
            this.pPayments.Name = "pPayments";
            this.pPayments.Size = new System.Drawing.Size(635, 513);
            this.pPayments.TabIndex = 1;
            // 
            // bReset
            // 
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bReset.Location = new System.Drawing.Point(15, 462);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(138, 34);
            this.bReset.TabIndex = 62;
            this.bReset.Text = "Cancel Appointment";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // DGVPayments
            // 
            this.DGVPayments.AllowUserToAddRows = false;
            this.DGVPayments.AllowUserToDeleteRows = false;
            this.DGVPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.tName,
            this.payAmount,
            this.DueDate,
            this.Column1,
            this.PayStatus,
            this.Column3,
            this.Column4});
            this.DGVPayments.Location = new System.Drawing.Point(8, 56);
            this.DGVPayments.Name = "DGVPayments";
            this.DGVPayments.ReadOnly = true;
            this.DGVPayments.Size = new System.Drawing.Size(614, 390);
            this.DGVPayments.TabIndex = 3;
            this.DGVPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPayments_CellClick);
            // 
            // lPayments
            // 
            this.lPayments.AutoSize = true;
            this.lPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lPayments.Location = new System.Drawing.Point(11, 19);
            this.lPayments.Name = "lPayments";
            this.lPayments.Size = new System.Drawing.Size(172, 20);
            this.lPayments.TabIndex = 2;
            this.lPayments.Text = "Appointment Details";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Appointment #";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 80;
            // 
            // tName
            // 
            this.tName.HeaderText = "Doctor Name";
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Width = 90;
            // 
            // payAmount
            // 
            this.payAmount.HeaderText = "Speciality";
            this.payAmount.Name = "payAmount";
            this.payAmount.ReadOnly = true;
            this.payAmount.Width = 90;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Appointment Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time Slot";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // PayStatus
            // 
            this.PayStatus.HeaderText = "Payment Status";
            this.PayStatus.Name = "PayStatus";
            this.PayStatus.ReadOnly = true;
            this.PayStatus.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Appointment Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "At Home";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // AppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(644, 537);
            this.Controls.Add(this.pPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentDetails";
            this.Text = "AppointmentDetails";
            this.Load += new System.EventHandler(this.AppointmentDetails_Load);
            this.VisibleChanged += new System.EventHandler(this.AppointmentDetails_VisibleChanged);
            this.pPayments.ResumeLayout(false);
            this.pPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPayments;
        private System.Windows.Forms.DataGridView DGVPayments;
        private System.Windows.Forms.Label lPayments;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn payAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}