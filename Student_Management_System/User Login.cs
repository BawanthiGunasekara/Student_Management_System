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
    public partial class User_Login : Form
    {
        public SqlConnection con { get; private set; }
        public string s { get; private set; }

        public User_Login()
        {
            InitializeComponent();

            //set the colour of the textboxes
            this.txt_Username.BackColor = Color.White;
            this.txt_Password.BackColor = Color.White;

            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Directs to the Registration Form
            this.Hide();
            Registration_Desk register = new Registration_Desk();
            register.Show();
        }

        private void User_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //make a connection with the database
            SqlConnection connect = new SqlConnection(@"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=");
            DataTable dt1 = new DataTable();
            string strcmd1 = "";
            SqlDataAdapter cmd1 = new SqlDataAdapter();
            connect.Open();

            if (txt_Username.Text == "ADMIN" && txt_Password.Text == "admin")
            {
                //Directs to the Registration Form
                this.Hide();
                Admin_Panel admin = new Admin_Panel();
                admin.Show();

                //Empty value of the textbox
                txt_Username.Text = string.Empty;
                txt_Password.Text = string.Empty;
            }

            else
            {
                strcmd1 = ("SELECT usrName, Psword FROM Student_Info WHERE usrName='" + txt_Username.Text.Trim() + "' and Psword='" + txt_Password.Text.Trim() + "'");


                cmd1 = new SqlDataAdapter(new SqlCommand(strcmd1));
                cmd1.SelectCommand.Connection = connect;

                cmd1.Fill(dt1);

                string UserName = txt_Username.Text;

                if (dt1.Rows.Count > 0)
                {
                    Home homePg = new Home(UserName);
                    homePg.Show();

                    //Empty value of the textbox
                    txt_Username.Text = string.Empty;
                    txt_Password.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("invalid username or password");

                    //Empty value of the textbox
                    txt_Username.Text = string.Empty;
                    txt_Password.Text = string.Empty;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
