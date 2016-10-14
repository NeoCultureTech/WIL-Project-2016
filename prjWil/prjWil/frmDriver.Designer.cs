namespace prjWil
{
    partial class frmDriver
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
            this.pnlDeleteDriver = new System.Windows.Forms.Panel();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearchDriver = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSearchDriver = new System.Windows.Forms.Button();
            this.cmbDriverID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDriverRec = new System.Windows.Forms.Button();
            this.btnSearchDriverRec = new System.Windows.Forms.Button();
            this.btnAddDriverRec = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.pnlAddDriver = new System.Windows.Forms.Panel();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.txbDriverName = new System.Windows.Forms.TextBox();
            this.txbDriverID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbDriverDelete = new System.Windows.Forms.ComboBox();
            this.pnlDeleteDriver.SuspendLayout();
            this.pnlSearchDriver.SuspendLayout();
            this.pnlAddDriver.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeleteDriver
            // 
            this.pnlDeleteDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteDriver.Controls.Add(this.cmbDriverDelete);
            this.pnlDeleteDriver.Controls.Add(this.btnDeleteDriver);
            this.pnlDeleteDriver.Controls.Add(this.label2);
            this.pnlDeleteDriver.Location = new System.Drawing.Point(412, 234);
            this.pnlDeleteDriver.Name = "pnlDeleteDriver";
            this.pnlDeleteDriver.Size = new System.Drawing.Size(371, 168);
            this.pnlDeleteDriver.TabIndex = 19;
            this.pnlDeleteDriver.Visible = false;
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(176, 52);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteDriver.TabIndex = 1;
            this.btnDeleteDriver.Text = "Delete";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Driver ID of Driver you wish to delete:";
            // 
            // pnlSearchDriver
            // 
            this.pnlSearchDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchDriver.Controls.Add(this.richTextBox1);
            this.pnlSearchDriver.Controls.Add(this.btnSearchDriver);
            this.pnlSearchDriver.Controls.Add(this.cmbDriverID);
            this.pnlSearchDriver.Controls.Add(this.label1);
            this.pnlSearchDriver.Location = new System.Drawing.Point(412, 46);
            this.pnlSearchDriver.Name = "pnlSearchDriver";
            this.pnlSearchDriver.Size = new System.Drawing.Size(371, 168);
            this.pnlSearchDriver.TabIndex = 18;
            this.pnlSearchDriver.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSearchDriver
            // 
            this.btnSearchDriver.Location = new System.Drawing.Point(271, 16);
            this.btnSearchDriver.Name = "btnSearchDriver";
            this.btnSearchDriver.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDriver.TabIndex = 2;
            this.btnSearchDriver.Text = "Search";
            this.btnSearchDriver.UseVisualStyleBackColor = true;
            this.btnSearchDriver.Click += new System.EventHandler(this.btnSearchDriver_Click);
            // 
            // cmbDriverID
            // 
            this.cmbDriverID.FormattingEnabled = true;
            this.cmbDriverID.Location = new System.Drawing.Point(131, 16);
            this.cmbDriverID.Name = "cmbDriverID";
            this.cmbDriverID.Size = new System.Drawing.Size(121, 21);
            this.cmbDriverID.TabIndex = 1;
            this.cmbDriverID.SelectedIndexChanged += new System.EventHandler(this.cmbDriverID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Driver ID:";
            // 
            // btnDeleteDriverRec
            // 
            this.btnDeleteDriverRec.Location = new System.Drawing.Point(178, 104);
            this.btnDeleteDriverRec.Name = "btnDeleteDriverRec";
            this.btnDeleteDriverRec.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteDriverRec.TabIndex = 17;
            this.btnDeleteDriverRec.Text = "Delete Driver Record";
            this.btnDeleteDriverRec.UseVisualStyleBackColor = true;
            this.btnDeleteDriverRec.Click += new System.EventHandler(this.btnDeleteDriverRec_Click);
            // 
            // btnSearchDriverRec
            // 
            this.btnSearchDriverRec.Location = new System.Drawing.Point(178, 75);
            this.btnSearchDriverRec.Name = "btnSearchDriverRec";
            this.btnSearchDriverRec.Size = new System.Drawing.Size(143, 23);
            this.btnSearchDriverRec.TabIndex = 16;
            this.btnSearchDriverRec.Text = "Search Driver Record";
            this.btnSearchDriverRec.UseVisualStyleBackColor = true;
            this.btnSearchDriverRec.Click += new System.EventHandler(this.btnSearchDriverRec_Click);
            // 
            // btnAddDriverRec
            // 
            this.btnAddDriverRec.Location = new System.Drawing.Point(178, 46);
            this.btnAddDriverRec.Name = "btnAddDriverRec";
            this.btnAddDriverRec.Size = new System.Drawing.Size(143, 23);
            this.btnAddDriverRec.TabIndex = 15;
            this.btnAddDriverRec.Text = "Add Driver Record";
            this.btnAddDriverRec.UseVisualStyleBackColor = true;
            this.btnAddDriverRec.Click += new System.EventHandler(this.btnAddDriverRec_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(44, 46);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(125, 13);
            this.lblSelect.TabIndex = 14;
            this.lblSelect.Text = "Please make a selection:";
            // 
            // pnlAddDriver
            // 
            this.pnlAddDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddDriver.Controls.Add(this.btnAddDriver);
            this.pnlAddDriver.Controls.Add(this.txbDriverName);
            this.pnlAddDriver.Controls.Add(this.txbDriverID);
            this.pnlAddDriver.Controls.Add(this.label4);
            this.pnlAddDriver.Controls.Add(this.label3);
            this.pnlAddDriver.Location = new System.Drawing.Point(56, 212);
            this.pnlAddDriver.Name = "pnlAddDriver";
            this.pnlAddDriver.Size = new System.Drawing.Size(310, 153);
            this.pnlAddDriver.TabIndex = 13;
            this.pnlAddDriver.Visible = false;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(119, 80);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(125, 23);
            this.btnAddDriver.TabIndex = 13;
            this.btnAddDriver.Text = "Add";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // txbDriverName
            // 
            this.txbDriverName.Location = new System.Drawing.Point(119, 42);
            this.txbDriverName.Name = "txbDriverName";
            this.txbDriverName.Size = new System.Drawing.Size(128, 20);
            this.txbDriverName.TabIndex = 8;
            // 
            // txbDriverID
            // 
            this.txbDriverID.Location = new System.Drawing.Point(119, 14);
            this.txbDriverID.Name = "txbDriverID";
            this.txbDriverID.Size = new System.Drawing.Size(128, 20);
            this.txbDriverID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Driver Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
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
            // cmbDriverDelete
            // 
            this.cmbDriverDelete.FormattingEnabled = true;
            this.cmbDriverDelete.Location = new System.Drawing.Point(30, 54);
            this.cmbDriverDelete.Name = "cmbDriverDelete";
            this.cmbDriverDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbDriverDelete.TabIndex = 2;
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 449);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDeleteDriver);
            this.Controls.Add(this.pnlSearchDriver);
            this.Controls.Add(this.btnDeleteDriverRec);
            this.Controls.Add(this.btnSearchDriverRec);
            this.Controls.Add(this.btnAddDriverRec);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pnlAddDriver);
            this.Name = "frmDriver";
            this.Text = "frmDriver";
            this.pnlDeleteDriver.ResumeLayout(false);
            this.pnlDeleteDriver.PerformLayout();
            this.pnlSearchDriver.ResumeLayout(false);
            this.pnlSearchDriver.PerformLayout();
            this.pnlAddDriver.ResumeLayout(false);
            this.pnlAddDriver.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteDriver;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSearchDriver;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearchDriver;
        private System.Windows.Forms.ComboBox cmbDriverID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDriverRec;
        private System.Windows.Forms.Button btnSearchDriverRec;
        private System.Windows.Forms.Button btnAddDriverRec;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Panel pnlAddDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.TextBox txbDriverName;
        private System.Windows.Forms.TextBox txbDriverID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbDriverDelete;
    }
}