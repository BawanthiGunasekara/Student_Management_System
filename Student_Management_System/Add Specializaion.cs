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
    public partial class Add_Specializaion : Form
    {
        public Add_Specializaion()
        {
            InitializeComponent();
        }

        private void Add_Specializaion_Load(object sender, EventArgs e)
        {
            /*DatabaseConnection dbc = new DatabaseConnection();*/

            string connString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string strCmd = "select Degree_Name from Degree";
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmb_Dname.DataSource = ds.Tables[0];
            cmb_Dname.DisplayMember = "Degree_Name";
            cmb_Dname.ValueMember = "Degree_Name";
            cmb_Dname.SelectedIndex = -1;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Making the connection with the database
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.InsertSpecializationDetails(cmb_Dname.Text, txt_Specialization.Text, tzt_Fee.Text);
            MessageBox.Show("Data Inserted Successfully.");
        }
    }
}
