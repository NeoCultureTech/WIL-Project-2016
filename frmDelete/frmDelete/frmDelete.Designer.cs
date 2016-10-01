namespace frmDelete
{
    partial class frmDelete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpDelAppointDate = new System.Windows.Forms.DateTimePicker();
            this.txtDelAppointTime = new System.Windows.Forms.TextBox();
            this.txtDelContactNum = new System.Windows.Forms.TextBox();
            this.txtDelSurname = new System.Windows.Forms.TextBox();
            this.txtDelName = new System.Windows.Forms.TextBox();
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpDelAppointDate
            // 
            this.dtpDelAppointDate.Location = new System.Drawing.Point(21, 157);
            this.dtpDelAppointDate.Name = "dtpDelAppointDate";
            this.dtpDelAppointDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDelAppointDate.TabIndex = 12;
            // 
            // txtDelAppointTime
            // 
            this.txtDelAppointTime.Location = new System.Drawing.Point(161, 97);
            this.txtDelAppointTime.Name = "txtDelAppointTime";
            this.txtDelAppointTime.Size = new System.Drawing.Size(101, 26);
            this.txtDelAppointTime.TabIndex = 11;
            // 
            // txtDelContactNum
            // 
            this.txtDelContactNum.Location = new System.Drawing.Point(21, 97);
            this.txtDelContactNum.Name = "txtDelContactNum";
            this.txtDelContactNum.Size = new System.Drawing.Size(100, 26);
            this.txtDelContactNum.TabIndex = 10;
            // 
            // txtDelSurname
            // 
            this.txtDelSurname.Location = new System.Drawing.Point(294, 32);
            this.txtDelSurname.Name = "txtDelSurname";
            this.txtDelSurname.Size = new System.Drawing.Size(100, 26);
            this.txtDelSurname.TabIndex = 9;
            // 
            // txtDelName
            // 
            this.txtDelName.Location = new System.Drawing.Point(161, 32);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(100, 26);
            this.txtDelName.TabIndex = 8;
            // 
            // txtDelID
            // 
            this.txtDelID.Location = new System.Drawing.Point(21, 32);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(100, 26);
            this.txtDelID.TabIndex = 7;
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 217);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtpDelAppointDate);
            this.Controls.Add(this.txtDelAppointTime);
            this.Controls.Add(this.txtDelContactNum);
            this.Controls.Add(this.txtDelSurname);
            this.Controls.Add(this.txtDelName);
            this.Controls.Add(this.txtDelID);
            this.Name = "frmDelete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpDelAppointDate;
        private System.Windows.Forms.TextBox txtDelAppointTime;
        private System.Windows.Forms.TextBox txtDelContactNum;
        private System.Windows.Forms.TextBox txtDelSurname;
        private System.Windows.Forms.TextBox txtDelName;
        private System.Windows.Forms.TextBox txtDelID;
    }
}

