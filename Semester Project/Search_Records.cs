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
    public partial class Search_Records : Form
    {
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd;
        int pID;
        string fcnic;
        string cnic;
        public Search_Records(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void cBAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {


            DGVPatients.Rows.Clear();
            if (cBSearchBy.SelectedItem == null)
            {
                MessageBox.Show("Please select an option from the Search by box ! ! ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {


                DGVPatients.Rows.Clear();
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string item = cBSearchBy.SelectedItem.ToString();
                string txt = tBSearch.Text;
                if (item == "Name")
                {
                    // Load Patient Reports
                    string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC from Patient,pFather WHERE Patient.pID=pFather.pID and pName LIKE '" + '%' + txt + '%' + "'";
                    cmd = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9));
                    }
                }
                if (item == "CNIC")
                {
                    DGVPatients.Rows.Clear();
                    // Load Patient Reports
                    string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC from Patient,pFather WHERE Patient.pID=pFather.pID and pCNIC LIKE '" + '%' + txt + '%' + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9));

                    }
                }
                if (item == "Age")
                {
                    DGVPatients.Rows.Clear();
                    // Load Patient Reports
                    //int age=Convert.ToInt32()
                    string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword,pFName,pFPhoneNum,pFCNIC from Patient,pFather WHERE Patient.pID=pFather.pID and pAge LIKE '" + '%' + txt + '%' + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetString(0), dataReader.GetValue(1).ToString(), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9));

                    }
                }
                cnn.Close();
            }
        }

        private void DGVPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGVPatients.Rows[e.RowIndex];

                string tid1 = row.Cells[0].Value.ToString();
                Int32 count = 2;
                char[] sep = { ' ' };
                string[] split = tid1.Split(sep,count,StringSplitOptions.None);
                tBFName.Text = split[0];
                tBLName.Text = split[1];
                cBAge.SelectedItem = row.Cells[1].Value;
                cBGender.SelectedItem = row.Cells[2].Value;
                tBPhone.Text = row.Cells[3].Value.ToString();
                mTBCNIC.Text = row.Cells[4].Value.ToString();
                cnic = row.Cells[4].Value.ToString();

                tBEmail.Text = row.Cells[5].Value.ToString();
                tBPassword.Text = row.Cells[6].Value.ToString();
                tBFatherName.Text = row.Cells[7].Value.ToString();
                tBFPhone.Text = row.Cells[8].Value.ToString();
                mTBFCNIC.Text = row.Cells[9].Value.ToString();
                fcnic = row.Cells[9].Value.ToString();


                
            }
        }



        private void bUpdate_Click(object sender, EventArgs e)
        {
            if(tBFName.Text=="" || tBLName.Text=="" || cBAge.SelectedItem==null || cBGender.SelectedItem==null 
                ||  tBPhone.Text=="" || mTBCNIC.Text=="" || tBEmail.Text=="" ||  tBPassword.Text=="" || tBFatherName.Text=="" || tBFPhone.Text=="" ||  mTBFCNIC.Text=="")
            {
                MessageBox.Show("Please Enter all the details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else if(checkBox1.Checked==true)
            {
                if((tBNewPassword.Text=="" || cTextBox1.Text=="") ||(tBNewPassword.Text!=cTextBox1.Text))
                {
                MessageBox.Show("Passwords don't Match Or are Empty!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

                



                string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string name = tBFName.Text + " " + tBLName.Text;

                string s = "UPDATE Patient SET " +
                "pName='" + name + "', " +
                 "pAge='" + cBAge.SelectedItem.ToString() + "', " +
                  "pGender='" + cBGender.SelectedItem.ToString() + "', " +
                   "pPhoneNum='" + tBPhone.Text + "', " +
                    "pCNIC='" + mTBCNIC.Text + "', " +
                     "pEmail='" + tBEmail.Text + "', " +
                      "pPassword='" + tBNewPassword.Text + "' " +
                "WHERE pCNIC='" + cnic + "'";

                SqlCommand command = new SqlCommand(s, cnn);
                command.ExecuteNonQuery();

                string s1 = "UPDATE pFather SET " +
                "pFName='" + tBFatherName.Text + "', " +
                 "pFPhoneNum='" + tBFPhone.Text + "', " +
                  "pFCNIC='" + mTBFCNIC.Text + "' " +
                  "WHERE pFCNIC='" + fcnic + "'";

                SqlCommand command1 = new SqlCommand(s1, cnn);
                command1.ExecuteNonQuery();

                MessageBox.Show("Patient Data Added Successfully !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tBFName.Text = "";
                tBLName.Text = "";
                cBAge.SelectedItem=""; 
                cBGender.SelectedItem = "";
                tBPhone.Text ="";
                mTBCNIC.Text = "";
                tBEmail.Text ="";
                tBPassword.Text = "";
                tBFatherName.Text = "";
                tBFPhone.Text ="";
                mTBFCNIC.Text = "";
                checkBox1.Checked = false;
               

            }
            
            else
            {
                string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string name = tBFName.Text + " " + tBLName.Text;
                
                string s = "UPDATE Patient SET " +
                "pName='" + name + "', " +
                 "pAge='" + cBAge.SelectedItem.ToString() + "', " +
                  "pGender='" + cBGender.SelectedItem.ToString() + "', " +
                   "pPhoneNum='" +tBPhone.Text+ "', " +
                    "pCNIC='" + mTBCNIC.Text + "', " +
                     "pEmail='" + tBEmail.Text + "', " +
                      "pPassword='" + tBPassword.Text + "' " +
                "WHERE pCNIC='" + cnic + "'";

                SqlCommand command = new SqlCommand(s, cnn);
                command.ExecuteNonQuery();

                string s1 ="UPDATE pFather SET " +
                "pFName='" + tBFatherName.Text + "', " +
                 "pFPhoneNum='" + tBFPhone.Text + "', " +
                  "pFCNIC='" + mTBFCNIC.Text + "' " +
                  "WHERE pFCNIC='" + fcnic+ "'";

                SqlCommand command1 = new SqlCommand(s1, cnn);
                command1.ExecuteNonQuery();

                MessageBox.Show("Patient Data Added Successfully !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tBFName.Text = "";
                tBLName.Text = "";
                cBAge.SelectedItem = "";
                cBGender.SelectedItem = "";
                tBPhone.Text = "";
                mTBCNIC.Text = "";
                tBEmail.Text = "";
                tBPassword.Text = "";
                tBFatherName.Text = "";
                tBFPhone.Text = "";
                mTBFCNIC.Text = "";
                tBNewPassword.Text = "";
                cTextBox1.Text = "";
                checkBox1.Checked = false;
               

            }
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                tBEmail.Enabled = true;
                tBPassword.Enabled = true;
                tBNewPassword.Enabled = true;
                cTextBox1.Enabled = true;
            }
            else if(checkBox1.Enabled==false)
            {
                tBEmail.Enabled = false;
                tBPassword.Enabled = false;
                tBNewPassword.Enabled = false;
                cTextBox1.Enabled = false;
            }
        }
    }
}