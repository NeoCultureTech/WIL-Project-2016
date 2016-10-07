namespace prjWil
{
    partial class frmTimesheet
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
            this.pnlDeleteTime = new System.Windows.Forms.Panel();
            this.txbEnterEmpID = new System.Windows.Forms.TextBox();
            this.btnDeleteTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearchTime = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSearchTime = new System.Windows.Forms.Button();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTimeRec = new System.Windows.Forms.Button();
            this.btnSearchTimeRec = new System.Windows.Forms.Button();
            this.btnAddTimeRec = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.pnlAddTime = new System.Windows.Forms.Panel();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.txbHours = new System.Windows.Forms.TextBox();
            this.txbEmpOver = new System.Windows.Forms.TextBox();
            this.txbEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDeleteTime.SuspendLayout();
            this.pnlSearchTime.SuspendLayout();
            this.pnlAddTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeleteTime
            // 
            this.pnlDeleteTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteTime.Controls.Add(this.txbEnterEmpID);
            this.pnlDeleteTime.Controls.Add(this.btnDeleteTime);
            this.pnlDeleteTime.Controls.Add(this.label2);
            this.pnlDeleteTime.Location = new System.Drawing.Point(406, 243);
            this.pnlDeleteTime.Name = "pnlDeleteTime";
            this.pnlDeleteTime.Size = new System.Drawing.Size(371, 168);
            this.pnlDeleteTime.TabIndex = 19;
            this.pnlDeleteTime.Visible = false;
            // 
            // txbEnterEmpID
            // 
            this.txbEnterEmpID.Location = new System.Drawing.Point(21, 54);
            this.txbEnterEmpID.Name = "txbEnterEmpID";
            this.txbEnterEmpID.Size = new System.Drawing.Size(100, 20);
            this.txbEnterEmpID.TabIndex = 2;
            // 
            // btnDeleteTime
            // 
            this.btnDeleteTime.Location = new System.Drawing.Point(176, 52);
            this.btnDeleteTime.Name = "btnDeleteTime";
            this.btnDeleteTime.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteTime.TabIndex = 1;
            this.btnDeleteTime.Text = "Delete";
            this.btnDeleteTime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Employee ID of Employee you wish to delete:";
            // 
            // pnlSearchTime
            // 
            this.pnlSearchTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchTime.Controls.Add(this.richTextBox1);
            this.pnlSearchTime.Controls.Add(this.btnSearchTime);
            this.pnlSearchTime.Controls.Add(this.cmbEmpID);
            this.pnlSearchTime.Controls.Add(this.label1);
            this.pnlSearchTime.Location = new System.Drawing.Point(406, 55);
            this.pnlSearchTime.Name = "pnlSearchTime";
            this.pnlSearchTime.Size = new System.Drawing.Size(371, 168);
            this.pnlSearchTime.TabIndex = 18;
            this.pnlSearchTime.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSearchTime
            // 
            this.btnSearchTime.Location = new System.Drawing.Point(271, 16);
            this.btnSearchTime.Name = "btnSearchTime";
            this.btnSearchTime.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTime.TabIndex = 2;
            this.btnSearchTime.Text = "Search";
            this.btnSearchTime.UseVisualStyleBackColor = true;
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(131, 16);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Employee ID:";
            // 
            // btnDeleteTimeRec
            // 
            this.btnDeleteTimeRec.Location = new System.Drawing.Point(172, 113);
            this.btnDeleteTimeRec.Name = "btnDeleteTimeRec";
            this.btnDeleteTimeRec.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteTimeRec.TabIndex = 17;
            this.btnDeleteTimeRec.Text = "Delete Timesheet Record";
            this.btnDeleteTimeRec.UseVisualStyleBackColor = true;
            this.btnDeleteTimeRec.Click += new System.EventHandler(this.btnDeleteTimeRec_Click);
            // 
            // btnSearchTimeRec
            // 
            this.btnSearchTimeRec.Location = new System.Drawing.Point(172, 84);
            this.btnSearchTimeRec.Name = "btnSearchTimeRec";
            this.btnSearchTimeRec.Size = new System.Drawing.Size(143, 23);
            this.btnSearchTimeRec.TabIndex = 16;
            this.btnSearchTimeRec.Text = "Search Timesheet Record";
            this.btnSearchTimeRec.UseVisualStyleBackColor = true;
            this.btnSearchTimeRec.Click += new System.EventHandler(this.btnSearchTimeRec_Click);
            // 
            // btnAddTimeRec
            // 
            this.btnAddTimeRec.Location = new System.Drawing.Point(172, 55);
            this.btnAddTimeRec.Name = "btnAddTimeRec";
            this.btnAddTimeRec.Size = new System.Drawing.Size(143, 23);
            this.btnAddTimeRec.TabIndex = 15;
            this.btnAddTimeRec.Text = "Add Timesheet Record";
            this.btnAddTimeRec.UseVisualStyleBackColor = true;
            this.btnAddTimeRec.Click += new System.EventHandler(this.btnAddTimeRec_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(38, 55);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(125, 13);
            this.lblSelect.TabIndex = 14;
            this.lblSelect.Text = "Please make a selection:";
            // 
            // pnlAddTime
            // 
            this.pnlAddTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddTime.Controls.Add(this.btnAddTime);
            this.pnlAddTime.Controls.Add(this.txbHours);
            this.pnlAddTime.Controls.Add(this.txbEmpOver);
            this.pnlAddTime.Controls.Add(this.txbEmpID);
            this.pnlAddTime.Controls.Add(this.label6);
            this.pnlAddTime.Controls.Add(this.label5);
            this.pnlAddTime.Controls.Add(this.label3);
            this.pnlAddTime.Location = new System.Drawing.Point(49, 183);
            this.pnlAddTime.Name = "pnlAddTime";
            this.pnlAddTime.Size = new System.Drawing.Size(328, 228);
            this.pnlAddTime.TabIndex = 13;
            this.pnlAddTime.Visible = false;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(122, 147);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(125, 23);
            this.btnAddTime.TabIndex = 13;
            this.btnAddTime.Text = "Add";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // txbHours
            // 
            this.txbHours.Location = new System.Drawing.Point(119, 77);
            this.txbHours.Name = "txbHours";
            this.txbHours.Size = new System.Drawing.Size(128, 20);
            this.txbHours.TabIndex = 10;
            // 
            // txbEmpOver
            // 
            this.txbEmpOver.Location = new System.Drawing.Point(119, 45);
            this.txbEmpOver.Name = "txbEmpOver";
            this.txbEmpOver.Size = new System.Drawing.Size(128, 20);
            this.txbEmpOver.TabIndex = 9;
            // 
            // txbEmpID
            // 
            this.txbEmpID.Location = new System.Drawing.Point(119, 14);
            this.txbEmpID.Name = "txbEmpID";
            this.txbEmpID.Size = new System.Drawing.Size(128, 20);
            this.txbEmpID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hours Worked:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Employee Overtime:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDeleteTime);
            this.Controls.Add(this.pnlSearchTime);
            this.Controls.Add(this.btnDeleteTimeRec);
            this.Controls.Add(this.btnSearchTimeRec);
            this.Controls.Add(this.btnAddTimeRec);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pnlAddTime);
            this.Name = "frmTimesheet";
            this.Text = "frmTimesheet";
            this.pnlDeleteTime.ResumeLayout(false);
            this.pnlDeleteTime.PerformLayout();
            this.pnlSearchTime.ResumeLayout(false);
            this.pnlSearchTime.PerformLayout();
            this.pnlAddTime.ResumeLayout(false);
            this.pnlAddTime.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteTime;
        private System.Windows.Forms.TextBox txbEnterEmpID;
        private System.Windows.Forms.Button btnDeleteTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSearchTime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearchTime;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTimeRec;
        private System.Windows.Forms.Button btnSearchTimeRec;
        private System.Windows.Forms.Button btnAddTimeRec;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Panel pnlAddTime;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.TextBox txbHours;
        private System.Windows.Forms.TextBox txbEmpOver;
        private System.Windows.Forms.TextBox txbEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

    }
}