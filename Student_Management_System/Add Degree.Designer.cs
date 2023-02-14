
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_Dtype = new System.Windows.Forms.ComboBox();
            this.txt_Dname = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tzt_Dduration = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degree Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Degree Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Period";
            // 
            // Cmb_Dtype
            // 
            this.Cmb_Dtype.FormattingEnabled = true;
            this.Cmb_Dtype.Location = new System.Drawing.Point(457, 79);
            this.Cmb_Dtype.Name = "Cmb_Dtype";
            this.Cmb_Dtype.Size = new System.Drawing.Size(244, 21);
            this.Cmb_Dtype.TabIndex = 3;
            // 
            // txt_Dname
            // 
            this.txt_Dname.Location = new System.Drawing.Point(457, 147);
            this.txt_Dname.Name = "txt_Dname";
            this.txt_Dname.Size = new System.Drawing.Size(244, 20);
            this.txt_Dname.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(626, 252);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tzt_Dduration
            // 
            this.tzt_Dduration.FormattingEnabled = true;
            this.tzt_Dduration.Location = new System.Drawing.Point(457, 207);
            this.tzt_Dduration.Name = "tzt_Dduration";
            this.tzt_Dduration.Size = new System.Drawing.Size(244, 21);
            this.tzt_Dduration.TabIndex = 7;
            // 
            // Add_Degree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.tzt_Dduration);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Dname);
            this.Controls.Add(this.Cmb_Dtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Degree";
            this.Text = "Add_Degree";
            this.Load += new System.EventHandler(this.Add_Degree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_Dtype;
        private System.Windows.Forms.TextBox txt_Dname;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox tzt_Dduration;
    }
}