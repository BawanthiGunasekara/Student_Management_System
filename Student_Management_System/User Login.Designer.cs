
namespace Student_Management_System
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pnl_Sign_In = new System.Windows.Forms.Panel();
            this.lbl_Sign_In = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_Sign_In.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.AcceptsReturn = true;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(538, 403);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(177, 19);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Student_Management_System.Properties.Resources.Group_9;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Location = new System.Drawing.Point(106, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(770, 492);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // txt_usrname
            // 
            this.txt_usrname.BackColor = System.Drawing.Color.White;
            this.txt_usrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usrname.Location = new System.Drawing.Point(637, 207);
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(179, 13);
            this.txt_usrname.TabIndex = 17;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Location = new System.Drawing.Point(637, 266);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(179, 13);
            this.txt_Password.TabIndex = 18;
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // pnl_Sign_In
            // 
            this.pnl_Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnl_Sign_In.Controls.Add(this.lbl_Sign_In);
            this.pnl_Sign_In.Location = new System.Drawing.Point(555, 370);
            this.pnl_Sign_In.Name = "pnl_Sign_In";
            this.pnl_Sign_In.Size = new System.Drawing.Size(247, 36);
            this.pnl_Sign_In.TabIndex = 19;
            this.pnl_Sign_In.Click += new System.EventHandler(this.pnl_Sign_In_Click);
            this.pnl_Sign_In.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Sign_In_Paint);
            // 
            // lbl_Sign_In
            // 
            this.lbl_Sign_In.AutoSize = true;
            this.lbl_Sign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sign_In.ForeColor = System.Drawing.Color.White;
            this.lbl_Sign_In.Location = new System.Drawing.Point(77, 5);
            this.lbl_Sign_In.Name = "lbl_Sign_In";
            this.lbl_Sign_In.Size = new System.Drawing.Size(85, 25);
            this.lbl_Sign_In.TabIndex = 0;
            this.lbl_Sign_In.Text = "Sign In";
            this.lbl_Sign_In.Click += new System.EventHandler(this.lbl_Sign_In_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(37)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(727, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(37)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(717, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Forgot Password";
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Sign_In);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_usrname);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_Username);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "User_Login";
            this.Text = "User_Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_Sign_In.ResumeLayout(false);
            this.pnl_Sign_In.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_usrname;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel pnl_Sign_In;
        private System.Windows.Forms.Label lbl_Sign_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}