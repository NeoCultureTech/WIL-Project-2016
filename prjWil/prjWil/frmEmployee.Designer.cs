namespace prjWil
{
    partial class frmEmployee
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
            this.pnlAddEmp = new System.Windows.Forms.Panel();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txbAdminID = new System.Windows.Forms.TextBox();
            this.txbEmpOver = new System.Windows.Forms.TextBox();
            this.txbEmpRole = new System.Windows.Forms.TextBox();
            this.txbEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDeleteEmp = new System.Windows.Forms.Panel();
            this.txbEnterEmpID = new System.Windows.Forms.TextBox();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearchEmp = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEmpRec = new System.Windows.Forms.Button();
            this.btnSearchEmpRec = new System.Windows.Forms.Button();
            this.btnAddEmpRec = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAddEmp.SuspendLayout();
            this.pnlDeleteEmp.SuspendLayout();
            this.pnlSearchEmp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddEmp
            // 
            this.pnlAddEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEmp.Controls.Add(this.btnAddEmp);
            this.pnlAddEmp.Controls.Add(this.txbAdminID);
            this.pnlAddEmp.Controls.Add(this.txbEmpOver);
            this.pnlAddEmp.Controls.Add(this.txbEmpRole);
            this.pnlAddEmp.Controls.Add(this.txbEmpID);
            this.pnlAddEmp.Controls.Add(this.label6);
            this.pnlAddEmp.Controls.Add(this.label5);
            this.pnlAddEmp.Controls.Add(this.label4);
            this.pnlAddEmp.Controls.Add(this.label3);
            this.pnlAddEmp.Location = new System.Drawing.Point(33, 180);
            this.pnlAddEmp.Name = "pnlAddEmp";
            this.pnlAddEmp.Size = new System.Drawing.Size(328, 228);
            this.pnlAddEmp.TabIndex = 5;
            this.pnlAddEmp.Visible = false;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(122, 147);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(125, 23);
            this.btnAddEmp.TabIndex = 13;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // txbAdminID
            // 
            this.txbAdminID.Location = new System.Drawing.Point(119, 105);
            this.txbAdminID.Name = "txbAdminID";
            this.txbAdminID.Size = new System.Drawing.Size(128, 20);
            this.txbAdminID.TabIndex = 10;
            // 
            // txbEmpOver
            // 
            this.txbEmpOver.Location = new System.Drawing.Point(119, 75);
            this.txbEmpOver.Name = "txbEmpOver";
            this.txbEmpOver.Size = new System.Drawing.Size(128, 20);
            this.txbEmpOver.TabIndex = 9;
            // 
            // txbEmpRole
            // 
            this.txbEmpRole.Location = new System.Drawing.Point(119, 42);
            this.txbEmpRole.Name = "txbEmpRole";
            this.txbEmpRole.Size = new System.Drawing.Size(128, 20);
            this.txbEmpRole.TabIndex = 8;
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
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Admin ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Employee Overtime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employee Role:";
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
            // pnlDeleteEmp
            // 
            this.pnlDeleteEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteEmp.Controls.Add(this.txbEnterEmpID);
            this.pnlDeleteEmp.Controls.Add(this.btnDeleteEmp);
            this.pnlDeleteEmp.Controls.Add(this.label2);
            this.pnlDeleteEmp.Location = new System.Drawing.Point(390, 240);
            this.pnlDeleteEmp.Name = "pnlDeleteEmp";
            this.pnlDeleteEmp.Size = new System.Drawing.Size(371, 168);
            this.pnlDeleteEmp.TabIndex = 12;
            this.pnlDeleteEmp.Visible = false;
            // 
            // txbEnterEmpID
            // 
            this.txbEnterEmpID.Location = new System.Drawing.Point(21, 54);
            this.txbEnterEmpID.Name = "txbEnterEmpID";
            this.txbEnterEmpID.Size = new System.Drawing.Size(100, 20);
            this.txbEnterEmpID.TabIndex = 2;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(176, 52);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteEmp.TabIndex = 1;
            this.btnDeleteEmp.Text = "Delete";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
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
            // pnlSearchEmp
            // 
            this.pnlSearchEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchEmp.Controls.Add(this.richTextBox1);
            this.pnlSearchEmp.Controls.Add(this.btnSearchEmp);
            this.pnlSearchEmp.Controls.Add(this.cmbEmpID);
            this.pnlSearchEmp.Controls.Add(this.label1);
            this.pnlSearchEmp.Location = new System.Drawing.Point(390, 52);
            this.pnlSearchEmp.Name = "pnlSearchEmp";
            this.pnlSearchEmp.Size = new System.Drawing.Size(371, 168);
            this.pnlSearchEmp.TabIndex = 11;
            this.pnlSearchEmp.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(271, 16);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(75, 23);
            this.btnSearchEmp.TabIndex = 2;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
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
            // btnDeleteEmpRec
            // 
            this.btnDeleteEmpRec.Location = new System.Drawing.Point(156, 110);
            this.btnDeleteEmpRec.Name = "btnDeleteEmpRec";
            this.btnDeleteEmpRec.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteEmpRec.TabIndex = 10;
            this.btnDeleteEmpRec.Text = "Delete Employee Record";
            this.btnDeleteEmpRec.UseVisualStyleBackColor = true;
            this.btnDeleteEmpRec.Click += new System.EventHandler(this.btnDeleteEmpRec_Click);
            // 
            // btnSearchEmpRec
            // 
            this.btnSearchEmpRec.Location = new System.Drawing.Point(156, 81);
            this.btnSearchEmpRec.Name = "btnSearchEmpRec";
            this.btnSearchEmpRec.Size = new System.Drawing.Size(143, 23);
            this.btnSearchEmpRec.TabIndex = 9;
            this.btnSearchEmpRec.Text = "Search Employee Record";
            this.btnSearchEmpRec.UseVisualStyleBackColor = true;
            this.btnSearchEmpRec.Click += new System.EventHandler(this.btnSearchEmpRec_Click);
            // 
            // btnAddEmpRec
            // 
            this.btnAddEmpRec.Location = new System.Drawing.Point(156, 52);
            this.btnAddEmpRec.Name = "btnAddEmpRec";
            this.btnAddEmpRec.Size = new System.Drawing.Size(143, 23);
            this.btnAddEmpRec.TabIndex = 8;
            this.btnAddEmpRec.Text = "Add Employee Record";
            this.btnAddEmpRec.UseVisualStyleBackColor = true;
            this.btnAddEmpRec.Click += new System.EventHandler(this.btnAddEmpRec_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(22, 52);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(125, 13);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "Please make a selection:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
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
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 460);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDeleteEmp);
            this.Controls.Add(this.pnlSearchEmp);
            this.Controls.Add(this.btnDeleteEmpRec);
            this.Controls.Add(this.btnSearchEmpRec);
            this.Controls.Add(this.btnAddEmpRec);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pnlAddEmp);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.pnlAddEmp.ResumeLayout(false);
            this.pnlAddEmp.PerformLayout();
            this.pnlDeleteEmp.ResumeLayout(false);
            this.pnlDeleteEmp.PerformLayout();
            this.pnlSearchEmp.ResumeLayout(false);
            this.pnlSearchEmp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txbAdminID;
        private System.Windows.Forms.TextBox txbEmpOver;
        private System.Windows.Forms.TextBox txbEmpRole;
        private System.Windows.Forms.TextBox txbEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDeleteEmp;
        private System.Windows.Forms.TextBox txbEnterEmpID;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSearchEmp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmpRec;
        private System.Windows.Forms.Button btnSearchEmpRec;
        private System.Windows.Forms.Button btnAddEmpRec;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}