using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Add_Student : Form
    {
        public object X { get; }

        public Add_Student()
        {
            InitializeComponent();
        }

        public Add_Student(object x)
        {
            X = x;
        }
        private void Add_Student_Load(object sender, EventArgs e)
        {
            txt_RegDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");

            /*DatabaseConnection dbc = new DatabaseConnection();*/

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "select d.Degree_Name, s.Specialization_Name from Degree d INNER JOIN Specialization s on d.Degree_Name = s.Degree_Name ";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmb_Degree.DataSource = ds.Tables[0];
            cmb_Degree.DisplayMember = "Degree_Name";
            cmb_Degree.ValueMember = "Degree_Name";
            cmb_Degree.SelectedIndex = -1;

            cmb_Specialization.DataSource = ds.Tables[0];
            cmb_Specialization.DisplayMember = "Specialization_Name";
            cmb_Specialization.ValueMember = "Specialization_Name";
            cmb_Specialization.SelectedIndex = -1;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txt_NIC_TextChanged(object sender, EventArgs e)
        {
            //checks for the length of the text is equal to 10
            string str = txt_NIC.Text;
            if (txt_NIC.Text.Length == 10)
            {

                //checks whether the number of characters of the string is equal to 9 and ends with either 'V' or 'X'
                if ((str.Count(char.IsDigit) == 9) && (str.EndsWith("X", StringComparison.OrdinalIgnoreCase) || str.EndsWith("V", StringComparison.OrdinalIgnoreCase)))
                {
                    //checks whether the last two numbers of the birth year matches with the first two numbers of the nic
                    if (str.Substring(0, 2) != dtp_DOB.Value.Year.ToString().Substring(2, 2))
                    {
                        MessageBox.Show("Birth year doesn't match with the NIC");
                        return;
                    }

                    //if the user input matches with the requirements display the user input in black
                    txt_NIC.ForeColor = Color.Black;

                }
                else
                {
                    //if the NIC is invalid display the user input in red
                    txt_NIC.ForeColor = Color.Red;
                }
            }

            //checks whether the number of characters of the string is equal to 12
            else if (txt_NIC.Text.Length == 12)
            {
                //checks whether the number of characters of the string is equal to 12
                if (str.Count(char.IsDigit) == 12)
                {
                    // checks whether the four numbers of the birth year matches with the first four numbers of the nic
                    if (str.Substring(0, 4) != dtp_DOB.Value.Year.ToString().Substring(0, 4))
                    {
                        MessageBox.Show("Birth year doesn't match with the NIC");
                        return;
                    }

                    //if the user input matches with the requirements display the user input in black
                    txt_NIC.ForeColor = Color.Black;

                }

                else
                {
                    //if the NIC is invalid display the user input in red
                    txt_NIC.ForeColor = Color.Red;
                }

            }

            else
            {
                //if the NIC is invalid display the user input in red
                txt_NIC.ForeColor = Color.Red;
            }
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
            if (txt_NIC.Text == "")
            {
                MessageBox.Show("Enter the NIC!");
                return;
            }

            //Validating whether the field is null 
            if (dtp_DOB.Text == "")
            {
                MessageBox.Show("Select the Date of Birth!");
            }

            //Validating whether the field is null 
            if (txt_Address.Text == "")
            {
                MessageBox.Show("Enter the Address!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Contact.Text == "")
            {
                MessageBox.Show("Enter the Contact No.!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Nationality.Text == "")
            {
                MessageBox.Show("Enter the Nationality!");
                return;
            }

            //Validating whether the field is null 
            if (cmb_Degree.Text == "")
            {
                MessageBox.Show("Select a Degree Progamm!");
                return;
            }

            //Validating whether the field is null 
            if (cmb_Specialization.Text == "")
            {
                MessageBox.Show("Specialization Required!");
                return;
            }

            //Validating whether the field is null 
            if (cmb_Year.Text == "")
            {
                MessageBox.Show("Select the Year!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Set a Username!");
                return;
            }

            //Validating whether the field is null 
            if (txt_Password.Text == "")
            {
                MessageBox.Show("Set a Password!");
                return;
            }

            //Validating whether the field is null 
            if (txt_CPassword.Text == "")
            {
                MessageBox.Show("Confirm Password!");
                return;
            }


            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.InsertStudentDetails(txt_Fname.Text, txt_Lname.Text, txt_NIC.Text, Convert.ToDateTime(dtp_DOB.Value), txt_Address.Text, txt_Contact.Text, txt_Nationality.Text, cmb_Degree.Text, cmb_Specialization.Text, cmb_Year.Text, cmb_Semester.Text, txt_RegDate.Text, txt_Username.Text, txt_CPassword.Text);
            MessageBox.Show("Data Inserted Successfully.");

            //going back to form3
            this.Hide();
            User_Login form3 = new User_Login();
            form3.Show();

            /*//Empty value of the textbox
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox7.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtCPassword.Text = string.Empty;*/
        }

        private void LoadFee()
        {
            //lading the detatils from the database to the form
            string specialization = cmb_Specialization.SelectedValue.ToString();

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "select Fee from Specialization Where Specialization_Name= '" + specialization + "'";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            txt_SemFee.Text = dt.Rows[0]["Fee"].ToString();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txt_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_NIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_NIC.Text, "[^0-9]"))
            {
                txt_NIC.Clear();
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void cmb_Specialization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadFee();
        }

        private void txt_RegDate_TextChanged(object sender, EventArgs e)
        {
            txt_RegDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
        }

        //Method to validate the password
        public bool IsPasswordsEqual(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }

            return false;
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_CPassword_Leave(object sender, EventArgs e)
        {
            //calling the method to validate the password
            if (!IsPasswordsEqual(txt_Password.Text, txt_CPassword.Text))
            {
                MessageBox.Show("Enter same password in both");
            }
        }

        private void dtp_DOB_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format type and the CustomFormat string.
            dtp_DOB.Format = DateTimePickerFormat.Custom;
            dtp_DOB.CustomFormat = "yyyy/MM/dd";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        Control ctrl;

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Down)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }

                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }

                else
                    return;
            }

            else
            {
                if (e.KeyCode == Keys.Tab)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }

                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }

                else
                    return;
            }
            
        }

        private void Tot_D_Price_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
