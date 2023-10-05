namespace Semester_Project
{
    partial class Doctor_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Records));
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.cBSearchBy = new System.Windows.Forms.ComboBox();
            this.DGVDoctors = new System.Windows.Forms.DataGridView();
            this.lAvailDocs = new System.Windows.Forms.Label();
            this.pBDoctor = new System.Windows.Forms.PictureBox();
            this.lDocRec = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.tBSpecialty = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBAppointmentFee = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoctor)).BeginInit();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDelete
            // 
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bDelete.Location = new System.Drawing.Point(108, 115);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 49;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bUpdate.Location = new System.Drawing.Point(12, 115);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 48;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(375, 73);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 47;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cBSearchBy
            // 
            this.cBSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBSearchBy.FormattingEnabled = true;
            this.cBSearchBy.Items.AddRange(new object[] {
            "Name",
            "Speciality",
            "Salary"});
            this.cBSearchBy.Location = new System.Drawing.Point(273, 73);
            this.cBSearchBy.Name = "cBSearchBy";
            this.cBSearchBy.Size = new System.Drawing.Size(96, 21);
            this.cBSearchBy.TabIndex = 46;
            this.cBSearchBy.Text = "Search By....";
            this.cBSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBSearchBy_KeyPress);
            // 
            // DGVDoctors
            // 
            this.DGVDoctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGVDoctors.Location = new System.Drawing.Point(12, 174);
            this.DGVDoctors.Name = "DGVDoctors";
            this.DGVDoctors.Size = new System.Drawing.Size(541, 188);
            this.DGVDoctors.TabIndex = 45;
            // 
            // lAvailDocs
            // 
            this.lAvailDocs.AutoSize = true;
            this.lAvailDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAvailDocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lAvailDocs.Location = new System.Drawing.Point(8, 151);
            this.lAvailDocs.Name = "lAvailDocs";
            this.lAvailDocs.Size = new System.Drawing.Size(77, 20);
            this.lAvailDocs.TabIndex = 44;
            this.lAvailDocs.Text = "Doctors:";
            // 
            // pBDoctor
            // 
            this.pBDoctor.Image = ((System.Drawing.Image)(resources.GetObject("pBDoctor.Image")));
            this.pBDoctor.Location = new System.Drawing.Point(12, 12);
            this.pBDoctor.Name = "pBDoctor";
            this.pBDoctor.Size = new System.Drawing.Size(56, 41);
            this.pBDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDoctor.TabIndex = 43;
            this.pBDoctor.TabStop = false;
            // 
            // lDocRec
            // 
            this.lDocRec.AutoSize = true;
            this.lDocRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDocRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lDocRec.Location = new System.Drawing.Point(74, 24);
            this.lDocRec.Name = "lDocRec";
            this.lDocRec.Size = new System.Drawing.Size(135, 20);
            this.lDocRec.TabIndex = 41;
            this.lDocRec.Text = "Doctor Records";
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pInfo.Controls.Add(this.tBSpecialty);
            this.pInfo.Controls.Add(this.tBAppointmentFee);
            this.pInfo.Controls.Add(this.tBName);
            this.pInfo.Location = new System.Drawing.Point(12, 368);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(541, 122);
            this.pInfo.TabIndex = 39;
            // 
            // tBSpecialty
            // 
            this.tBSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSpecialty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSpecialty.Location = new System.Drawing.Point(219, 17);
            this.tBSpecialty.Name = "tBSpecialty";
            this.tBSpecialty.Size = new System.Drawing.Size(213, 15);
            this.tBSpecialty.TabIndex = 22;
            this.tBSpecialty.WaterMark = "Specialities";
            this.tBSpecialty.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSpecialty.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSpecialty.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBAppointmentFee
            // 
            this.tBAppointmentFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBAppointmentFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBAppointmentFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAppointmentFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBAppointmentFee.Location = new System.Drawing.Point(14, 47);
            this.tBAppointmentFee.Name = "tBAppointmentFee";
            this.tBAppointmentFee.Size = new System.Drawing.Size(103, 15);
            this.tBAppointmentFee.TabIndex = 21;
            this.tBAppointmentFee.WaterMark = "Appointment Fee";
            this.tBAppointmentFee.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBAppointmentFee.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAppointmentFee.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBName
            // 
            this.tBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBName.Location = new System.Drawing.Point(14, 14);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(170, 18);
            this.tBName.TabIndex = 0;
            this.tBName.WaterMark = "Doctor Name";
            this.tBName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(12, 76);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(246, 15);
            this.tBSearch.TabIndex = 42;
            this.tBSearch.WaterMark = "Search For Doctors...";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Doctor Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 165;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Speciality";
            this.Column2.Name = "Column2";
            this.Column2.Width = 165;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fee";
            this.Column3.Name = "Column3";
            this.Column3.Width = 165;
            // 
            // Doctor_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(565, 502);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cBSearchBy);
            this.Controls.Add(this.DGVDoctors);
            this.Controls.Add(this.lAvailDocs);
            this.Controls.Add(this.pBDoctor);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.lDocRec);
            this.Controls.Add(this.pInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor_Records";
            this.Text = "Doctor_Records";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDoctor)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cBSearchBy;
        private System.Windows.Forms.DataGridView DGVDoctors;
        private System.Windows.Forms.Label lAvailDocs;
        private System.Windows.Forms.PictureBox pBDoctor;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.Label lDocRec;
        private System.Windows.Forms.Panel pInfo;
        private ChreneLib.Controls.TextBoxes.CTextBox tBName;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSpecialty;
        private ChreneLib.Controls.TextBoxes.CTextBox tBAppointmentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}