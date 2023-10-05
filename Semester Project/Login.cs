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
    public partial class Login : Form
    {
        
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        int pID;    // Patient ID

        public Login()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s1 = new Start();
            s1.Show();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                MessageBox.Show("Incorrect Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Patient_Portal PPortalObj = new Patient_Portal(pID);
            PPortalObj.StartPosition = FormStartPosition.CenterParent;
            PPortalObj.ShowDialog(this);
            this.Close();
        }

        private bool CheckLogin()
        {
            SqlConnection cnn;
            SqlCommand command;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            // See if Patient Exists

            string sql = "SELECT pID FROM Patient WHERE pEmail='" + tBEmail.Text + "' AND pPassword='" + tBPassword.Text + "'";
            command = new SqlCommand(sql, cnn);
            bool Success = false;

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                pID = dataReader.GetInt32(0);
                Success = true;
            }

            if (Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lLForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }
    }
}
