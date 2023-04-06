
namespace Student_Management_System
{
    partial class Add_Degree
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
            this.lbl_DgreeType = new System.Windows.Forms.Label();
            this.lbl_DegreeName = new System.Windows.Forms.Label();
            this.lbl_NumOfYears = new System.Windows.Forms.Label();
            this.Cmb_Dtype = new System.Windows.Forms.ComboBox();
            this.txt_Dname = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_TotalFee = new System.Windows.Forms.Label();
            this.txt_Tot_Pay = new System.Windows.Forms.TextBox();
            this.pic_DType = new System.Windows.Forms.PictureBox();
            this.pic_DName = new System.Windows.Forms.PictureBox();
            this.pic_Payment = new System.Windows.Forms.PictureBox();
            this.pic_TimePeriod = new System.Windows.Forms.PictureBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DgreeType
            // 
            this.lbl_DgreeType.AutoSize = true;
            this.lbl_DgreeType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DgreeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DgreeType.ForeColor = System.Drawing.Color.White;
            this.lbl_DgreeType.Location = new System.Drawing.Point(80, 81);
            this.lbl_DgreeType.Name = "lbl_DgreeType";
            this.lbl_DgreeType.Size = new System.Drawing.Size(111, 20);
            this.lbl_DgreeType.TabIndex = 0;
            this.lbl_DgreeType.Text = "Degree Type";
            this.lbl_DgreeType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_DegreeName
            // 
            this.lbl_DegreeName.AutoSize = true;
            this.lbl_DegreeName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DegreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DegreeName.ForeColor = System.Drawing.Color.White;
            this.lbl_DegreeName.Location = new System.Drawing.Point(80, 147);
            this.lbl_DegreeName.Name = "lbl_DegreeName";
            this.lbl_DegreeName.Size = new System.Drawing.Size(119, 20);
            this.lbl_DegreeName.TabIndex = 1;
            this.lbl_DegreeName.Text = "Degree Name";
            // 
            // lbl_NumOfYears
            // 
            this.lbl_NumOfYears.AutoSize = true;
            this.lbl_NumOfYears.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumOfYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumOfYears.ForeColor = System.Drawing.Color.White;
            this.lbl_NumOfYears.Location = new System.Drawing.Point(80, 209);
            this.lbl_NumOfYears.Name = "lbl_NumOfYears";
            this.lbl_NumOfYears.Size = new System.Drawing.Size(103, 20);
            this.lbl_NumOfYears.TabIndex = 2;
            this.lbl_NumOfYears.Text = "Time Period";
            // 
            // Cmb_Dtype
            // 
            this.Cmb_Dtype.BackColor = System.Drawing.Color.White;
            this.Cmb_Dtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Dtype.FormattingEnabled = true;
            this.Cmb_Dtype.Location = new System.Drawing.Point(233, 81);
            this.Cmb_Dtype.Name = "Cmb_Dtype";
            this.Cmb_Dtype.Size = new System.Drawing.Size(256, 26);
            this.Cmb_Dtype.TabIndex = 3;
            this.Cmb_Dtype.SelectionChangeCommitted += new System.EventHandler(this.Cmb_Dtype_SelectionChangeCommitted);
            // 
            // txt_Dname
            // 
            this.txt_Dname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dname.Location = new System.Drawing.Point(233, 147);
            this.txt_Dname.Name = "txt_Dname";
            this.txt_Dname.Size = new System.Drawing.Size(256, 22);
            this.txt_Dname.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(430, 322);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_TotalFee
            // 
            this.lbl_TotalFee.AutoSize = true;
            this.lbl_TotalFee.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalFee.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalFee.Location = new System.Drawing.Point(80, 273);
            this.lbl_TotalFee.Name = "lbl_TotalFee";
            this.lbl_TotalFee.Size = new System.Drawing.Size(123, 20);
            this.lbl_TotalFee.TabIndex = 8;
            this.lbl_TotalFee.Text = "Total Payment";
            this.lbl_TotalFee.Click += new System.EventHandler(this.lbl_TotalFee_Click);
            // 
            // txt_Tot_Pay
            // 
            this.txt_Tot_Pay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tot_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tot_Pay.Location = new System.Drawing.Point(233, 273);
            this.txt_Tot_Pay.Name = "txt_Tot_Pay";
            this.txt_Tot_Pay.Size = new System.Drawing.Size(256, 22);
            this.txt_Tot_Pay.TabIndex = 9;
            this.txt_Tot_Pay.Text = ".00/=";
            this.txt_Tot_Pay.TextChanged += new System.EventHandler(this.txt_Tot_Pay_TextChanged);
            // 
            // pic_DType
            // 
            this.pic_DType.BackColor = System.Drawing.Color.Transparent;
            this.pic_DType.BackgroundImage = global::Student_Management_System.Properties.Resources.Rectangle_3__2_;
            this.pic_DType.Location = new System.Drawing.Point(219, 74);
            this.pic_DType.Name = "pic_DType";
            this.pic_DType.Size = new System.Drawing.Size(286, 41);
            this.pic_DType.TabIndex = 11;
            this.pic_DType.TabStop = false;
            // 
            // pic_DName
            // 
            this.pic_DName.BackColor = System.Drawing.Color.Transparent;
            this.pic_DName.BackgroundImage = global::Student_Management_System.Properties.Resources.Rectangle_32;
            this.pic_DName.Location = new System.Drawing.Point(219, 137);
            this.pic_DName.Name = "pic_DName";
            this.pic_DName.Size = new System.Drawing.Size(286, 41);
            this.pic_DName.TabIndex = 12;
            this.pic_DName.TabStop = false;
            // 
            // pic_Payment
            // 
            this.pic_Payment.BackColor = System.Drawing.Color.Transparent;
            this.pic_Payment.BackgroundImage = global::Student_Management_System.Properties.Resources.Rectangle_34;
            this.pic_Payment.Location = new System.Drawing.Point(219, 262);
            this.pic_Payment.Name = "pic_Payment";
            this.pic_Payment.Size = new System.Drawing.Size(286, 41);
            this.pic_Payment.TabIndex = 14;
            this.pic_Payment.TabStop = false;
            // 
            // pic_TimePeriod
            // 
            this.pic_TimePeriod.BackColor = System.Drawing.Color.Transparent;
            this.pic_TimePeriod.BackgroundImage = global::Student_Management_System.Properties.Resources.Rectangle_33;
            this.pic_TimePeriod.Location = new System.Drawing.Point(219, 199);
            this.pic_TimePeriod.Name = "pic_TimePeriod";
            this.pic_TimePeriod.Size = new System.Drawing.Size(286, 41);
            this.pic_TimePeriod.TabIndex = 13;
            this.pic_TimePeriod.TabStop = false;
            // 
            // txt_Duration
            // 
            this.txt_Duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Duration.Location = new System.Drawing.Point(233, 209);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(256, 22);
            this.txt_Duration.TabIndex = 15;
            // 
            // Add_Degree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Management_System.Properties.Resources.Group_2;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.txt_Dname);
            this.Controls.Add(this.txt_Tot_Pay);
            this.Controls.Add(this.lbl_TotalFee);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Cmb_Dtype);
            this.Controls.Add(this.lbl_NumOfYears);
            this.Controls.Add(this.lbl_DegreeName);
            this.Controls.Add(this.lbl_DgreeType);
            this.Controls.Add(this.pic_DType);
            this.Controls.Add(this.pic_DName);
            this.Controls.Add(this.pic_TimePeriod);
            this.Controls.Add(this.pic_Payment);
            this.Name = "Add_Degree";
            this.Text = "Add_Degree";
            this.Load += new System.EventHandler(this.Add_Degree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_DType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TimePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DgreeType;
        private System.Windows.Forms.Label lbl_DegreeName;
        private System.Windows.Forms.Label lbl_NumOfYears;
        private System.Windows.Forms.ComboBox Cmb_Dtype;
        private System.Windows.Forms.TextBox txt_Dname;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_TotalFee;
        private System.Windows.Forms.TextBox txt_Tot_Pay;
        private System.Windows.Forms.PictureBox pic_DType;
        private System.Windows.Forms.PictureBox pic_DName;
        private System.Windows.Forms.PictureBox pic_Payment;
        private System.Windows.Forms.PictureBox pic_TimePeriod;
        private System.Windows.Forms.TextBox txt_Duration;
    }
}