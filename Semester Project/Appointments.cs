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
    public partial class Appointments : Form
    {
        // Hashir
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";

        int pID;
        public Appointments(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadDocData();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            LoadDocData();
            cBCardiologist.Checked = false;
            cBNephro.Checked = false;
            cBNeuro.Checked = false;
            cBPediatric.Checked = false;
            cBPsychiatric.Checked = false;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text == "")
            {
                MessageBox.Show("Please Enter Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void bFilter_Click(object sender, EventArgs e)
        {



            
            string home = "";
            if (checkBox1.Checked)
            {
                home = "No";
            }
            if (checkBox2.Checked)
            {
                home = "Yes";
            }

            string Speciality1 = "";
            string Speciality2 = "";
            string Speciality3 = "";
            string Speciality4 = "";
            string Speciality5 = "";

            if (cBCardiologist.Checked)
            {
                Speciality1 = "Cardiologist";
            }
            if (cBNephro.Checked)
            {
                Speciality2 = "Nephrologist";
            }
            if (cBNeuro.Checked)
            {
                Speciality3 = "Neurologist";
            }
            if (cBPediatric.Checked)
            {
                Speciality4 = "Pediatric";
            }
            if (cBPsychiatric.Checked)
            {
                Speciality5 = "Psychiatric";
            }

            if (Speciality1=="" && Speciality2=="" && Speciality3=="" && Speciality4=="" && Speciality5=="" && home=="")
            {
                MessageBox.Show("Please Apply At Least 1 Filter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            


            if (home == "")
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "SELECT * FROM Doctor WHERE dSpeciality='"+Speciality1+"' or dSpeciality='"+Speciality2+"' or dSpeciality='"+Speciality3+"' or dSpeciality='"+Speciality4+"' or dSpeciality='"+Speciality5+"'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4));
                }
            }
            else if(home!="" && Speciality1=="" && Speciality2=="" && Speciality3=="" && Speciality4=="" && Speciality5=="")
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "SELECT * FROM Doctor WHERE dHome='"+home+"'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4));
                }
            }
            else if ((home != "") && (Speciality1 != "" || Speciality2 != "" || Speciality3 != "" || Speciality4 != "" || Speciality5 != ""))
            {
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "SELECT * FROM Doctor WHERE (dSpeciality='" + Speciality1 + "' or dSpeciality='" + Speciality2 + "' or dSpeciality='" + Speciality3 + "' or dSpeciality='" + Speciality4 + "' or dSpeciality='" + Speciality5 + "') and (dHome='"+home+"')";
                
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4));
                }
            }
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            int dID;
            string Name;
            string appointmenttype = "";
            
            if (DGVDoctors.SelectedCells.Count > 0)
            {
                dID = Convert.ToInt32(DGVDoctors.Rows[DGVDoctors.SelectedCells[0].RowIndex].Cells["dID"].Value.ToString());
                Name = DGVDoctors.Rows[DGVDoctors.SelectedCells[0].RowIndex].Cells["DocName"].Value.ToString();
                appointmenttype = DGVDoctors.Rows[DGVDoctors.SelectedCells[0].RowIndex].Cells["Column1"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Select Doctor To Book Appointment With!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            string timeslot = "";
            if(radioButton1.Checked==true)
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
            if(appointmenttype=="No" && checkBox3.Checked==true)
            {
                MessageBox.Show("This Doctor is not Available for Home Visit!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(timeslot=="")
            {
                MessageBox.Show("Select A time slot!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Create Appointment




            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();



            string sql = "SELECT aDate,timeSlot,dID FROM dAppointment WHERE aDate='" + DTPDate.Value.ToString("dd/MM/yy") + "' and timeSlot='" + timeslot+"' and dID='"+dID+"'";

            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            string date=DTPDate.Value.ToString("dd/MM/yy");
            while (dataReader.Read())
            {
                if(dataReader.GetString(0)==date && dataReader.GetString(1)==timeslot && dataReader.GetInt32(2)==dID)
                {
                    MessageBox.Show("The Doctor is Busy on the Date and time slot you Selected!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            cnn.Close();

            string connetionString1 = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
            SqlConnection cnn1 = new SqlConnection(connetionString1);
            cnn1.Open();

            string sql1 = "INSERT INTO dAppointment(aDate,timeSlot,AppointmentType,dID, pID) VALUES('" + DTPDate.Value.ToString("dd/MM/yy") + "', '" + timeslot + "', '"+appointmenttype+"', '"+ dID + "', '" + pID + "')";
            SqlCommand command1 = new SqlCommand(sql1, cnn1);
            command1.ExecuteNonQuery();

            MessageBox.Show("Appointment With Dr." + Name + " Scheduled For " + DTPDate.Value.ToString("dd/MM/yy") + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDocData()
        {
            DGVDoctors.Rows.Clear();
            DGVDoctors.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "SELECT * FROM Doctor";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVDoctors.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4));
            }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = System.Drawing.Color.Black;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.ForeColor = System.Drawing.Color.Black;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = System.Drawing.Color.Black;
        }

       
    }
}
