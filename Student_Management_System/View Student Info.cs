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
    public partial class View_Student_Info : Form
    {
        private readonly int Student_No;

        public View_Student_Info()
        {
            InitializeComponent();
        }

        private void View_Student_Info_Load(object sender, EventArgs e)
        {
            //calling for the method ViewDetails
            ViewDetails();
        }

        private void ViewDetails()
        {
            // making connection to the database 
            DatabaseConnection dbc = new DatabaseConnection();
            DataTable dt = (DataTable)dbc.ViewStudentDetails();

            //binding the datasource for the datatable
            dtGrid_SInfo.ReadOnly = true;
            dtGrid_SInfo.DataSource = dt;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //calling for the method ViewDetails
            ViewDetails();
        }

        private class grdData
        {
            public static DataTable DataSource { get; internal set; }
            public static bool ReadOnly { get; internal set; }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            //going back to form2
            this.Hide();
            Add_Student_Marks form2 = new Add_Student_Marks();
            form2.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //going back to form5
            this.Hide();
            Edit_Student_Info form5 = new Edit_Student_Info();
            form5.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //going back to form1
            this.Hide();
            Add_Student form1 = new Add_Student();
            form1.Show();
        }
    }
}
