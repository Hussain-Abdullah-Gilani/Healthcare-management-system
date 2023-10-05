using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Semester_Project
{
    public partial class Signup : Form
    {
        // Hashir
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        public Signup()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s2 = new Start();
            s2.Show();
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            if (isInvalidInput())
            {
                return;
            }
            InsertData();

            this.Close();
            Start s5 = new Start();
            s5.Show();
        }

        private void cBAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void InsertData()
        {
            //string connetionString;
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            // SQL Query to insert data into Database Table "Patient"
            SqlCommand command;
            string sql = "INSERT INTO Patient (pName, pAge, pGender, pPhoneNum, pCNIC, pEmail, pPassword) " +
                "values (" +
                "'" + tBFName.Text + " " + tBLName.Text + "'," +
                "'" + Convert.ToInt32(cBAge.Text) + "'," +
                "'" + cBGender.Text + "'," +
                "'" + tBPhone.Text + "'," +
                "'" + mTBCNIC.Text + "'," +
                "'" + tBEmail.Text + "'," +
                "'" + tBPassword.Text + "'" +
                ")";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            // Get the auto assigned pID from the patient table
            sql = "SELECT pID from Patient where pCNIC='" + mTBCNIC.Text + "'";
            command = new SqlCommand(sql, cnn);
            int result = (int)command.ExecuteScalar();

            // Insert Father details into pFather table
            sql = "INSERT INTO pFather (pFName, pFPhoneNum, pFCNIC, pID) " +
                "values (" +
                "'" + tBFatherName.Text + "'," +
                "'" + tBFPhone.Text + "'," +
                "'" + mTBFCNIC.Text + "'," +
                "'" + result + "'" +
                ")";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("You Have Been Succesfully Logged In!\nPlease Login To Continue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool isInvalidInput()
        {
            // Check to make sure all inputs have been modified
            if (
                tBFName.Text == "" ||
                tBLName.Text == "" ||
                cBAge.Text == "Age" ||
                cBGender.Text == "Gender" ||
                tBPhone.Text == "" ||
                mTBCNIC.Text == "     -" ||
                tBEmail.Text == "" ||
                tBPassword.Text == ""
                )
            {
                MessageBox.Show("All Fields Required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // If passwords do not match
            else if (tBConfirmPass.Text != tBPassword.Text)
            {
                MessageBox.Show("Passwords Do Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // If entered CNIC Exists
            else if (RecordExists("pCNIC", mTBCNIC.Text))
            {
                MessageBox.Show("User With Given CNIC Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            else if (RecordExists("pEmail", tBEmail.Text))
            {
                MessageBox.Show("User With Given Email Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            // If Father CNIC = Patient CNIC
            else if (mTBCNIC.Text == mTBFCNIC.Text)
            {
                MessageBox.Show("Father CNIC Must Be Different to User CNIC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private bool RecordExists(string Column, string Value)
        {
            SqlConnection cnn;
            SqlCommand command;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            // See if Value already Exists

            string sql = "SELECT " + Column + ", count(*) as c FROM Patient WHERE " + Column + "='" + Value + "' GROUP BY " + Column;
            command = new SqlCommand(sql, cnn);
            int result = 0;

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                result = dataReader.GetInt32(1);
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
