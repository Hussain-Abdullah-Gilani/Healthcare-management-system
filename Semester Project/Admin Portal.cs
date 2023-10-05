using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{
    public partial class Admin_Portal : Form
    {
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
        int pID;

        Search_Records SearchRecordsObj;
        Report_Results ReportResultsObj;
        Doctor_Records DoctorRecordsObj;
        Appointment_Records AppointmentRecordsObj;




        public Admin_Portal()
        {
            InitializeComponent();
           

            SearchRecordsObj = new Search_Records(pID) { TopLevel = false, TopMost = true };
            ReportResultsObj = new Report_Results(pID) { TopLevel = false, TopMost = true };
            DoctorRecordsObj = new Doctor_Records(pID) { TopLevel = false, TopMost = true };
            AppointmentRecordsObj = new Appointment_Records(pID) { TopLevel = false, TopMost = true };
            
            this.pFormArea.Controls.Add(SearchRecordsObj);
            this.pFormArea.Controls.Add(ReportResultsObj);
            this.pFormArea.Controls.Add(DoctorRecordsObj);
            this.pFormArea.Controls.Add(AppointmentRecordsObj);
        }

        private void HideAllPanels()
        {
            // Hide Blue "Active" indicator panel
            pDashboardActive.Hide();
            panel2.Hide();
            panel3.Hide();
            panel1.Hide();

            // Hide All Forms
            SearchRecordsObj.Hide();
            ReportResultsObj.Hide();
            DoctorRecordsObj.Hide();
            AppointmentRecordsObj.Hide();

        }



        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Start s = new Start();
            s.Show();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel2.Show();
            ReportResultsObj.Show();
        }

        private void Admin_Portal_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            pDashboardActive.Show();
            SearchRecordsObj.Show();
        }

        private void bDocRec_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel3.Show();
            DoctorRecordsObj.Show();
        }

        private void bSearchRec_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pDashboardActive.Show();
            SearchRecordsObj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bClose_MouseEnter(object sender, EventArgs e)
        {
            bClose.BackColor = System.Drawing.Color.Red;
        }

        private void bClose_MouseLeave(object sender, EventArgs e)
        {
            bClose.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel1.Show();
            AppointmentRecordsObj.Show();
        }
    }
}
