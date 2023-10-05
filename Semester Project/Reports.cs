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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Tables;
using System.IO;


namespace Semester_Project
{
    public partial class Reports : Form
    {
        // Hashir
        string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
        string report_name = "";
        string report_result = "";
        int pID;
        public Reports(int pID)
        {
            InitializeComponent();
            this.pID = pID;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadAllReports();
        }


        int i = 0;

        public string findname(string name)
        {
                
                i++;
                string increment = Convert.ToString(i);
                name = string.Concat(name,increment);
               

                if(File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\"+name+".pdf"))
                    {
                    findname(name);
                    }
                return name;
            
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            DGVReports.Rows.Clear();

            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "SELECT Test.tName, pResult.rResult FROM pResult INNER JOIN Test ON pResult.tID = Test.tID WHERE pID='" + pID + "' AND tName LIKE '%" + tBSearch.Text +"%'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVReports.Rows.Add(dataReader.GetString(0), dataReader.GetString(1));
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            LoadAllReports();
        }

        private void Reports_VisibleChanged(object sender, EventArgs e)
        {
            LoadAllReports();
        }

        private void LoadAllReports()
        {
            DGVReports.Rows.Clear();
            DGVReports.Refresh();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            // Load Patient Reports
            string sql = "SELECT Test.tName, pResult.rResult FROM pResult INNER JOIN Test ON pResult.tID = Test.tID WHERE pID='" + pID + "'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                DGVReports.Rows.Add(dataReader.GetString(0), dataReader.GetString(1));
            }
        }

        private void pReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((report_name == "" || report_result == ""))
            {
                MessageBox.Show("Please Select A Report!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(report_result=="Pending")
            {
                MessageBox.Show("Please Pay your Dues to Generate Report!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PdfDocument document = new PdfDocument();

                document.PageSettings.Orientation = PdfPageOrientation.Landscape;
                document.PageSettings.Margins.All = 50;

                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;

                PdfImage image = PdfImage.FromFile("D:/yolo.png");
                RectangleF bounds = new RectangleF(176, 0, 390, 130);

                page.Graphics.DrawImage(image, bounds);

                PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                bounds = new RectangleF(0, bounds.Bottom + 90, graphics.ClientSize.Width, 30);

                graphics.DrawRectangle(solidBrush, bounds);

                PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);

                PdfTextElement element = new PdfTextElement("Report Information", subHeadingFont);
                element.Brush = PdfBrushes.White;


                PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
                string currentDate = "DATE " + DateTime.Now.ToString("MM/dd/yyyy");

                SizeF textSize = subHeadingFont.MeasureString(currentDate);
                PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);

                graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);
                PdfFont timesRoman = new PdfStandardFont(PdfFontFamily.TimesRoman, 10);
                element = new PdfTextElement("   Patient Name                                                  Report Name                                                   Report Result                                                   Payment", timesRoman);
                element.Brush = new PdfSolidBrush(new PdfColor(126, 155, 203));
                result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));
                PdfPen linePen = new PdfPen(new PdfColor(126, 151, 173), 0.70f);
                PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
                PointF endPoint = new PointF(graphics.ClientSize.Width, result.Bounds.Bottom + 3);

                graphics.DrawLine(linePen, startPoint, endPoint);

                DataTable ReportDetails = new DataTable();


                PdfLightTable pdflightTable = new PdfLightTable();


                string connetionString = "Data Source=WORK-PC;Initial Catalog=EMedic;Integrated Security=True";
                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "Select Patient.pName,Patient.pAge,pGender,pPhoneNum,pCNIC,pEmail,pPassword from Patient where Patient.pID='"+pID+"'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                string name = "";
                while (dataReader.Read())
                {
                    name = dataReader.GetString(0);
                }
                int payment = 0;
                if (report_name == "HIV")
                {
                    payment = 5000;
                }

                if (report_name == "Malaria")
                {
                    payment = 500;
                }
                if (report_name == "Corona")
                {
                    payment = 7000;
                }
                if (report_name == "Ligma")
                {
                    payment = 50000;
                }
                if (report_name == "Hepatitis")
                {
                    payment = 7500;
                }
                if (report_name == "Lung Cancer")
                {
                    payment = 10000;
                }

                string p = Convert.ToString(payment);

                string pay = string.Concat(p, " PKR");


                ReportDetails.Columns.Add("Name");
                ReportDetails.Columns.Add("Report Name");
                ReportDetails.Columns.Add("Report Result");
                ReportDetails.Columns.Add("Payment");

                ReportDetails.Rows.Add(new string[] { name, report_name, report_result, pay });


                pdflightTable.DataSource = ReportDetails;
                //Creates the grid cell styles

                PdfLightTableStyle style = new PdfLightTableStyle();

                style.CellPadding = 15;
                style.CellSpacing = 5;
                pdflightTable.Style.CellPadding = 10;
                pdflightTable.Style.CellSpacing = 5;
                //PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                //cellStyle.Borders.All = PdfPens.White;
                //PdfGridRow header = grid.Headers[0];

                pdflightTable.Draw(page, new PointF(10, result.Bounds.Top + 17));

                string fname = "";
                if (File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\HIV.pdf"))
                {

                    fname = findname(report_name);
                }

                else if (File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\Corona.pdf"))
                {

                    fname = findname(report_name);
                }
                else if (File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\LungCancer.pdf"))
                {

                    fname = findname(report_name);
                }
                else if (File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\Ligma.pdf"))
                {

                    fname = findname(report_name);
                }
                else if (File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\Malaria.pdf"))
                {

                    fname = findname(report_name);
                }
                else if (File.Exists("C:\\Users\\work\\Documents\\Semester Project Official\\Semester Project\\bin\\Debug\\Hepatitis.pdf"))
                {

                    fname = findname(report_name);
                }

                else
                {
                    fname = report_name;
                }


                document.Save(fname + ".pdf");
                document.Close(true);

            }
        }

        private void DGVReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DGVReports.Rows[e.RowIndex];
               
                report_name = row.Cells[0].Value.ToString();
                report_result = row.Cells[1].Value.ToString();  
            }
        }
    }
}
