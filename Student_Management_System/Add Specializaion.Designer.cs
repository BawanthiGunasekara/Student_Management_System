
namespace Student_Management_System
{
    partial class Add_Specializaion
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
            this.cmb_Dname = new System.Windows.Forms.ComboBox();
            this.txt_Specialization = new System.Windows.Forms.TextBox();
            this.tzt_Fee = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Dname
            // 
            this.cmb_Dname.FormattingEnabled = true;
            this.cmb_Dname.Location = new System.Drawing.Point(128, 184);
            this.cmb_Dname.Name = "cmb_Dname";
            this.cmb_Dname.Size = new System.Drawing.Size(211, 21);
            this.cmb_Dname.TabIndex = 0;
            // 
            // txt_Specialization
            // 
            this.txt_Specialization.Location = new System.Drawing.Point(128, 229);
            this.txt_Specialization.Name = "txt_Specialization";
            this.txt_Specialization.Size = new System.Drawing.Size(211, 20);
            this.txt_Specialization.TabIndex = 1;
            // 
            // tzt_Fee
            // 
            this.tzt_Fee.Location = new System.Drawing.Point(128, 282);
            this.tzt_Fee.Name = "tzt_Fee";
            this.tzt_Fee.Size = new System.Drawing.Size(211, 20);
            this.tzt_Fee.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(254, 328);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Degree Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Specialization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Specialization";
            // 
            // Add_Specializaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.Group_2__4_;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tzt_Fee);
            this.Controls.Add(this.txt_Specialization);
            this.Controls.Add(this.cmb_Dname);
            this.Name = "Add_Specializaion";
            this.Text = "Add_Specializaion";
            this.Load += new System.EventHandler(this.Add_Specializaion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Dname;
        private System.Windows.Forms.TextBox txt_Specialization;
        private System.Windows.Forms.TextBox tzt_Fee;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}