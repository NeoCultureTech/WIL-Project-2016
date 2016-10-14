namespace prjWil
{
    partial class frmJobsheet
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnDeleteJobRec = new System.Windows.Forms.Button();
            this.btnSearchJobRec = new System.Windows.Forms.Button();
            this.btnAddJobRec = new System.Windows.Forms.Button();
            this.pnlDeleteJob = new System.Windows.Forms.Panel();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearchJob = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSearchJob = new System.Windows.Forms.Button();
            this.cmbVehNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddJob = new System.Windows.Forms.Panel();
            this.btnAddSercice = new System.Windows.Forms.Button();
            this.txbWork = new System.Windows.Forms.TextBox();
            this.txbAppointTime = new System.Windows.Forms.TextBox();
            this.txbServType = new System.Windows.Forms.TextBox();
            this.txbVehiNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbJobsheetDelete = new System.Windows.Forms.ComboBox();
            this.pnlDeleteJob.SuspendLayout();
            this.pnlSearchJob.SuspendLayout();
            this.pnlAddJob.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(23, 32);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(125, 13);
            this.lblSelect.TabIndex = 9;
            this.lblSelect.Text = "Please make a selection:";
            // 
            // btnDeleteJobRec
            // 
            this.btnDeleteJobRec.Location = new System.Drawing.Point(155, 106);
            this.btnDeleteJobRec.Name = "btnDeleteJobRec";
            this.btnDeleteJobRec.Size = new System.Drawing.Size(146, 23);
            this.btnDeleteJobRec.TabIndex = 17;
            this.btnDeleteJobRec.Text = "Delete Jobsheet Record";
            this.btnDeleteJobRec.UseVisualStyleBackColor = true;
            this.btnDeleteJobRec.Click += new System.EventHandler(this.btnDeleteJobRec_Click);
            // 
            // btnSearchJobRec
            // 
            this.btnSearchJobRec.Location = new System.Drawing.Point(155, 66);
            this.btnSearchJobRec.Name = "btnSearchJobRec";
            this.btnSearchJobRec.Size = new System.Drawing.Size(146, 23);
            this.btnSearchJobRec.TabIndex = 16;
            this.btnSearchJobRec.Text = "Search Jobsheet Record";
            this.btnSearchJobRec.UseVisualStyleBackColor = true;
            this.btnSearchJobRec.Click += new System.EventHandler(this.btnSearchJobRec_Click);
            // 
            // btnAddJobRec
            // 
            this.btnAddJobRec.Location = new System.Drawing.Point(155, 32);
            this.btnAddJobRec.Name = "btnAddJobRec";
            this.btnAddJobRec.Size = new System.Drawing.Size(146, 23);
            this.btnAddJobRec.TabIndex = 15;
            this.btnAddJobRec.Text = "Add Jobsheet Record";
            this.btnAddJobRec.UseVisualStyleBackColor = true;
            this.btnAddJobRec.Click += new System.EventHandler(this.btnAddJobRec_Click);
            // 
            // pnlDeleteJob
            // 
            this.pnlDeleteJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteJob.Controls.Add(this.cmbJobsheetDelete);
            this.pnlDeleteJob.Controls.Add(this.btnDeleteJob);
            this.pnlDeleteJob.Controls.Add(this.label2);
            this.pnlDeleteJob.Location = new System.Drawing.Point(372, 261);
            this.pnlDeleteJob.Name = "pnlDeleteJob";
            this.pnlDeleteJob.Size = new System.Drawing.Size(371, 125);
            this.pnlDeleteJob.TabIndex = 14;
            this.pnlDeleteJob.Visible = false;
            this.pnlDeleteJob.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeleteJob_Paint);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(176, 52);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteJob.TabIndex = 1;
            this.btnDeleteJob.Text = "Delete";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Vehicle No of jobsheet you wish to delete:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlSearchJob
            // 
            this.pnlSearchJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchJob.Controls.Add(this.richTextBox1);
            this.pnlSearchJob.Controls.Add(this.btnSearchJob);
            this.pnlSearchJob.Controls.Add(this.cmbVehNo);
            this.pnlSearchJob.Controls.Add(this.label1);
            this.pnlSearchJob.Location = new System.Drawing.Point(372, 49);
            this.pnlSearchJob.Name = "pnlSearchJob";
            this.pnlSearchJob.Size = new System.Drawing.Size(371, 181);
            this.pnlSearchJob.TabIndex = 13;
            this.pnlSearchJob.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.Location = new System.Drawing.Point(271, 16);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(75, 23);
            this.btnSearchJob.TabIndex = 2;
            this.btnSearchJob.Text = "Search";
            this.btnSearchJob.UseVisualStyleBackColor = true;
            this.btnSearchJob.Click += new System.EventHandler(this.btnSearchJob_Click);
            // 
            // cmbVehNo
            // 
            this.cmbVehNo.FormattingEnabled = true;
            this.cmbVehNo.Location = new System.Drawing.Point(131, 16);
            this.cmbVehNo.Name = "cmbVehNo";
            this.cmbVehNo.Size = new System.Drawing.Size(121, 21);
            this.cmbVehNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vehicle no:";
            // 
            // pnlAddJob
            // 
            this.pnlAddJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddJob.Controls.Add(this.btnAddSercice);
            this.pnlAddJob.Controls.Add(this.txbWork);
            this.pnlAddJob.Controls.Add(this.txbAppointTime);
            this.pnlAddJob.Controls.Add(this.txbServType);
            this.pnlAddJob.Controls.Add(this.txbVehiNo);
            this.pnlAddJob.Controls.Add(this.label6);
            this.pnlAddJob.Controls.Add(this.label5);
            this.pnlAddJob.Controls.Add(this.label4);
            this.pnlAddJob.Controls.Add(this.label3);
            this.pnlAddJob.Location = new System.Drawing.Point(35, 181);
            this.pnlAddJob.Name = "pnlAddJob";
            this.pnlAddJob.Size = new System.Drawing.Size(317, 205);
            this.pnlAddJob.TabIndex = 12;
            this.pnlAddJob.Visible = false;
            // 
            // btnAddSercice
            // 
            this.btnAddSercice.Location = new System.Drawing.Point(132, 146);
            this.btnAddSercice.Name = "btnAddSercice";
            this.btnAddSercice.Size = new System.Drawing.Size(146, 23);
            this.btnAddSercice.TabIndex = 13;
            this.btnAddSercice.Text = "Add";
            this.btnAddSercice.UseVisualStyleBackColor = true;
            this.btnAddSercice.Click += new System.EventHandler(this.btnAddSercice_Click);
            // 
            // txbWork
            // 
            this.txbWork.Location = new System.Drawing.Point(119, 105);
            this.txbWork.Name = "txbWork";
            this.txbWork.Size = new System.Drawing.Size(169, 20);
            this.txbWork.TabIndex = 10;
            // 
            // txbAppointTime
            // 
            this.txbAppointTime.Location = new System.Drawing.Point(119, 75);
            this.txbAppointTime.Name = "txbAppointTime";
            this.txbAppointTime.Size = new System.Drawing.Size(169, 20);
            this.txbAppointTime.TabIndex = 9;
            // 
            // txbServType
            // 
            this.txbServType.Location = new System.Drawing.Point(119, 42);
            this.txbServType.Name = "txbServType";
            this.txbServType.Size = new System.Drawing.Size(169, 20);
            this.txbServType.TabIndex = 8;
            // 
            // txbVehiNo
            // 
            this.txbVehiNo.Location = new System.Drawing.Point(119, 14);
            this.txbVehiNo.Name = "txbVehiNo";
            this.txbVehiNo.Size = new System.Drawing.Size(169, 20);
            this.txbVehiNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Work TBC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Appointment Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Service Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vehicle No:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 18;
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
            // cmbJobsheetDelete
            // 
            this.cmbJobsheetDelete.FormattingEnabled = true;
            this.cmbJobsheetDelete.Location = new System.Drawing.Point(33, 52);
            this.cmbJobsheetDelete.Name = "cmbJobsheetDelete";
            this.cmbJobsheetDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbJobsheetDelete.TabIndex = 2;
            // 
            // frmJobsheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 424);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDeleteJobRec);
            this.Controls.Add(this.btnSearchJobRec);
            this.Controls.Add(this.btnAddJobRec);
            this.Controls.Add(this.pnlDeleteJob);
            this.Controls.Add(this.pnlSearchJob);
            this.Controls.Add(this.pnlAddJob);
            this.Controls.Add(this.lblSelect);
            this.Name = "frmJobsheet";
            this.Text = "frmJobsheet";
            this.pnlDeleteJob.ResumeLayout(false);
            this.pnlDeleteJob.PerformLayout();
            this.pnlSearchJob.ResumeLayout(false);
            this.pnlSearchJob.PerformLayout();
            this.pnlAddJob.ResumeLayout(false);
            this.pnlAddJob.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnDeleteJobRec;
        private System.Windows.Forms.Button btnSearchJobRec;
        private System.Windows.Forms.Button btnAddJobRec;
        private System.Windows.Forms.Panel pnlDeleteJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSearchJob;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearchJob;
        private System.Windows.Forms.ComboBox cmbVehNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddJob;
        private System.Windows.Forms.Button btnAddSercice;
        private System.Windows.Forms.TextBox txbWork;
        private System.Windows.Forms.TextBox txbAppointTime;
        private System.Windows.Forms.TextBox txbServType;
        private System.Windows.Forms.TextBox txbVehiNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbJobsheetDelete;
    }
}