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
    public partial class Contact_Form : Form
    {
        public Contact_Form()
        {
            InitializeComponent();
        }

        private void Contact_Form_Load(object sender, EventArgs e)
        {

        }

        private void txt_Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.AddContactDetails(txt_Name.Text, txt_Email.Text, txt_Mobile.Text, txt_Msg.Text);
            MessageBox.Show("Data Inserted Successfully");

            //Empty value of the textbox
            txt_Name.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Mobile.Text = string.Empty;
            txt_Msg.Text = string.Empty;
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsWhiteSpace(ch) && !char.IsLetter(ch))
            {
                e.Handled = true;
                MessageBox.Show("Only accepts letters.");
            }
        }
    }
}
