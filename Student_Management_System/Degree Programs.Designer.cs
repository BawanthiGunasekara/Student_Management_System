
namespace Student_Management_System
{
    partial class Degree_Programs
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
            this.pic_Humanities = new System.Windows.Forms.PictureBox();
            this.pic_Archi = new System.Windows.Forms.PictureBox();
            this.pic_Business = new System.Windows.Forms.PictureBox();
            this.pic_Engineering = new System.Windows.Forms.PictureBox();
            this.pic_Header = new System.Windows.Forms.PictureBox();
            this.pic_Computing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Humanities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Archi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Business)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Engineering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Computing)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Humanities
            // 
            this.pic_Humanities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Humanities.Image = global::Student_Management_System.Properties.Resources._0026;
            this.pic_Humanities.Location = new System.Drawing.Point(836, 285);
            this.pic_Humanities.Name = "pic_Humanities";
            this.pic_Humanities.Size = new System.Drawing.Size(186, 341);
            this.pic_Humanities.TabIndex = 6;
            this.pic_Humanities.TabStop = false;
            this.pic_Humanities.Click += new System.EventHandler(this.pic_Humanities_Click);
            // 
            // pic_Archi
            // 
            this.pic_Archi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Archi.Image = global::Student_Management_System.Properties.Resources._0023;
            this.pic_Archi.Location = new System.Drawing.Point(634, 285);
            this.pic_Archi.Name = "pic_Archi";
            this.pic_Archi.Size = new System.Drawing.Size(186, 341);
            this.pic_Archi.TabIndex = 5;
            this.pic_Archi.TabStop = false;
            this.pic_Archi.Click += new System.EventHandler(this.pic_Archi_Click);
            // 
            // pic_Business
            // 
            this.pic_Business.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Business.Image = global::Student_Management_System.Properties.Resources._0027;
            this.pic_Business.Location = new System.Drawing.Point(431, 285);
            this.pic_Business.Name = "pic_Business";
            this.pic_Business.Size = new System.Drawing.Size(186, 341);
            this.pic_Business.TabIndex = 4;
            this.pic_Business.TabStop = false;
            this.pic_Business.Click += new System.EventHandler(this.pic_Business_Click);
            // 
            // pic_Engineering
            // 
            this.pic_Engineering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Engineering.Image = global::Student_Management_System.Properties.Resources._0025;
            this.pic_Engineering.Location = new System.Drawing.Point(224, 285);
            this.pic_Engineering.Name = "pic_Engineering";
            this.pic_Engineering.Size = new System.Drawing.Size(186, 341);
            this.pic_Engineering.TabIndex = 3;
            this.pic_Engineering.TabStop = false;
            this.pic_Engineering.Click += new System.EventHandler(this.pic_Engineering_Click);
            // 
            // pic_Header
            // 
            this.pic_Header.Image = global::Student_Management_System.Properties.Resources._11;
            this.pic_Header.Location = new System.Drawing.Point(1, 0);
            this.pic_Header.Name = "pic_Header";
            this.pic_Header.Size = new System.Drawing.Size(1033, 269);
            this.pic_Header.TabIndex = 2;
            this.pic_Header.TabStop = false;
            this.pic_Header.Click += new System.EventHandler(this.pic_Header_Click);
            // 
            // pic_Computing
            // 
            this.pic_Computing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Computing.Image = global::Student_Management_System.Properties.Resources._0024;
            this.pic_Computing.Location = new System.Drawing.Point(21, 284);
            this.pic_Computing.Name = "pic_Computing";
            this.pic_Computing.Size = new System.Drawing.Size(186, 341);
            this.pic_Computing.TabIndex = 1;
            this.pic_Computing.TabStop = false;
            this.pic_Computing.Click += new System.EventHandler(this.pic_Computing_Click);
            // 
            // Degree_Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 638);
            this.Controls.Add(this.pic_Humanities);
            this.Controls.Add(this.pic_Archi);
            this.Controls.Add(this.pic_Business);
            this.Controls.Add(this.pic_Engineering);
            this.Controls.Add(this.pic_Header);
            this.Controls.Add(this.pic_Computing);
            this.Name = "Degree_Programs";
            this.Text = "Degree_Programs";
            this.Load += new System.EventHandler(this.Degree_Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Humanities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Archi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Business)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Engineering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Computing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Computing;
        private System.Windows.Forms.PictureBox pic_Header;
        private System.Windows.Forms.PictureBox pic_Engineering;
        private System.Windows.Forms.PictureBox pic_Business;
        private System.Windows.Forms.PictureBox pic_Archi;
        private System.Windows.Forms.PictureBox pic_Humanities;
    }
}