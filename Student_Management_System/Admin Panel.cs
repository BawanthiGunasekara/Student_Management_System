using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void btn_Dashbrd_Click(object sender, EventArgs e)
        {
            //Directs to the Admin_Panel Form
            this.Hide();
            Admin_Panel admin = new Admin_Panel();
            admin.Show();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
