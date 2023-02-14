using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Home : Form
    {
        //declaring an array and initialization 
        string[] images = null;

        //set the counter to 0
        int counter = 0;

        public string UserName { get; }

        public Home()
        {
            InitializeComponent();
            //set the username used to log in to the label
            lbl_Username.Text = "Hii.. " + (UserName);
        }

        public Home(string userName)
        {
            UserName = userName;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //images slideshow with the timer set to 4500
            images = Directory.GetFiles(@"D:\AnalystProgrammer_PracticalTest\AnalystProgrammer_PracticalTest\Resources\IMG");
            Timer T = new Timer();
            T.Interval = 4500;
            T.Tick += new EventHandler(PlayTime);
            T.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pic_Humanities_Click(object sender, EventArgs e)
        {
            //going back to the Form
            this.Hide();
            Humanities_and_Sciences humanities = new Humanities_and_Sciences();
            humanities.Show();

        }



        void PlayTime(object sender, EventArgs e)
        {
            pic_Head.ImageLocation = images[counter++];

            // Handling out of Bounds
            if (counter >= images.Length) counter = 0;
        }

        private void pic_Engineering_Click(object sender, EventArgs e)
        {
            //going back to the Form
            this.Hide();
            Engineering engineering = new Engineering();
            engineering.Show();
        }

        private void pic_Computing_Click(object sender, EventArgs e)
        {
            //going back to the Form
            this.Hide();
            Computing computing = new Computing();
            computing.Show();
        }

        private void pic_Archi_Click(object sender, EventArgs e)
        {
            //going back to the Form
            this.Hide();
            Architecture architecture = new Architecture();
            architecture.Show();
        }

        private void pic_Business_Click(object sender, EventArgs e)
        {
            //going back to the Form
            this.Hide();
            Business business = new Business();
            business.Show();
        }
    }
}
