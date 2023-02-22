
namespace Student_Management_System
{
    partial class Registration_Desk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_Guest = new System.Windows.Forms.PictureBox();
            this.Pic_Student = new System.Windows.Forms.PictureBox();
            this.Pic_Lecturer = new System.Windows.Forms.PictureBox();
            this.Pic_Admin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Guest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Admin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Guest
            // 
            this.pic_Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Guest.Image = global::Student_Management_System.Properties.Resources.add_user__3_;
            this.pic_Guest.Location = new System.Drawing.Point(14, 15);
            this.pic_Guest.Name = "pic_Guest";
            this.pic_Guest.Size = new System.Drawing.Size(128, 128);
            this.pic_Guest.TabIndex = 0;
            this.pic_Guest.TabStop = false;
            this.pic_Guest.Click += new System.EventHandler(this.pic_Guest_Click);
            // 
            // Pic_Student
            // 
            this.Pic_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Student.Image = global::Student_Management_System.Properties.Resources.graduated;
            this.Pic_Student.Location = new System.Drawing.Point(14, 15);
            this.Pic_Student.Name = "Pic_Student";
            this.Pic_Student.Size = new System.Drawing.Size(128, 128);
            this.Pic_Student.TabIndex = 1;
            this.Pic_Student.TabStop = false;
            this.Pic_Student.Click += new System.EventHandler(this.Pic_Student_Click);
            // 
            // Pic_Lecturer
            // 
            this.Pic_Lecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Lecturer.Image = global::Student_Management_System.Properties.Resources.conference;
            this.Pic_Lecturer.Location = new System.Drawing.Point(15, 18);
            this.Pic_Lecturer.Name = "Pic_Lecturer";
            this.Pic_Lecturer.Size = new System.Drawing.Size(128, 128);
            this.Pic_Lecturer.TabIndex = 2;
            this.Pic_Lecturer.TabStop = false;
            this.Pic_Lecturer.Click += new System.EventHandler(this.Pic_Lecturer_Click);
            // 
            // Pic_Admin
            // 
            this.Pic_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Admin.Image = global::Student_Management_System.Properties.Resources.unauthorized_person;
            this.Pic_Admin.Location = new System.Drawing.Point(13, 15);
            this.Pic_Admin.Name = "Pic_Admin";
            this.Pic_Admin.Size = new System.Drawing.Size(128, 128);
            this.Pic_Admin.TabIndex = 3;
            this.Pic_Admin.TabStop = false;
            this.Pic_Admin.Click += new System.EventHandler(this.Pic_Admin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pic_Guest);
            this.panel1.Location = new System.Drawing.Point(40, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 186);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guest";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Pic_Student);
            this.panel2.Location = new System.Drawing.Point(233, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 186);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.Pic_Lecturer);
            this.panel3.Location = new System.Drawing.Point(422, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 186);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lecturer";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(161, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.Pic_Admin);
            this.panel5.Location = new System.Drawing.Point(608, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 186);
            this.panel5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(305, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Registration Desk";
            // 
            // Registration_Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.ezgif1;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Registration_Desk";
            this.Text = "Registration_Desk";
            this.Load += new System.EventHandler(this.Registration_Desk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Guest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Admin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Guest;
        private System.Windows.Forms.PictureBox Pic_Student;
        private System.Windows.Forms.PictureBox Pic_Lecturer;
        private System.Windows.Forms.PictureBox Pic_Admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}