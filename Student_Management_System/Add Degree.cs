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
            dbc.InsertDegreeDetails(Cmb_Dtype.Text, txt_Dname.Text, tzt_Dduration.Text, txt_Tot_Pay.Text);
            MessageBox.Show("Data Inserted Successfully.");
        }

        private void Add_Degree_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_TotalFee_Click(object sender, EventArgs e)
        {

        }
    }
}
