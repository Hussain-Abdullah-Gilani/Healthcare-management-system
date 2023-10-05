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
    public partial class Tests : Form
    {
        // Hashir
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        int pID;
        string TestTotal;

        public Tests(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void bTotalPrice_Click(object sender, EventArgs e)
        {
            string TestNames = getTestList();
            if (TestNames == "")
            {
                MessageBox.Show("Please Select At Least 1 Test!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Calculate Price
            string sql = "SELECT tPrice FROM Test WHERE " + TestNames;
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            int Total = 0;
            while (dataReader.Read())
            {
                Total += dataReader.GetInt32(0);
            }

            MessageBox.Show(TestTotal + "\nTotal Price: " + String.Format("{0:n0}", Total), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataReader.Close();
            dataReader.Dispose();
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            if ("" == getTestList())
            {
                MessageBox.Show("Please Select At Least 1 Test!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cBHIV.Checked)
            {
                CreateInvoice("HIV");
            }
            if (cBMalaria.Checked)
            {
                CreateInvoice("Malaria");
            }
            if (cBCancer.Checked)
            {
                CreateInvoice("Lung Cancer");
            }
            if (cBCorona.Checked)
            {
                CreateInvoice("Corona");
            }
            if (cBLigma.Checked)
            {
                CreateInvoice("Ligma");
            }
            if (cBHepatitis.Checked)
            {
                CreateInvoice("Hepatitis");
            }

            MessageBox.Show("Tests Successfully Booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pHIV_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBHIV.Checked)
            {
                cBHIV.Checked = false;
            }
            else
            {
                cBHIV.Checked = true;
            }
        }

        private void pMalaria_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBMalaria.Checked)
            {
                cBMalaria.Checked = false;
            }
            else
            {
                cBMalaria.Checked = true;
            }
        }

        private void pCancer_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBCancer.Checked)
            {
                cBCancer.Checked = false;
            }
            else
            {
                cBCancer.Checked = true;
            }
        }

        private void pCorona_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBCorona.Checked)
            {
                cBCorona.Checked = false;
            }
            else
            {
                cBCorona.Checked = true;
            }
        }

        private void pLigma_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBLigma.Checked)
            {
                cBLigma.Checked = false;
            }
            else
            {
                cBLigma.Checked = true;
            }
        }

        private void pHepatitis_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBHepatitis.Checked)
            {
                cBHepatitis.Checked = false;
            }
            else
            {
                cBHepatitis.Checked = true;
            }
        }

        private string getTestList()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Calculate Price
            string sql;

            string TestNames = "";
            string TestTotal = "";

            bool Run = false;
            if (cBCancer.Checked)
            {
                if (Run)
                {
                    TestNames += " OR ";
                }
                Run = true;
                TestNames += "tName='Lung Cancer'";

                // Get Test Price
                sql = "SELECT tPrice FROM Test WHERE tName='Lung Cancer'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TestTotal += "Lung Cancer: " + String.Format("{0:n0}", dataReader.GetInt32(0)) + "\n";
                }
                dataReader.Close();
                dataReader.Dispose();
            }
            if (cBCorona.Checked)
            {
                if (Run)
                {
                    TestNames += " OR ";
                }
                Run = true;
                TestNames += "tName='Corona'";

                // Get Test Price
                sql = "SELECT tPrice FROM Test WHERE tName='Corona'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TestTotal += "Corona: " + String.Format("{0:n0}", dataReader.GetInt32(0)) + "\n";
                }
                dataReader.Close();
                dataReader.Dispose();
            }
            if (cBHepatitis.Checked)
            {
                if (Run)
                {
                    TestNames += " OR ";
                }
                Run = true;
                TestNames += "tName='Hepatitis'";

                // Get Test Price
                sql = "SELECT tPrice FROM Test WHERE tName='Hepatitis'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TestTotal += "Hepatitis: " + String.Format("{0:n0}", dataReader.GetInt32(0)) + "\n";
                }
                dataReader.Close();
                dataReader.Dispose();
            }
            if (cBHIV.Checked)
            {
                if (Run)
                {
                    TestNames += " OR ";
                }
                Run = true;
                TestNames += "tName='HIV'";

                // Get Test Price
                sql = "SELECT tPrice FROM Test WHERE tName='HIV'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TestTotal += "HIV: " + String.Format("{0:n0}", dataReader.GetInt32(0)) + "\n";
                }
                dataReader.Close();
                dataReader.Dispose();
            }
            if (cBLigma.Checked)
            {
                if (Run)
                {
                    TestNames += " OR ";
                }
                Run = true;
                TestNames += "tName='Ligma'";

                // Get Test Price
                sql = "SELECT tPrice FROM Test WHERE tName='Ligma'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TestTotal += "Ligma: " + String.Format("{0:n0}", dataReader.GetInt32(0)) + "\n";
                }
                dataReader.Close();
                dataReader.Dispose();
            }
            if (cBMalaria.Checked)
            {
                if (Run)
                {
                    TestNames += " OR ";
                }
                Run = true;
                TestNames += "tName='Malaria'";

                // Get Test Price
                sql = "SELECT tPrice FROM Test WHERE tName='Malaria'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    TestTotal += "Malaria: " + String.Format("{0:n0}", dataReader.GetInt32(0)) + "\n";
                }
                dataReader.Close();
                dataReader.Dispose();
            }

            this.TestTotal = TestTotal;
            return TestNames;
        }

        private void CreateInvoice(string tName)
        {
            string sql;
            int tID = 0;
            int payID = 0;
            SqlCommand command;

            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Get Test ID and Store it's value in Payments table
            sql = "SELECT tID FROM Test WHERE tName='" + tName + "'";
            command = new SqlCommand(sql, cnn);
            tID = Convert.ToInt32(command.ExecuteScalar().ToString());

            // Create new payment that user pID has to pay 7 days from now for given testID 
            sql = "INSERT INTO Payment(payDueDate, tID, pID) VALUES('" + DateTime.Now.AddDays(7).ToString("dd/MM/yy") + "', '" + tID + "', '" + pID + "'); SELECT @@IDENTITY";
            command = new SqlCommand(sql, cnn);
            //command.ExecuteNonQuery();

            payID = Convert.ToInt32(command.ExecuteScalar().ToString());

            // Create New Result record linking to pID, tID, payID
            sql = "INSERT INTO pResult(payID, tID, pID) " + "VALUES('" + payID + "', '" + tID + "', '" + pID + "')";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
        }
    }
}
