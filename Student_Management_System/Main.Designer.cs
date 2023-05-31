
namespace Student_Management_System
{
    partial class Main
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
            this.pic_Head = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Head
            // 
            this.pic_Head.Image = global::Student_Management_System.Properties.Resources._00291;
            this.pic_Head.Location = new System.Drawing.Point(-6, -2);
            this.pic_Head.Name = "pic_Head";
            this.pic_Head.Size = new System.Drawing.Size(1002, 578);
            this.pic_Head.TabIndex = 1;
            this.pic_Head.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1004, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Teal;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(395, 422);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(175, 51);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "Sign In";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.pic_Head);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_Head;
        private System.Windows.Forms.Button btn_Register;
    }
}