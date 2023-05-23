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
            
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
                char ch = e.KeyChar;

                if (!char.IsLetter(ch) && ch != 8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                                                                                      //if (!char.IsLetterOrDigit(ch) && !char.IsLetter(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
                {
                    e.Handled = true;
                    MessageBox.Show("Only accept letter.");
                }

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Validating whether the field is null 
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Insert all details!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Email.Text == "")
            {
                MessageBox.Show("Insert all details!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Msg.Text == "")
            {
                MessageBox.Show("Insert all details!");
                return;
            }

            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.AddContactDetails(txt_Name.Text, txt_Email.Text, txt_Msg.Text);
            MessageBox.Show("Data Inserted Successfully");

            //Empty value of the textbox
            txt_Name.Text = string.Empty;
            txt_Email.Text = string.Empty;
            /*txt_Mobile.Text = string.Empty;*/
            txt_Msg.Text = string.Empty;
        }

        private void txt_Msg_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsLetter(ch) && ch != 8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                                                            //if (!char.IsLetterOrDigit(ch) && !char.IsLetter(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                MessageBox.Show("Only accept digital character or letter.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
