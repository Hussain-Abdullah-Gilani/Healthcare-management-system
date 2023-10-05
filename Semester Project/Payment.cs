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
    public partial class Payment : Form
    {
        // Hashir
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        int pID;
        public Payment(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
        }

        private void Payment_VisibleChanged(object sender, EventArgs e)
        {
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            DGVPayments.Rows.Clear();
            DGVPayments.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "SELECT Test.tName, Test.tPrice, Payment.payDueDate, Payment.payStatus FROM Test INNER JOIN Payment ON Payment.tID = Test.tID WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVPayments.Rows.Add(dataReader.GetString(0), String.Format("{0:n0}", dataReader.GetInt32(1)), dataReader.GetString(2), dataReader.GetString(3));
            }
        }
    }
}
