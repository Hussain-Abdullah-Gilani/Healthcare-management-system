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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup SignupObj = new Signup();
            SignupObj.Show();
            
        }

        

        private void bLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginObj = new Login();
            LoginObj.Show();
            
        }

        private void bAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin la = new LoginAdmin();
            la.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
        }

        
       

       
    }
}
