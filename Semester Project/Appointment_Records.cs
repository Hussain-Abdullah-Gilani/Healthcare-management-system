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
    public partial class Appointment_Records : Form
    {
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd;
        int aID;
        int pID;
        string AppointmentStatus = "";
        string payment = "";
        public Appointment_Records(int pid)
        {
            InitializeComponent();
            this.pID = pid;
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
                if (item == "Any")
                {
                    // Load Patient Reports
                    string sql = "Select dAppointment.aID,Patient.pName,Doctor.dName,Doctor.dSpeciality,dAppointment.aDate,dAppointment.timeSlot,dAppointment.Payment,dAppointment.AppointmentStatus from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID "; 
                    cmd = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        DGVPatients.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7));   
                     }
                }
                if (item == "Doctor_Name")
                {

                    if (tBSearch.Text == "")
                    {
                        MessageBox.Show("Please Type a Doctor Name into the Search Bar!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {

                        DGVPatients.Rows.Clear();
                        // Load Patient Reports
                        string sql = "Select dAppointment.aID,Patient.pName,Doctor.dName,Doctor.dSpeciality,dAppointment.aDate,dAppointment.timeSlot,dAppointment.Payment,dAppointment.AppointmentStatus from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID and Doctor.dName LIKE '" + '%' + tBSearch.Text + '%' + "'";
                        cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            DGVPatients.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7));
                        }
                    }
                }
                if (item == "Patient_Name")
                {
                    if (tBSearch.Text == "")
                    {
                        MessageBox.Show("Please Type a Patients Name into the Search Bar!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {

                        DGVPatients.Rows.Clear();
                        // Load Patient Reports
                        string sql = "Select dAppointment.aID,Patient.pName,Doctor.dName,Doctor.dSpeciality,dAppointment.aDate,dAppointment.timeSlot,dAppointment.Payment,dAppointment.AppointmentStatus from dAppointment,Doctor,Patient where  Doctor.dID=dAppointment.dID and dAppointment.pID = Patient.pID and Patient.pName LIKE '" + '%' + tBSearch.Text + '%' + "'";
                        cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            DGVPatients.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7));
                        }
                    }
                }
                cnn.Close();
            }

        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

            if(AppointmentStatus=="")
            {
                MessageBox.Show("Please select an Appointment!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox2.Checked==true && checkBox3.Checked==true)
            {
                MessageBox.Show("Please select One Payment Status !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Please select One Payment Status!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(radioButton1.Checked==false && radioButton2.Checked==false && radioButton3.Checked==false && radioButton4.Checked==false)
            {
                MessageBox.Show("Please select A Time Slot!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string timeslot = "";
            if (radioButton1.Checked == true)
            {
                timeslot = "14:00";
            }
            if (radioButton2.Checked == true)
            {
                timeslot = "16:00";
            }
            if (radioButton3.Checked == true)
            {
                timeslot = "18:00";
            }
            if (radioButton4.Checked == true)
            {
                timeslot = "20:00";
            }

            string Apst="";
            string ps = "";

            if(checkBox1.Checked==true)
            {
                Apst = "Cancelled";
            }
            if(checkBox1.Checked==false)
            {
                Apst = "Not Cancelled";
            }

            if (checkBox3.Checked == true)
            {
                ps = "Paid";
            }
            if (checkBox2.Checked == true)
            {
                ps = "Pending";
            }





            // Create Appointment
            string sql = "Update dAppointment Set aDate='"+DTPDate.Value.ToString("dd/MM/yy")+"',"+" timeSlot='"+timeslot+"',"+" Payment='"+ps+"',"+"AppointmentStatus='"+Apst+"' Where aID='"+aID+"'";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
        }

        private void DGVPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGVPatients.Rows[e.RowIndex];
                string aID1 = row.Cells[0].Value.ToString();
                aID = Convert.ToInt32(aID1);

                payment = row.Cells[6].Value.ToString();
                AppointmentStatus = row.Cells[7].Value.ToString();

                if(payment=="Pending")
                {
                    checkBox2.Checked = true;
                }
                if(payment=="Paid")
                {
                    checkBox3.Checked = true;
                }

                if(AppointmentStatus=="Cancelled")
                {
                    checkBox1.Checked = true;
                }
                if (AppointmentStatus == "Not Cancelled")
                {
                    checkBox1.Checked = false;
                }




            }
        }
    }
}
