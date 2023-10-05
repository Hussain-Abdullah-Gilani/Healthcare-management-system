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
    public partial class AppointmentDetails : Form
    {
       
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
        int aID=0;
        int pID;
        string status="";
        public AppointmentDetails(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void AppointmentDetails_Load(object sender, EventArgs e)
        {
            AllAppointmentDetail();
        }
        private void AppointmentDetails_VisibleChanged(object sender, EventArgs e)
        {
            AllAppointmentDetail();
        }
        
        
        private void AllAppointmentDetail()
        {
            DGVPayments.Rows.Clear();
            DGVPayments.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "Select dAppointment.aID,Doctor.dName,Doctor.dSpeciality,dAppointment.aDate,dAppointment.timeSlot,dAppointment.Payment,dAppointment.AppointmentStatus,dAppointment.AppointmentType from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID and dAppointment.pID='"+pID+ "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVPayments.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7));
            }
            
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            if (status == "Cancelled")
            {
                MessageBox.Show("Appointment Already Cancelled!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(status=="" || aID==0)
            {
                MessageBox.Show("Please Select an Appointment to Cancel!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DGVPayments.Rows.Clear();
                DGVPayments.Refresh();
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();

                // Load Patient Reports
                string sql = "Update dAppointment Set AppointmentStatus='Cancelled' Where aID='" + aID + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery(); 
                AllAppointmentDetail();
                MessageBox.Show("Appointment Cancelled Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void DGVPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGVPayments.Rows[e.RowIndex];
                string aID1 = "";
                aID1 = row.Cells[0].Value.ToString();
                aID = Convert.ToInt32(aID1);
                status = row.Cells[5].Value.ToString();
            }
        }

        

        
         
      

        





      
        

        
    }
}
