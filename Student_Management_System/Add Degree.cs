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
    public partial class Add_Degree : Form
    {
        public Add_Degree()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.InsertDegreeDetails(Cmb_Dtype.Text, txt_Dname.Text, txt_Duration.Text, txt_Tot_Pay.Text);
            MessageBox.Show("Data Inserted Successfully.");

            this.Hide();
        }

        private void Add_Degree_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "select D_Type_Name from Degree_Types";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Cmb_Dtype.DataSource = ds.Tables[0];
            Cmb_Dtype.DisplayMember = "D_Type_Name";
            Cmb_Dtype.ValueMember = "D_Type_Name";
            Cmb_Dtype.SelectedIndex = -1;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void LoadDegreeDetails()
        {
            //loading the detatils from the database to the form
            string D_Name = Cmb_Dtype.SelectedValue.ToString();

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            //retrieve data from the database Degree_Types table according to the selected Degree Name.
            string strCmd = "select Duration from Degree_Types Where D_Type_Name = '" + D_Name + "'";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            //setting the textboxes with the values saved in the database
            txt_Duration.Text = dt.Rows[0]["Duration"].ToString();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void lbl_TotalFee_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Dtype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //calling of the method LoadDegreeDetails()
            LoadDegreeDetails();
        }

        private void txt_Tot_Pay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
