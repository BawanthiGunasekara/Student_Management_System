
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
            this.tzt_Dduration = new System.Windows.Forms.ComboBox();
            this.lbl_TotalFee = new System.Windows.Forms.Label();
            this.txt_Tot_Pay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_DgreeType
            // 
            this.lbl_DgreeType.AutoSize = true;
            this.lbl_DgreeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DgreeType.Location = new System.Drawing.Point(325, 80);
            this.lbl_DgreeType.Name = "lbl_DgreeType";
            this.lbl_DgreeType.Size = new System.Drawing.Size(100, 20);
            this.lbl_DgreeType.TabIndex = 0;
            this.lbl_DgreeType.Text = "Degree Type";
            this.lbl_DgreeType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_DegreeName
            // 
            this.lbl_DegreeName.AutoSize = true;
            this.lbl_DegreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DegreeName.Location = new System.Drawing.Point(325, 147);
            this.lbl_DegreeName.Name = "lbl_DegreeName";
            this.lbl_DegreeName.Size = new System.Drawing.Size(108, 20);
            this.lbl_DegreeName.TabIndex = 1;
            this.lbl_DegreeName.Text = "Degree Name";
            // 
            // lbl_NumOfYears
            // 
            this.lbl_NumOfYears.AutoSize = true;
            this.lbl_NumOfYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumOfYears.Location = new System.Drawing.Point(325, 209);
            this.lbl_NumOfYears.Name = "lbl_NumOfYears";
            this.lbl_NumOfYears.Size = new System.Drawing.Size(92, 20);
            this.lbl_NumOfYears.TabIndex = 2;
            this.lbl_NumOfYears.Text = "Time Period";
            // 
            // Cmb_Dtype
            // 
            this.Cmb_Dtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Dtype.FormattingEnabled = true;
            this.Cmb_Dtype.Location = new System.Drawing.Point(457, 79);
            this.Cmb_Dtype.Name = "Cmb_Dtype";
            this.Cmb_Dtype.Size = new System.Drawing.Size(244, 28);
            this.Cmb_Dtype.TabIndex = 3;
            // 
            // txt_Dname
            // 
            this.txt_Dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dname.Location = new System.Drawing.Point(457, 147);
            this.txt_Dname.Name = "txt_Dname";
            this.txt_Dname.Size = new System.Drawing.Size(244, 26);
            this.txt_Dname.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(626, 376);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tzt_Dduration
            // 
            this.tzt_Dduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tzt_Dduration.FormattingEnabled = true;
            this.tzt_Dduration.Location = new System.Drawing.Point(457, 207);
            this.tzt_Dduration.Name = "tzt_Dduration";
            this.tzt_Dduration.Size = new System.Drawing.Size(244, 28);
            this.tzt_Dduration.TabIndex = 7;
            // 
            // lbl_TotalFee
            // 
            this.lbl_TotalFee.AutoSize = true;
            this.lbl_TotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalFee.Location = new System.Drawing.Point(325, 273);
            this.lbl_TotalFee.Name = "lbl_TotalFee";
            this.lbl_TotalFee.Size = new System.Drawing.Size(110, 20);
            this.lbl_TotalFee.TabIndex = 8;
            this.lbl_TotalFee.Text = "Total Payment";
            this.lbl_TotalFee.Click += new System.EventHandler(this.lbl_TotalFee_Click);
            // 
            // txt_Tot_Pay
            // 
            this.txt_Tot_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tot_Pay.Location = new System.Drawing.Point(457, 272);
            this.txt_Tot_Pay.Name = "txt_Tot_Pay";
            this.txt_Tot_Pay.Size = new System.Drawing.Size(244, 26);
            this.txt_Tot_Pay.TabIndex = 9;
            // 
            // Add_Degree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.txt_Tot_Pay);
            this.Controls.Add(this.lbl_TotalFee);
            this.Controls.Add(this.tzt_Dduration);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Dname);
            this.Controls.Add(this.Cmb_Dtype);
            this.Controls.Add(this.lbl_NumOfYears);
            this.Controls.Add(this.lbl_DegreeName);
            this.Controls.Add(this.lbl_DgreeType);
            this.Name = "Add_Degree";
            this.Text = "Add_Degree";
            this.Load += new System.EventHandler(this.Add_Degree_Load);
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
        private System.Windows.Forms.ComboBox tzt_Dduration;
        private System.Windows.Forms.Label lbl_TotalFee;
        private System.Windows.Forms.TextBox txt_Tot_Pay;
    }
}