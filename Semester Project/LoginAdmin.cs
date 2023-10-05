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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s = new Start();
            s.Show();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (!(tBEmail.Text == "1" && tBPassword.Text == "1"))
            {
                MessageBox.Show("Incorrect Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Admin_Portal APortalObj = new Admin_Portal();
            APortalObj.StartPosition = FormStartPosition.CenterParent;
            APortalObj.ShowDialog(this);
            
        }
    }
}
