using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Semester_Project
{
    public partial class ProfileInfo : Form
    {
        // Hashir
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        int pID;

        public ProfileInfo(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            LoadPersonData();
        }

        private void bEditPers_Click(object sender, EventArgs e)
        {
            if (bEditPers.Text == "Edit")
            {
                tBFName.Enabled = true;
                tBLName.Enabled = true;
                cBAge.Enabled = true;
                tBPhone.Enabled = true;
                tBFatherName.Enabled = true;
                tBFPhone.Enabled = true;

                bEditPers.Text = "Update";
            }
            else
            {
                UpdateData();
                MessageBox.Show("Data Has Been Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tBFName.Enabled = false;
                tBLName.Enabled = false;
                cBAge.Enabled = false;
                tBPhone.Enabled = false;
                tBFatherName.Enabled = false;
                tBFPhone.Enabled = false;

                bEditPers.Text = "Edit";
            }
        }

        private void bEditAcc_Click(object sender, EventArgs e)
        {
            if (bEditAcc.Text == "Edit")
            {
                tBEmail.Enabled = true;
                tBPassword.Enabled = true;
                tBConfirmPass.Enabled = true;

                bEditAcc.Text = "Update";
            }
            else
            {
                UpdateAccData();

                tBEmail.Enabled = false;
                tBPassword.Enabled = false;
                tBConfirmPass.Enabled = false;

                bEditAcc.Text = "Edit";
            }
        }

        private void cBAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadPersonData()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Data
            string sql = "SELECT pName, pAge, pGender, pPhoneNum, pCNIC, pEmail FROM Patient WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                // Divide pName field into First Name & Last Name Format
                // Source: https://www.codeproject.com/Questions/1144522/How-to-split-string-and-pick-a-single-word-in-Csha
                string[] parts = dataReader.GetString(0).Split(' ');
                bool run = true;
                foreach (string part in parts)
                {
                    string[] subParts = part.Split(' ');
                    if (subParts.Length > 0)
                    {
                        if (run)
                        {
                            tBFName.Text = subParts[0];
                            run = false;
                        }
                        else
                        {
                            tBLName.Text += subParts[0] + " ";
                        }
                    }
                }

                cBAge.Text = Convert.ToString(dataReader.GetInt32(1));
                cBGender.Text = dataReader.GetString(2);
                tBPhone.Text = dataReader.GetString(3);
                mTBCNIC.Text = dataReader.GetString(4);
                tBEmail.Text = dataReader.GetString(5);
            }

            dataReader.Close();
            dataReader.Dispose();

            // Load Patient Father Data
            sql = "SELECT pFName, pFPhoneNum, pFCNIC FROM pFather WHERE pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                tBFatherName.Text = dataReader.GetString(0);
                tBFPhone.Text = dataReader.GetString(1);
                mTBFCNIC.Text = dataReader.GetString(2);
            }
        }

        private void UpdateData()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Update Patient Data
            string sql = "UPDATE Patient SET " +
                "pName='" + tBFName.Text + " " + tBLName.Text + "', " +
                "pAge='" + cBAge.Text + "', " +
                "pPhoneNum='" + tBPhone.Text + "' " +
                "WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            // Update Patient Father Data
            sql = "UPDATE pFather SET " +
                "pFName='" + tBFatherName.Text + "', " +
                "pFPhoneNum='" + tBFPhone.Text + "' " +
                "WHERE pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
        }

        private void UpdateAccData()
        {
            if (tBConfirmPass.Text != tBPassword.Text)
            {
                MessageBox.Show("Passwords Do Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tBPassword.Text == "" && tBConfirmPass.Text == "")
            {
                MessageBox.Show("Passwords Cannot be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();

                // Update Patient Data
                string sql = "UPDATE Patient SET " +
                    "pEmail='" + tBEmail.Text + "', " +
                    "pPassword='" + tBPassword.Text + "' " +
                    "WHERE pID='" + pID + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();

                MessageBox.Show("Data Has Been Succesfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Update Patient Data
            string sql = "UPDATE Patient SET pEmail='', pPassword='' where pID='"+pID+"'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            ProfileInfo pi = new ProfileInfo(pID);
            pi.Close();

            Patient_Portal pp = new Patient_Portal(pID);
            pp.Close();

            Start s=new Start();
            s.Show();

            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                button1.Enabled = true;
            }
            if(checkBox1.Checked==false)
            {
                button1.Enabled = false;
            }
        }
    }
}
