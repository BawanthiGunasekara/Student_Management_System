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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonColorChangeByClick(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.FromArgb(255, 215, 0);
            btn2.BackColor = Color.FromArgb(255, 215, 0);
            btn3.BackColor = Color.FromArgb(255, 215, 0);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            ButtonColorChangeByClick(home_btn, teachers_btn, student_btn);
        }
    }
}
