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
    public partial class Registration_Desk : Form
    {
        public Registration_Desk()
        {
            InitializeComponent();
        }

        private void pic_Guest_Click(object sender, EventArgs e)
        {
            //Directs to the Registration Form
            this.Hide();
            Main register = new Main();
            register.Show();
        }

        private void Pic_Lecturer_Click(object sender, EventArgs e)
        {
            //Directs to the Form
            this.Hide();
            Add_Lecturer register = new Add_Lecturer();
            register.Show();
        }

        private void Pic_Student_Click(object sender, EventArgs e)
        {
            //Directs to the Registration Form
            this.Hide();
            Add_Student register = new Add_Student();
            register.Show();
        }

        private void Pic_Admin_Click(object sender, EventArgs e)
        {
            //Directs to the Registration Form
            this.Hide();
            User_Login register = new User_Login();
            register.Show();
        }

        private void Registration_Desk_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Directs to the Registration Form
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
