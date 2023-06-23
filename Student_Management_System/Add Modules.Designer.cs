
namespace Student_Management_System
{
    partial class Add_Modules
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
            this.cmb_Degree = new System.Windows.Forms.ComboBox();
            this.cmb_Specialization = new System.Windows.Forms.ComboBox();
            this.cmb_Credits = new System.Windows.Forms.ComboBox();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Semester = new System.Windows.Forms.ComboBox();
            this.txt_Mname = new System.Windows.Forms.TextBox();
            this.txt_Mcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtGrid_Modules = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Modules)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Degree
            // 
            this.cmb_Degree.FormattingEnabled = true;
            this.cmb_Degree.Location = new System.Drawing.Point(360, 61);
            this.cmb_Degree.Name = "cmb_Degree";
            this.cmb_Degree.Size = new System.Drawing.Size(444, 21);
            this.cmb_Degree.TabIndex = 0;
            // 
            // cmb_Specialization
            // 
            this.cmb_Specialization.FormattingEnabled = true;
            this.cmb_Specialization.Location = new System.Drawing.Point(360, 110);
            this.cmb_Specialization.Name = "cmb_Specialization";
            this.cmb_Specialization.Size = new System.Drawing.Size(444, 21);
            this.cmb_Specialization.TabIndex = 1;
            this.cmb_Specialization.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmb_Credits
            // 
            this.cmb_Credits.FormattingEnabled = true;
            this.cmb_Credits.Location = new System.Drawing.Point(360, 223);
            this.cmb_Credits.Name = "cmb_Credits";
            this.cmb_Credits.Size = new System.Drawing.Size(71, 21);
            this.cmb_Credits.TabIndex = 2;
            // 
            // cmb_Year
            // 
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_Year.Location = new System.Drawing.Point(509, 225);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(94, 21);
            this.cmb_Year.TabIndex = 3;
            // 
            // cmb_Semester
            // 
            this.cmb_Semester.FormattingEnabled = true;
            this.cmb_Semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmb_Semester.Location = new System.Drawing.Point(710, 223);
            this.cmb_Semester.Name = "cmb_Semester";
            this.cmb_Semester.Size = new System.Drawing.Size(94, 21);
            this.cmb_Semester.TabIndex = 4;
            // 
            // txt_Mname
            // 
            this.txt_Mname.Location = new System.Drawing.Point(360, 164);
            this.txt_Mname.Name = "txt_Mname";
            this.txt_Mname.Size = new System.Drawing.Size(200, 20);
            this.txt_Mname.TabIndex = 5;
            // 
            // txt_Mcode
            // 
            this.txt_Mcode.Location = new System.Drawing.Point(691, 164);
            this.txt_Mcode.Name = "txt_Mcode";
            this.txt_Mcode.Size = new System.Drawing.Size(113, 20);
            this.txt_Mcode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Specialization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Module Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Module Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Credits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Year";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Semester";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(729, 279);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtGrid_Modules
            // 
            this.dtGrid_Modules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Modules.Location = new System.Drawing.Point(36, 315);
            this.dtGrid_Modules.Name = "dtGrid_Modules";
            this.dtGrid_Modules.Size = new System.Drawing.Size(991, 213);
            this.dtGrid_Modules.TabIndex = 15;
            // 
            // Add_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 551);
            this.Controls.Add(this.dtGrid_Modules);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Mcode);
            this.Controls.Add(this.txt_Mname);
            this.Controls.Add(this.cmb_Semester);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Credits);
            this.Controls.Add(this.cmb_Specialization);
            this.Controls.Add(this.cmb_Degree);
            this.Name = "Add_Modules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Modules";
            this.Load += new System.EventHandler(this.Add_Modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Modules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Degree;
        private System.Windows.Forms.ComboBox cmb_Specialization;
        private System.Windows.Forms.ComboBox cmb_Credits;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Semester;
        private System.Windows.Forms.TextBox txt_Mname;
        private System.Windows.Forms.TextBox txt_Mcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dtGrid_Modules;
    }
}