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
    public partial class Add_Lecturer : Form
    {
        public Add_Lecturer()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            //Validating whether the field is null 
            if (txt_Fname.Text == "")
            {
                MessageBox.Show("Enter the First Name!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Lname.Text == "")
            {
                MessageBox.Show("Enter the Last Name!");
                return;
            }

            //Validating whether the field is null 
            if (cmb_Dtype.Text == "")
            {
                MessageBox.Show("Enter the Degree Type!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Dname.Text == "")
            {
                MessageBox.Show("Enter the Degree Name!");
                return;
            }


            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.AddNewLecturer(txt_Fname.Text, txt_Lname.Text, cmb_Dtype.Text, txt_Dname.Text);
            MessageBox.Show("Data Inserted Successfully");

            //Empty value of the textbox
            txt_Fname.Text = string.Empty;
            txt_Lname.Text = string.Empty;
            cmb_Dtype.Text = string.Empty;
            txt_Dname.Text = string.Empty;
        }

        private void txt_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Dname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //Directs to the Registration Form
            this.Hide();
            Registration_Desk register = new Registration_Desk();
            register.Show();
        }

        private void Add_Lecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
