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
    public partial class Add_Modules : Form
    {
        public Add_Modules()
        {
            InitializeComponent();
        }

        private void Add_Modules_Load(object sender, EventArgs e)
        {
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

            //calling for the method ViewModuleDetails
            ViewModuleDetails();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewModuleDetails()
        {
            // making connection to the database 
            DatabaseConnection dbc = new DatabaseConnection();
            DataTable dt = (DataTable)dbc.ViewModuleDetails();

            //binding the datasource for the datatable
            dtGrid_Modules.ReadOnly = true;
            dtGrid_Modules.DataSource = dt;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.InsertModules(cmb_Degree.Text, cmb_Specialization.Text, txt_Mname.Text, txt_Mcode.Text, cmb_Credits.Text, cmb_Year.Text, cmb_Semester.Text);
            MessageBox.Show("Data Inserted Successfully.");

            //going back to form11
            this.Hide();
            Add_Modules form11 = new Add_Modules();
            form11.Show();

            //Empty value of the textbox
            cmb_Degree.Text = string.Empty;
            cmb_Specialization.Text = string.Empty;
            txt_Mname.Text = string.Empty;
            txt_Mcode.Text = string.Empty;
            cmb_Credits.Text = string.Empty;
            cmb_Year.Text = string.Empty;
            cmb_Semester.Text = string.Empty;
        }
    }
}
