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
    public partial class Degree_Programs : Form
    {

        //declaring an array and initialization 
        string[] images = null;

        //set the counter to 0
        int counter = 0;
        
        public string txtUsername { get; private set; }

        public Degree_Programs()
        {
            InitializeComponent();
        }

        private void Degree_Programs_Load(object sender, EventArgs e)
        {

            //images slideshow with the timer set to 4500
            images = Directory.GetFiles(@"D:\Student_Management_System\Student_Management_System\Resources\Header");
            Timer T = new Timer();
            T.Interval = 4000;
            T.Tick += new EventHandler(PlayTime);
            T.Start();
        }

        private void pic_Humanities_Click(object sender, EventArgs e)
        {
            //Directs to the Form
            this.Hide();
            Humanities_and_Sciences humanities = new Humanities_and_Sciences();
            humanities.Show();
        }

        void PlayTime(object sender, EventArgs e)
        {
            pic_Header.ImageLocation = images[counter++];

            // Handling out of Bounds
            if (counter >= images.Length) counter = 0;
        }

        private void pic_Computing_Click(object sender, EventArgs e)
        {
            //Directs to the Form
            this.Hide();
            Computing computing = new Computing();
            computing.Show();
        }

        private void pic_Engineering_Click(object sender, EventArgs e)
        {
            //Directs to the Form
            this.Hide();
            Engineering engineering = new Engineering();
            engineering.Show();
        }

        private void pic_Archi_Click(object sender, EventArgs e)
        {
            //Directs to the Form
            this.Hide();
            Architecture archi = new Architecture();
            archi.Show();
        }

        private void pic_Business_Click(object sender, EventArgs e)
        {
            //Directs to the Form
            this.Hide();
            Business bussiness = new Business();
            bussiness.Show();
        }

        private void pic_Header_Click(object sender, EventArgs e)
        {

        }

        private void pic_Computing_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pnl_Computing_MouseHover(object sender, EventArgs e)
        {
          

        }
    }
}
