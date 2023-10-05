namespace Semester_Project
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.pReports = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.pBSearch = new System.Windows.Forms.PictureBox();
            this.DGVReports = new System.Windows.Forms.DataGridView();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lReports = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pReports
            // 
            this.pReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pReports.Controls.Add(this.button1);
            this.pReports.Controls.Add(this.bReset);
            this.pReports.Controls.Add(this.bSearch);
            this.pReports.Controls.Add(this.pBSearch);
            this.pReports.Controls.Add(this.tBSearch);
            this.pReports.Controls.Add(this.DGVReports);
            this.pReports.Controls.Add(this.lReports);
            this.pReports.Location = new System.Drawing.Point(12, 12);
            this.pReports.Name = "pReports";
            this.pReports.Size = new System.Drawing.Size(621, 513);
            this.pReports.TabIndex = 0;
            this.pReports.Paint += new System.Windows.Forms.PaintEventHandler(this.pReports_Paint);
            // 
            // bReset
            // 
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bReset.Location = new System.Drawing.Point(530, 19);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 59;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(449, 19);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 58;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // pBSearch
            // 
            this.pBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pBSearch.Image = ((System.Drawing.Image)(resources.GetObject("pBSearch.Image")));
            this.pBSearch.Location = new System.Drawing.Point(182, 19);
            this.pBSearch.Name = "pBSearch";
            this.pBSearch.Size = new System.Drawing.Size(22, 20);
            this.pBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSearch.TabIndex = 3;
            this.pBSearch.TabStop = false;
            // 
            // DGVReports
            // 
            this.DGVReports.AllowUserToAddRows = false;
            this.DGVReports.AllowUserToDeleteRows = false;
            this.DGVReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestName,
            this.TestResult});
            this.DGVReports.Location = new System.Drawing.Point(15, 54);
            this.DGVReports.Name = "DGVReports";
            this.DGVReports.ReadOnly = true;
            this.DGVReports.Size = new System.Drawing.Size(590, 386);
            this.DGVReports.TabIndex = 1;
            this.DGVReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVReports_CellClick);
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.Width = 274;
            // 
            // TestResult
            // 
            this.TestResult.HeaderText = "Test Result";
            this.TestResult.Name = "TestResult";
            this.TestResult.ReadOnly = true;
            this.TestResult.Width = 273;
            // 
            // lReports
            // 
            this.lReports.AutoSize = true;
            this.lReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lReports.Location = new System.Drawing.Point(11, 19);
            this.lReports.Name = "lReports";
            this.lReports.Size = new System.Drawing.Size(136, 20);
            this.lReports.TabIndex = 0;
            this.lReports.Text = "Recent Reports";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.button1.Location = new System.Drawing.Point(15, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 60;
            this.button1.Text = "Generate Report PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(210, 22);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(213, 15);
            this.tBSearch.TabIndex = 2;
            this.tBSearch.WaterMark = "Search for reports....";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(645, 537);
            this.Controls.Add(this.pReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.VisibleChanged += new System.EventHandler(this.Reports_VisibleChanged);
            this.pReports.ResumeLayout(false);
            this.pReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pReports;
        private System.Windows.Forms.Label lReports;
        private System.Windows.Forms.DataGridView DGVReports;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.PictureBox pBSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestResult;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button button1;
    }
}