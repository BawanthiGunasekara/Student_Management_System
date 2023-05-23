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
    public partial class Edit_Student_Info : Form
    {
        public Edit_Student_Info()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string student = cmb_SNo.SelectedValue.ToString();

            //update statement
            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "update Student_Info set First_Name='" + txt_Fname.Text + "',Last_Name='" + txt_Lname.Text + "',  DOB='" + dtp_DOB.Text + "', NIC='" + txt_NIC.Text + "' , Address='" + txt_Address.Text + "', Contact='" + txt_Contact.Text + "', Nationality='" + txt_Nationality.Text + "', Degree='" + txt_Degree.Text + "',  Specialization_Name='" + txt_Specialization.Text + "', Yr='" + txt_Yr.Text + "', Semester='" + txt_Sem.Text + "', Registered_Date='" + txt_RegDate.Text + "' where Student_No='" + student + "'";
            SqlCommand cmd = new SqlCommand(strCmd, con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();

            LoadStudentNo();

            //Open View_Student_Info Page
            this.Hide();
            View_Student_Info form3 = new View_Student_Info();
            form3.Show();
        }

        private void Edit_Student_Info_Load(object sender, EventArgs e)
        {
            //set the sate to the system date
            dtp_DOB.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "select Student_No from Student_Info";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmb_SNo.DataSource = ds.Tables[0];
            cmb_SNo.DisplayMember = "Student_No";
            cmb_SNo.ValueMember = "Student_No";
            cmb_SNo.SelectedIndex = -1;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cm_SNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //calling of the method LoadStudentNo()
            LoadStudentNo();
        }

        private void LoadStudentNo()
        {
            //loading the detatils from the database to the form
            string student = cmb_SNo.SelectedValue.ToString();

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            //retrieve data from the database Student_Info table according to the selected Student No.
            string strCmd = "select First_Name, Last_name, DOB, NIC, Address, Contact, Nationality, Degree, Specialization_Name, Yr, Semester, Registered_Date from Student_info Where Student_No= '" + student + "'";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            //setting the textboxes with the values saved in the database
            txt_Fname.Text = dt.Rows[0]["First_Name"].ToString();
            txt_Lname.Text = dt.Rows[0]["Last_Name"].ToString();
            txt_NIC.Text = dt.Rows[0]["NIC"].ToString();
            dtp_DOB.Text = dt.Rows[0]["DOB"].ToString();
            txt_Address.Text = dt.Rows[0]["Address"].ToString();
            txt_Contact.Text = dt.Rows[0]["Contact"].ToString();
            txt_Nationality.Text = dt.Rows[0]["Nationality"].ToString();
            txt_Degree.Text = dt.Rows[0]["Degree"].ToString();
            txt_Specialization.Text = dt.Rows[0]["Specialization_Name"].ToString();
            txt_Yr.Text = dt.Rows[0]["Yr"].ToString();
            txt_Sem.Text = dt.Rows[0]["Semester"].ToString();
            txt_RegDate.Text = dt.Rows[0]["Registered_Date"].ToString();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string student = cmb_SNo.SelectedValue.ToString();

            //making a connection
            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            //deleting the selected student details
            string strCmd = "delete Student_Info where Student_No='" + student + "'";
            SqlCommand cmd = new SqlCommand(strCmd, con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");

            //close connection
            con.Close();

            //Open form View_Student_Info
            this.Hide();
            View_Student_Info form3 = new View_Student_Info();
            form3.Show();
        }

        private void txt_RegDate_TextChanged(object sender, EventArgs e)
        {
           /* txt_RegDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");*/
        }
    }
}
