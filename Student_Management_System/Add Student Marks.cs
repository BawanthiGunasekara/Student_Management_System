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
    public partial class Add_Student_Marks : Form
    {
        public Add_Student_Marks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewStudentMarks(string student)
        {
            string Student_No = student;

            // making connection to the database 
            DatabaseConnection dbc = new DatabaseConnection();
            DataTable dt = (DataTable)dbc.ViewModuleMarksOfEachStudent(Student_No);

            //binding the datasource for the datatable
            dtGrid_Smarks.ReadOnly = true;
            dtGrid_Smarks.DataSource = dt;
        }

        private void Add_Student_Marks_Load(object sender, EventArgs e)
        {
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

        private void LoadStudentNo()
        {
            //loding the detatils from the database to the form
            string student = cmb_SNo.SelectedValue.ToString();

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "select First_Name,Last_name,Yr,Semester,Degree,Specialization_Name from Student_info Where Student_No= '" + student + "'";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            txt_Sname.Text = dt.Rows[0]["First_Name"].ToString() + " " + dt.Rows[0]["Last_Name"].ToString();
            txt_Yr_and_Sem.Text = "Yr " + dt.Rows[0]["Yr"].ToString() + " - " + "Semester " + dt.Rows[0]["Semester"].ToString();
            txt_Degree.Text = dt.Rows[0]["Degree"].ToString();
            txt_Specialization.Text = dt.Rows[0]["Specialization_Name"].ToString();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
