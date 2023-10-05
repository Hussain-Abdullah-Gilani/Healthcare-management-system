namespace Semester_Project
{
    partial class Search_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Records));
            this.pPersonalInfo = new System.Windows.Forms.Panel();
            this.cBGender = new System.Windows.Forms.ComboBox();
            this.cBAge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTBCNIC = new System.Windows.Forms.MaskedTextBox();
            this.mTBFCNIC = new System.Windows.Forms.MaskedTextBox();
            this.pAccInfo = new System.Windows.Forms.Panel();
            this.DGVPatients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPatients = new System.Windows.Forms.Label();
            this.pBPatientRec = new System.Windows.Forms.PictureBox();
            this.lPatientRec = new System.Windows.Forms.Label();
            this.cBSearchBy = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tBSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.cTextBox1 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBNewPassword = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBEmail = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBPassword = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBLName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBFName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBFPhone = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBPhone = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.tBFatherName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pPersonalInfo.SuspendLayout();
            this.pAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPatientRec)).BeginInit();
            this.SuspendLayout();
            // 
            // pPersonalInfo
            // 
            this.pPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pPersonalInfo.Controls.Add(this.tBLName);
            this.pPersonalInfo.Controls.Add(this.cBGender);
            this.pPersonalInfo.Controls.Add(this.tBFName);
            this.pPersonalInfo.Controls.Add(this.tBFPhone);
            this.pPersonalInfo.Controls.Add(this.cBAge);
            this.pPersonalInfo.Controls.Add(this.label2);
            this.pPersonalInfo.Controls.Add(this.tBPhone);
            this.pPersonalInfo.Controls.Add(this.tBFatherName);
            this.pPersonalInfo.Controls.Add(this.label3);
            this.pPersonalInfo.Controls.Add(this.mTBCNIC);
            this.pPersonalInfo.Controls.Add(this.mTBFCNIC);
            this.pPersonalInfo.Location = new System.Drawing.Point(12, 391);
            this.pPersonalInfo.Name = "pPersonalInfo";
            this.pPersonalInfo.Size = new System.Drawing.Size(299, 211);
            this.pPersonalInfo.TabIndex = 8;
            // 
            // cBGender
            // 
            this.cBGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBGender.FormattingEnabled = true;
            this.cBGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cBGender.Location = new System.Drawing.Point(57, 84);
            this.cBGender.Name = "cBGender";
            this.cBGender.Size = new System.Drawing.Size(60, 21);
            this.cBGender.TabIndex = 3;
            this.cBGender.Text = "Gender";
            this.cBGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBGender_KeyPress);
            // 
            // cBAge
            // 
            this.cBAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBAge.FormattingEnabled = true;
            this.cBAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cBAge.Location = new System.Drawing.Point(3, 84);
            this.cBAge.Name = "cBAge";
            this.cBAge.Size = new System.Drawing.Size(48, 21);
            this.cBAge.TabIndex = 2;
            this.cBAge.Text = "Age";
            this.cBAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBAge_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(3, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient CNIC or B-Form #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(176, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Guardian CNIC";
            // 
            // mTBCNIC
            // 
            this.mTBCNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.mTBCNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTBCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBCNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mTBCNIC.Location = new System.Drawing.Point(6, 184);
            this.mTBCNIC.Mask = "00000-00000000";
            this.mTBCNIC.Name = "mTBCNIC";
            this.mTBCNIC.Size = new System.Drawing.Size(128, 19);
            this.mTBCNIC.TabIndex = 7;
            // 
            // mTBFCNIC
            // 
            this.mTBFCNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.mTBFCNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTBFCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBFCNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mTBFCNIC.Location = new System.Drawing.Point(158, 184);
            this.mTBFCNIC.Mask = "00000-00000000";
            this.mTBFCNIC.Name = "mTBFCNIC";
            this.mTBFCNIC.Size = new System.Drawing.Size(128, 19);
            this.mTBFCNIC.TabIndex = 8;
            // 
            // pAccInfo
            // 
            this.pAccInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pAccInfo.Controls.Add(this.checkBox1);
            this.pAccInfo.Controls.Add(this.cTextBox1);
            this.pAccInfo.Controls.Add(this.tBNewPassword);
            this.pAccInfo.Controls.Add(this.tBEmail);
            this.pAccInfo.Controls.Add(this.tBPassword);
            this.pAccInfo.Location = new System.Drawing.Point(317, 391);
            this.pAccInfo.Name = "pAccInfo";
            this.pAccInfo.Size = new System.Drawing.Size(221, 211);
            this.pAccInfo.TabIndex = 10;
            // 
            // DGVPatients
            // 
            this.DGVPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DGVPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column10,
            this.Column11,
            this.Column6,
            this.Column7,
            this.Column9});
            this.DGVPatients.Location = new System.Drawing.Point(9, 158);
            this.DGVPatients.Name = "DGVPatients";
            this.DGVPatients.Size = new System.Drawing.Size(526, 225);
            this.DGVPatients.TabIndex = 34;
            this.DGVPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatients_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Patient Name";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone Number";
            this.Column5.Name = "Column5";
            this.Column5.Width = 103;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Patient Cnic";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Email";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Password";
            this.Column11.Name = "Column11";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Guardian Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Guardian Num";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Guardian CNIC";
            this.Column9.MaxInputLength = 1000000000;
            this.Column9.Name = "Column9";
            // 
            // lPatients
            // 
            this.lPatients.AutoSize = true;
            this.lPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lPatients.Location = new System.Drawing.Point(8, 135);
            this.lPatients.Name = "lPatients";
            this.lPatients.Size = new System.Drawing.Size(80, 20);
            this.lPatients.TabIndex = 33;
            this.lPatients.Text = "Patients:";
            // 
            // pBPatientRec
            // 
            this.pBPatientRec.Image = ((System.Drawing.Image)(resources.GetObject("pBPatientRec.Image")));
            this.pBPatientRec.Location = new System.Drawing.Point(12, 6);
            this.pBPatientRec.Name = "pBPatientRec";
            this.pBPatientRec.Size = new System.Drawing.Size(56, 41);
            this.pBPatientRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPatientRec.TabIndex = 32;
            this.pBPatientRec.TabStop = false;
            // 
            // lPatientRec
            // 
            this.lPatientRec.AutoSize = true;
            this.lPatientRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPatientRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lPatientRec.Location = new System.Drawing.Point(74, 18);
            this.lPatientRec.Name = "lPatientRec";
            this.lPatientRec.Size = new System.Drawing.Size(138, 20);
            this.lPatientRec.TabIndex = 24;
            this.lPatientRec.Text = "Patient Records";
            // 
            // cBSearchBy
            // 
            this.cBSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cBSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBSearchBy.FormattingEnabled = true;
            this.cBSearchBy.Items.AddRange(new object[] {
            "Name",
            "Age",
            "CNIC"});
            this.cBSearchBy.Location = new System.Drawing.Point(231, 60);
            this.cBSearchBy.Name = "cBSearchBy";
            this.cBSearchBy.Size = new System.Drawing.Size(80, 21);
            this.cBSearchBy.TabIndex = 35;
            this.cBSearchBy.Text = "Search By....";
            this.cBSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBSearchBy_KeyPress);
            // 
            // bSearch
            // 
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bSearch.Location = new System.Drawing.Point(317, 58);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 36;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bUpdate.Location = new System.Drawing.Point(12, 100);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 37;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.bDelete.Location = new System.Drawing.Point(108, 100);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 38;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBox1.Location = new System.Drawing.Point(28, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tBSearch
            // 
            this.tBSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBSearch.Location = new System.Drawing.Point(12, 66);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(213, 15);
            this.tBSearch.TabIndex = 25;
            this.tBSearch.WaterMark = "Search For Patients";
            this.tBSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBSearch.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cTextBox1.Enabled = false;
            this.cTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cTextBox1.Location = new System.Drawing.Point(28, 155);
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Size = new System.Drawing.Size(170, 19);
            this.cTextBox1.TabIndex = 13;
            this.cTextBox1.UseSystemPasswordChar = true;
            this.cTextBox1.WaterMark = "Confirm Password";
            this.cTextBox1.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox1.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBNewPassword
            // 
            this.tBNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBNewPassword.Enabled = false;
            this.tBNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBNewPassword.Location = new System.Drawing.Point(28, 120);
            this.tBNewPassword.Name = "tBNewPassword";
            this.tBNewPassword.Size = new System.Drawing.Size(170, 19);
            this.tBNewPassword.TabIndex = 11;
            this.tBNewPassword.UseSystemPasswordChar = true;
            this.tBNewPassword.WaterMark = "New Password";
            this.tBNewPassword.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBNewPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNewPassword.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBEmail
            // 
            this.tBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBEmail.Enabled = false;
            this.tBEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBEmail.Location = new System.Drawing.Point(28, 48);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(170, 18);
            this.tBEmail.TabIndex = 9;
            this.tBEmail.WaterMark = "Email";
            this.tBEmail.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBEmail.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBPassword
            // 
            this.tBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPassword.Enabled = false;
            this.tBPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBPassword.Location = new System.Drawing.Point(28, 84);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(170, 19);
            this.tBPassword.TabIndex = 10;
            this.tBPassword.WaterMark = "Current Password";
            this.tBPassword.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBLName
            // 
            this.tBLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBLName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBLName.Location = new System.Drawing.Point(140, 14);
            this.tBLName.Name = "tBLName";
            this.tBLName.Size = new System.Drawing.Size(128, 18);
            this.tBLName.TabIndex = 1;
            this.tBLName.WaterMark = "Last Name";
            this.tBLName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBLName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBFName
            // 
            this.tBFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBFName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBFName.Location = new System.Drawing.Point(3, 14);
            this.tBFName.Name = "tBFName";
            this.tBFName.Size = new System.Drawing.Size(131, 18);
            this.tBFName.TabIndex = 0;
            this.tBFName.WaterMark = "First Name";
            this.tBFName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBFName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBFPhone
            // 
            this.tBFPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBFPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBFPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBFPhone.Location = new System.Drawing.Point(140, 120);
            this.tBFPhone.Name = "tBFPhone";
            this.tBFPhone.Size = new System.Drawing.Size(128, 19);
            this.tBFPhone.TabIndex = 6;
            this.tBFPhone.WaterMark = "Guardian Phone Number";
            this.tBFPhone.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBFPhone.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFPhone.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBPhone
            // 
            this.tBPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBPhone.Location = new System.Drawing.Point(3, 47);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(131, 19);
            this.tBPhone.TabIndex = 4;
            this.tBPhone.WaterMark = "Phone Number";
            this.tBPhone.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBPhone.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPhone.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // tBFatherName
            // 
            this.tBFatherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tBFatherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBFatherName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tBFatherName.Location = new System.Drawing.Point(3, 120);
            this.tBFatherName.Name = "tBFatherName";
            this.tBFatherName.Size = new System.Drawing.Size(131, 19);
            this.tBFatherName.TabIndex = 5;
            this.tBFatherName.WaterMark = "Guardian Name";
            this.tBFatherName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.tBFatherName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFatherName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Search_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(547, 614);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cBSearchBy);
            this.Controls.Add(this.DGVPatients);
            this.Controls.Add(this.lPatients);
            this.Controls.Add(this.pBPatientRec);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.lPatientRec);
            this.Controls.Add(this.pAccInfo);
            this.Controls.Add(this.pPersonalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Records";
            this.pPersonalInfo.ResumeLayout(false);
            this.pPersonalInfo.PerformLayout();
            this.pAccInfo.ResumeLayout(false);
            this.pAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPatientRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pPersonalInfo;
        private ChreneLib.Controls.TextBoxes.CTextBox tBLName;
        private System.Windows.Forms.ComboBox cBGender;
        private ChreneLib.Controls.TextBoxes.CTextBox tBFName;
        private ChreneLib.Controls.TextBoxes.CTextBox tBFPhone;
        private System.Windows.Forms.ComboBox cBAge;
        private System.Windows.Forms.Label label2;
        private ChreneLib.Controls.TextBoxes.CTextBox tBPhone;
        private ChreneLib.Controls.TextBoxes.CTextBox tBFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTBCNIC;
        private System.Windows.Forms.MaskedTextBox mTBFCNIC;
        private System.Windows.Forms.Panel pAccInfo;
        private ChreneLib.Controls.TextBoxes.CTextBox tBNewPassword;
        private ChreneLib.Controls.TextBoxes.CTextBox tBEmail;
        private ChreneLib.Controls.TextBoxes.CTextBox tBPassword;
        private System.Windows.Forms.DataGridView DGVPatients;
        private System.Windows.Forms.Label lPatients;
        private System.Windows.Forms.PictureBox pBPatientRec;
        private ChreneLib.Controls.TextBoxes.CTextBox tBSearch;
        private System.Windows.Forms.Label lPatientRec;
        private System.Windows.Forms.ComboBox cBSearchBy;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private ChreneLib.Controls.TextBoxes.CTextBox cTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}