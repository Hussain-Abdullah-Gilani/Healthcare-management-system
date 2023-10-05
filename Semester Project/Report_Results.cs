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
    public partial class Report_Results : Form
    {
        int pID;
        int payid;
        public Report_Results(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void cBSearchTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {    
            string item="";
            DGVReports.Rows.Clear();
            if(cBSearchTest.SelectedItem==null)
            {
                MessageBox.Show("Please select an option from the Search by box ! ! ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                item = cBSearchTest.SelectedItem.ToString();
            }
            
            string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            if (tBSearch.Text == "")
            {
                cnn.Open();
                if (item == "Any")
                {
                    // Load Patient Reports
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID and Payment.payID=pResult.payID";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3),dataReader.GetString(4));
                    }
                }
                else if (item == "Malaria")
                {
                    // Load Patient Reports
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                       
                    }
                }

                else if (item == "Hepatitis")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                        
                    }
                }
                else if (item == "Corona")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "HIV")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Ligma")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
                else if (item == "Lung Cancer")
                {
                    string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName ='" + item + "'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    }
                }
            }
            else if (tBSearch.Text != "" && item=="Any")
            {
                cnn.Open();
                // Load Patient Reports
                string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and Patient.pCNIC='" + tBSearch.Text + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                }
            
            }
            else if (tBSearch.Text != "" && item!= "Any")
            {
                cnn.Open();
                // Load Patient Reports
                string sql = "SELECT Payment.payID,Patient.pName,Test.tName, pResult.rResult,Payment.payStatus FROM pResult, Test, Payment, Patient WHERE pResult.tID = Test.tID and Payment.tID = Test.tID and Patient.pID = pResult.pID AND Payment.payID=pResult.payID and tName='" + cBSearchTest.Text + "' and Patient.pCNIC='" + tBSearch.Text + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVReports.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                }

            }
            else 
            {
                MessageBox.Show("Please select an option from the Search by box ! ! ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      



         

        

        

        private void bUpdate_Click(object sender, EventArgs e)
        { 
            //int pid = 0;
            string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();


            string p = "";
            if (rBNotPaid.Checked == true)
            {
                p = "Pending";
            }
            if (rBPaid.Checked == true)
            {
                p = "Paid";
            }
            string tid1 = Convert.ToString(payid);
            string s = "UPDATE Payment SET " +
            "Payment.payStatus='" + p + "' " +
            "WHERE Payment.payID='" + tid1 +"'"; 
             SqlCommand command = new SqlCommand(s, cnn);
             command.ExecuteNonQuery();

             s = "UPDATE pResult SET " +
             "pResult.rResult='" + tBResult.Text+ "' " +
             "WHERE pResult.payID='" + tid1 + "'";
             SqlCommand command1 = new SqlCommand(s, cnn);
             command1.ExecuteNonQuery();
            

         
            cnn.Close();




            
            MessageBox.Show("Updated Successfully!!");
            //DGVReports.Rows.Clear();
            DGVReports.Update();
            DGVReports.Refresh();
            
           
        }

        private void DGVReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {

                DataGridViewRow row = this.DGVReports.Rows[e.RowIndex];

                string payid1 = row.Cells[0].Value.ToString();
                payid = Convert.ToInt32(payid1);

                tBRepName.Text = row.Cells[2].Value.ToString();

                tBResult.Text = row.Cells[3].Value.ToString();

                string payment_status = row.Cells[4].Value.ToString();
                if (payment_status == "Pending")
                {
                    rBNotPaid.Checked = true;
                    rBPaid.Checked = false;
                }
                else
                {
                    rBNotPaid.Checked = false;
                    rBPaid.Checked = true;
                }

                

            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string payid1 = Convert.ToString(payid);
            string s = "Delete From pResult WHERE pResult.payID='" + payid1 + "'";
           
            SqlCommand command = new SqlCommand(s, cnn);
            command.ExecuteNonQuery();

            s = "Delete From Payment WHERE Payment.payID='" + payid1 + "'";
            SqlCommand command1 = new SqlCommand(s, cnn);
            command1.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Deleted Successfully!!");
            //DGVReports.Rows.Clear();
            DGVReports.Update();
            DGVReports.Refresh();

        }
    }
}
