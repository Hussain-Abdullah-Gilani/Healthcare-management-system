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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
            SqlConnection cnn;
            SqlCommand command;
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            string sql = "SELECT pID FROM Patient WHERE pEmail='" + tBEmail.Text + "'";
            command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            int email = 0;
            while(dataReader.Read())
            {
                email = dataReader.GetInt32(0);
            }
            if(email==0)
            {
                MessageBox.Show("Wrong Email!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
                New_Password np1 = new New_Password(email);
                np1.Show();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
