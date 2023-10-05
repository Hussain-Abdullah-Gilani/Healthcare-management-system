namespace Semester_Project
{
    partial class Payment
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
            this.DGVPayments = new System.Windows.Forms.DataGridView();
            this.lPayments = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // pPayments
            // 
            this.pPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pPayments.Controls.Add(this.DGVPayments);
            this.pPayments.Controls.Add(this.lPayments);
            this.pPayments.Location = new System.Drawing.Point(12, 12);
            this.pPayments.Name = "pPayments";
            this.pPayments.Size = new System.Drawing.Size(620, 513);
            this.pPayments.TabIndex = 0;
            // 
            // DGVPayments
            // 
            this.DGVPayments.AllowUserToAddRows = false;
            this.DGVPayments.AllowUserToDeleteRows = false;
            this.DGVPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tName,
            this.payAmount,
            this.DueDate,
            this.PayStatus});
            this.DGVPayments.Location = new System.Drawing.Point(15, 54);
            this.DGVPayments.Name = "DGVPayments";
            this.DGVPayments.ReadOnly = true;
            this.DGVPayments.Size = new System.Drawing.Size(590, 444);
            this.DGVPayments.TabIndex = 3;
            // 
            // lPayments
            // 
            this.lPayments.AutoSize = true;
            this.lPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lPayments.Location = new System.Drawing.Point(11, 19);
            this.lPayments.Name = "lPayments";
            this.lPayments.Size = new System.Drawing.Size(87, 20);
            this.lPayments.TabIndex = 2;
            this.lPayments.Text = "Payments";
            // 
            // tName
            // 
            this.tName.HeaderText = "Test Name";
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Width = 137;
            // 
            // payAmount
            // 
            this.payAmount.HeaderText = "Payment Amount";
            this.payAmount.Name = "payAmount";
            this.payAmount.ReadOnly = true;
            this.payAmount.Width = 137;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 137;
            // 
            // PayStatus
            // 
            this.PayStatus.HeaderText = "Payment Status";
            this.PayStatus.Name = "PayStatus";
            this.PayStatus.ReadOnly = true;
            this.PayStatus.Width = 136;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(645, 537);
            this.Controls.Add(this.pPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.VisibleChanged += new System.EventHandler(this.Payment_VisibleChanged);
            this.pPayments.ResumeLayout(false);
            this.pPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPayments;
        private System.Windows.Forms.DataGridView DGVPayments;
        private System.Windows.Forms.Label lPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn payAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayStatus;
    }
}