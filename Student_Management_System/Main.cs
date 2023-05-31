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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            //Directs to the sign in Form
            this.Hide();
            Registration_Desk register = new Registration_Desk();
            register.Show();
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
/*            //Directs to the Contact Form      
            this.Hide();
            Contact_Form register = new Contact_Form();
            register.Show();*/
        }
    }
}
