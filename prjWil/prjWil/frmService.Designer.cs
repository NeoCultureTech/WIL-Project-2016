namespace prjWil
{
    partial class frmService
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
            this.pnlAddService = new System.Windows.Forms.Panel();
            this.btnAddSercice = new System.Windows.Forms.Button();
            this.txbServDescrip = new System.Windows.Forms.TextBox();
            this.txbProcCode = new System.Windows.Forms.TextBox();
            this.txbServPerform = new System.Windows.Forms.TextBox();
            this.txbVehNo = new System.Windows.Forms.TextBox();
            this.txbAppointTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSearchService = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.cmbVehNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDeleteService = new System.Windows.Forms.Panel();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnAddServiceRec = new System.Windows.Forms.Button();
            this.btnSearchServiceRec = new System.Windows.Forms.Button();
            this.btnDeleteServiceRec = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbServiceDelete = new System.Windows.Forms.ComboBox();
            this.pnlAddService.SuspendLayout();
            this.pnlSearchService.SuspendLayout();
            this.pnlDeleteService.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddService
            // 
            this.pnlAddService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddService.Controls.Add(this.btnAddSercice);
            this.pnlAddService.Controls.Add(this.txbServDescrip);
            this.pnlAddService.Controls.Add(this.txbProcCode);
            this.pnlAddService.Controls.Add(this.txbServPerform);
            this.pnlAddService.Controls.Add(this.txbVehNo);
            this.pnlAddService.Controls.Add(this.txbAppointTime);
            this.pnlAddService.Controls.Add(this.label7);
            this.pnlAddService.Controls.Add(this.label6);
            this.pnlAddService.Controls.Add(this.label5);
            this.pnlAddService.Controls.Add(this.label4);
            this.pnlAddService.Controls.Add(this.label3);
            this.pnlAddService.Location = new System.Drawing.Point(33, 159);
            this.pnlAddService.Name = "pnlAddService";
            this.pnlAddService.Size = new System.Drawing.Size(317, 248);
            this.pnlAddService.TabIndex = 5;
            this.pnlAddService.Visible = false;
            // 
            // btnAddSercice
            // 
            this.btnAddSercice.Location = new System.Drawing.Point(129, 173);
            this.btnAddSercice.Name = "btnAddSercice";
            this.btnAddSercice.Size = new System.Drawing.Size(146, 23);
            this.btnAddSercice.TabIndex = 13;
            this.btnAddSercice.Text = "Add";
            this.btnAddSercice.UseVisualStyleBackColor = true;
            this.btnAddSercice.Click += new System.EventHandler(this.btnAddSercice_Click);
            // 
            // txbServDescrip
            // 
            this.txbServDescrip.Location = new System.Drawing.Point(119, 132);
            this.txbServDescrip.Name = "txbServDescrip";
            this.txbServDescrip.Size = new System.Drawing.Size(169, 20);
            this.txbServDescrip.TabIndex = 11;
            // 
            // txbProcCode
            // 
            this.txbProcCode.Location = new System.Drawing.Point(119, 105);
            this.txbProcCode.Name = "txbProcCode";
            this.txbProcCode.Size = new System.Drawing.Size(169, 20);
            this.txbProcCode.TabIndex = 10;
            // 
            // txbServPerform
            // 
            this.txbServPerform.Location = new System.Drawing.Point(119, 75);
            this.txbServPerform.Name = "txbServPerform";
            this.txbServPerform.Size = new System.Drawing.Size(169, 20);
            this.txbServPerform.TabIndex = 9;
            // 
            // txbVehNo
            // 
            this.txbVehNo.Location = new System.Drawing.Point(119, 42);
            this.txbVehNo.Name = "txbVehNo";
            this.txbVehNo.Size = new System.Drawing.Size(169, 20);
            this.txbVehNo.TabIndex = 8;
            // 
            // txbAppointTime
            // 
            this.txbAppointTime.Location = new System.Drawing.Point(119, 14);
            this.txbAppointTime.Name = "txbAppointTime";
            this.txbAppointTime.Size = new System.Drawing.Size(169, 20);
            this.txbAppointTime.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Service Descrip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Procedure Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Service to Perform:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vehicle No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Appointment Time:";
            // 
            // pnlSearchService
            // 
            this.pnlSearchService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchService.Controls.Add(this.richTextBox1);
            this.pnlSearchService.Controls.Add(this.btnSearchService);
            this.pnlSearchService.Controls.Add(this.cmbVehNo);
            this.pnlSearchService.Controls.Add(this.label1);
            this.pnlSearchService.Location = new System.Drawing.Point(395, 36);
            this.pnlSearchService.Name = "pnlSearchService";
            this.pnlSearchService.Size = new System.Drawing.Size(371, 168);
            this.pnlSearchService.TabIndex = 6;
            this.pnlSearchService.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSearchService
            // 
            this.btnSearchService.Location = new System.Drawing.Point(271, 16);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(75, 23);
            this.btnSearchService.TabIndex = 2;
            this.btnSearchService.Text = "Search";
            this.btnSearchService.UseVisualStyleBackColor = true;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
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
            // pnlDeleteService
            // 
            this.pnlDeleteService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteService.Controls.Add(this.cmbServiceDelete);
            this.pnlDeleteService.Controls.Add(this.btnDeleteService);
            this.pnlDeleteService.Controls.Add(this.label2);
            this.pnlDeleteService.Location = new System.Drawing.Point(395, 239);
            this.pnlDeleteService.Name = "pnlDeleteService";
            this.pnlDeleteService.Size = new System.Drawing.Size(371, 168);
            this.pnlDeleteService.TabIndex = 7;
            this.pnlDeleteService.Visible = false;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(176, 52);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteService.TabIndex = 1;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Vehicle No of service you wish to delete:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(30, 36);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(125, 13);
            this.lblSelect.TabIndex = 8;
            this.lblSelect.Text = "Please make a selection:";
            // 
            // btnAddServiceRec
            // 
            this.btnAddServiceRec.Location = new System.Drawing.Point(176, 36);
            this.btnAddServiceRec.Name = "btnAddServiceRec";
            this.btnAddServiceRec.Size = new System.Drawing.Size(146, 23);
            this.btnAddServiceRec.TabIndex = 9;
            this.btnAddServiceRec.Text = "Add Service Record";
            this.btnAddServiceRec.UseVisualStyleBackColor = true;
            this.btnAddServiceRec.Click += new System.EventHandler(this.btnAddServiceRec_Click);
            // 
            // btnSearchServiceRec
            // 
            this.btnSearchServiceRec.Location = new System.Drawing.Point(176, 65);
            this.btnSearchServiceRec.Name = "btnSearchServiceRec";
            this.btnSearchServiceRec.Size = new System.Drawing.Size(146, 23);
            this.btnSearchServiceRec.TabIndex = 10;
            this.btnSearchServiceRec.Text = "Search Service Record";
            this.btnSearchServiceRec.UseVisualStyleBackColor = true;
            this.btnSearchServiceRec.Click += new System.EventHandler(this.btnSearchServiceRec_Click);
            // 
            // btnDeleteServiceRec
            // 
            this.btnDeleteServiceRec.Location = new System.Drawing.Point(176, 95);
            this.btnDeleteServiceRec.Name = "btnDeleteServiceRec";
            this.btnDeleteServiceRec.Size = new System.Drawing.Size(146, 23);
            this.btnDeleteServiceRec.TabIndex = 11;
            this.btnDeleteServiceRec.Text = "Delete Service Record";
            this.btnDeleteServiceRec.UseVisualStyleBackColor = true;
            this.btnDeleteServiceRec.Click += new System.EventHandler(this.btnDeleteServiceRec_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 14;
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
            // cmbServiceDelete
            // 
            this.cmbServiceDelete.FormattingEnabled = true;
            this.cmbServiceDelete.Location = new System.Drawing.Point(35, 54);
            this.cmbServiceDelete.Name = "cmbServiceDelete";
            this.cmbServiceDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbServiceDelete.TabIndex = 2;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 458);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDeleteServiceRec);
            this.Controls.Add(this.btnSearchServiceRec);
            this.Controls.Add(this.btnAddServiceRec);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pnlDeleteService);
            this.Controls.Add(this.pnlSearchService);
            this.Controls.Add(this.pnlAddService);
            this.Name = "frmService";
            this.Text = "frmService";
            this.pnlAddService.ResumeLayout(false);
            this.pnlAddService.PerformLayout();
            this.pnlSearchService.ResumeLayout(false);
            this.pnlSearchService.PerformLayout();
            this.pnlDeleteService.ResumeLayout(false);
            this.pnlDeleteService.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddService;
        private System.Windows.Forms.Button btnAddSercice;
        private System.Windows.Forms.TextBox txbServDescrip;
        private System.Windows.Forms.TextBox txbProcCode;
        private System.Windows.Forms.TextBox txbServPerform;
        private System.Windows.Forms.TextBox txbVehNo;
        private System.Windows.Forms.TextBox txbAppointTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSearchService;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.ComboBox cmbVehNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDeleteService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnAddServiceRec;
        private System.Windows.Forms.Button btnSearchServiceRec;
        private System.Windows.Forms.Button btnDeleteServiceRec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbServiceDelete;
    }
}