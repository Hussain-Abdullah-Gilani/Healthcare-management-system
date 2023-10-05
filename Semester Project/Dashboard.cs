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
using Calendar.NET;


namespace Semester_Project
{
    public partial class Dashboard : Form
    {   
            string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
            SqlConnection cnn;
            SqlCommand command;
            int pID;
        public Dashboard(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            fillcalendar();
        }




        private void fillcalendar()
        {
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string sql = "SELECT dAppointment.aDate,Doctor.dName,dAppointment.timeSlot FROM dAppointment,Doctor WHERE dAppointment.dID=Doctor.dID and dAppointment.pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            string adate ;
            string name = "";
            string timeslot = "";
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                adate=dataReader.GetString(0);
                name=dataReader.GetString(1);
                timeslot = dataReader.GetString(2);
                string[] seperatestring={"/"};
                string[] date =adate.Split(seperatestring,System.StringSplitOptions.RemoveEmptyEntries);
                int year = Convert.ToInt32(date[2]);
                year = year + 2000;
                int d=0;
                if(date[1]=="01")
                {
                    d = 1;
                }
                if (date[1] == "02")
                {
                    d = 2;
                } if (date[1] == "03")
                {
                    d = 3;
                } if (date[1] == "04")
                {
                    d = 4;
                } if (date[1] == "05")
                {
                    d = 5;
                } if (date[1] == "06")
                {
                    d = 6;
                } if (date[1] == "07")
                {
                    d = 7;
                } if (date[1] == "08")
                {
                    d = 8;
                } if (date[1] == "09")
                {
                    d = 9;
                } if (date[1] == "10")
                {
                    d = 10;
                } 
                if (date[1] == "11")
                {
                    d = 11;
                }
                if (date[1] == "12")
                {
                    d = 12;
                }
                var appointment = new HolidayEvent
                    {
                        Date = new DateTime(year, d, Convert.ToInt32(date[0])),
                        EventText = "Appointment\n"+name+"\n"+timeslot,
                        ThisDayForwardOnly=false
                    };
                calendar1.AddEvent(appointment);
             }
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            sql = "SELECT * FROM dAppointment WHERE Payment='Pending' and dAppointment.pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int count=0;
            while(dataReader.Read())
            {
                count++;
            }
            label5.Text = Convert.ToString(count);

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            sql = "SELECT * FROM pResult WHERE rResult='Pending' and pResult.pID='" + pID + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int count1 = 0;
            while (dataReader.Read())
            {
                count1++;
            }

            label4.Text = Convert.ToString(count1);



            cnn = new SqlConnection(connetionString);
            cnn.Open();
            sql ="SELECT Test.tName,Test.tPrice FROM pResult,Test WHERE pResult.tID=Test.tID and rResult!='Pending' and pResult.pID='"+pID+"'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            int count2 = 0;
            while (dataReader.Read())
            {
                count2 = count2 + dataReader.GetInt32(1);
            }
            label6.Text = Convert.ToString(count2);


            
           

            
            }

        private void Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            fillcalendar();
        }
            
        
        }
    }

