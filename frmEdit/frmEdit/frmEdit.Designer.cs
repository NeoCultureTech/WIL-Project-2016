namespace frmEdit
{
    partial class frmEdit
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpEditAppointDate = new System.Windows.Forms.DateTimePicker();
            this.txtEditAppointTime = new System.Windows.Forms.TextBox();
            this.txtEditContactNum = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(317, 198);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 39);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpEditAppointDate
            // 
            this.dtpEditAppointDate.Location = new System.Drawing.Point(49, 198);
            this.dtpEditAppointDate.Name = "dtpEditAppointDate";
            this.dtpEditAppointDate.Size = new System.Drawing.Size(200, 26);
            this.dtpEditAppointDate.TabIndex = 12;
            // 
            // txtEditAppointTime
            // 
            this.txtEditAppointTime.Location = new System.Drawing.Point(189, 138);
            this.txtEditAppointTime.Name = "txtEditAppointTime";
            this.txtEditAppointTime.Size = new System.Drawing.Size(101, 26);
            this.txtEditAppointTime.TabIndex = 11;
            // 
            // txtEditContactNum
            // 
            this.txtEditContactNum.Location = new System.Drawing.Point(49, 138);
            this.txtEditContactNum.Name = "txtEditContactNum";
            this.txtEditContactNum.Size = new System.Drawing.Size(100, 26);
            this.txtEditContactNum.TabIndex = 10;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(322, 73);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(100, 26);
            this.txtEditSurname.TabIndex = 9;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(189, 73);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(100, 26);
            this.txtEditName.TabIndex = 8;
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(49, 73);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(100, 26);
            this.txtEditID.TabIndex = 7;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 310);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtpEditAppointDate);
            this.Controls.Add(this.txtEditAppointTime);
            this.Controls.Add(this.txtEditContactNum);
            this.Controls.Add(this.txtEditSurname);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.txtEditID);
            this.Name = "frmEdit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtpEditAppointDate;
        private System.Windows.Forms.TextBox txtEditAppointTime;
        private System.Windows.Forms.TextBox txtEditContactNum;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditID;
    }
}

