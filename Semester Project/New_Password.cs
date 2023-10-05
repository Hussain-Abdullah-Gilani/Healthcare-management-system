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
    public partial class New_Password : Form
    {
        int pID=0;
        public New_Password(int pID)
        {
            InitializeComponent();
            this.pID =pID;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if(tBEmail.Text!=cTextBox1.Text)
            {
                MessageBox.Show("Passwords Don't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tBEmail.Text=="" || cTextBox1.Text=="")
            {
                MessageBox.Show("No field can be left Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tBEmail.Text==cTextBox1.Text)
            {
               
                string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
                SqlConnection cnn;
                SqlCommand command;
                cnn = new SqlConnection(connetionString);

                cnn.Open();

                string sql = "Update Patient Set pPassword='"+tBEmail.Text+ "' where pID='"+pID+"'";
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Password Successfully Updated. Please Login again", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Start s6 = new Start();
                s6.Show();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }
    }


}
