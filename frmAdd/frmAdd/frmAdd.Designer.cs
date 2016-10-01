namespace frmAdd
{
    partial class frmAdd
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
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddContactNum = new System.Windows.Forms.TextBox();
            this.txtAddAppointTime = new System.Windows.Forms.TextBox();
            this.dtpAddAppointDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(12, 21);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(100, 26);
            this.txtAddID.TabIndex = 0;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(152, 21);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 26);
            this.txtAddName.TabIndex = 1;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(285, 21);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(100, 26);
            this.txtAddSurname.TabIndex = 2;
            // 
            // txtAddContactNum
            // 
            this.txtAddContactNum.Location = new System.Drawing.Point(12, 86);
            this.txtAddContactNum.Name = "txtAddContactNum";
            this.txtAddContactNum.Size = new System.Drawing.Size(100, 26);
            this.txtAddContactNum.TabIndex = 3;
            // 
            // txtAddAppointTime
            // 
            this.txtAddAppointTime.Location = new System.Drawing.Point(152, 86);
            this.txtAddAppointTime.Name = "txtAddAppointTime";
            this.txtAddAppointTime.Size = new System.Drawing.Size(101, 26);
            this.txtAddAppointTime.TabIndex = 4;
            // 
            // dtpAddAppointDate
            // 
            this.dtpAddAppointDate.Location = new System.Drawing.Point(12, 146);
            this.dtpAddAppointDate.Name = "dtpAddAppointDate";
            this.dtpAddAppointDate.Size = new System.Drawing.Size(200, 26);
            this.dtpAddAppointDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 221);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpAddAppointDate);
            this.Controls.Add(this.txtAddAppointTime);
            this.Controls.Add(this.txtAddContactNum);
            this.Controls.Add(this.txtAddSurname);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.txtAddID);
            this.Name = "frmAdd";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddContactNum;
        private System.Windows.Forms.TextBox txtAddAppointTime;
        private System.Windows.Forms.DateTimePicker dtpAddAppointDate;
        private System.Windows.Forms.Button btnAdd;
    }
}

