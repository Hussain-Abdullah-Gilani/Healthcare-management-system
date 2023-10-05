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
    public partial class Doctor_Records : Form
    {
        int pID;
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd;

        public Doctor_Records(int pID)
        {
            InitializeComponent();
            this.pID = pID;
            
        }

        private void cBSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(cBSearchBy.SelectedItem.ToString());
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            DGVDoctors.Rows.Clear();
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string item = cBSearchBy.SelectedItem.ToString();
            string data = tBSearch.Text;
            if (item == "Name")
            {
                string s = "Select dName,dSpeciality,dSalary FROM Doctor where dName LIKE '"+'%' + data +'%' + "'";
                cmd = new SqlCommand(s, cnn);
                SqlDataReader dataread = cmd.ExecuteReader();
                while (dataread.Read())
                {
                    DGVDoctors.Rows.Add(dataread.GetString(0), dataread.GetString(1), dataread.GetInt32(2));
                }
                
            }
            if (item == "Speciality")
            {
                string s = "Select dName,dSpeciality,dSalary FROM Doctor where dSpeciality LIKE '" + '%' + data + '%' + "'";
                cmd = new SqlCommand(s, cnn);
                SqlDataReader dataread = cmd.ExecuteReader();
                while (dataread.Read())
                {
                    DGVDoctors.Rows.Add(dataread.GetString(0), dataread.GetString(1), dataread.GetInt32(2));
                }
            }
            if (item == "Salary")
            {
                string s = "Select dName,dSpeciality,dSalary FROM Doctor where dSalary LIKE '" + '%' + data + '%' + "'";
                cmd = new SqlCommand(s, cnn);
                SqlDataReader dataread = cmd.ExecuteReader();
                while (dataread.Read())
                {
                    DGVDoctors.Rows.Add(dataread.GetString(0), dataread.GetString(1), dataread.GetInt32(2));
                }
            }
            cnn.Close();



        }
    }
}
