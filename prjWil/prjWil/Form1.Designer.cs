namespace prjWil
{
    partial class frmTrip
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
            this.btnAddTripRec = new System.Windows.Forms.Button();
            this.btnSearchTripRec = new System.Windows.Forms.Button();
            this.btnDeleteTripRec = new System.Windows.Forms.Button();
            this.pnlAddTrip = new System.Windows.Forms.Panel();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.txbTripKm = new System.Windows.Forms.TextBox();
            this.txbTripIncident = new System.Windows.Forms.TextBox();
            this.txbTripFuel = new System.Windows.Forms.TextBox();
            this.txbTripDist = new System.Windows.Forms.TextBox();
            this.txbTripDest = new System.Windows.Forms.TextBox();
            this.txbTripID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSearchTrip = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSearchTrip = new System.Windows.Forms.Button();
            this.cmbTripID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDeleteTrip = new System.Windows.Forms.Panel();
            this.btnDeleteTrip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTripDelete = new System.Windows.Forms.ComboBox();
            this.pnlAddTrip.SuspendLayout();
            this.pnlSearchTrip.SuspendLayout();
            this.pnlDeleteTrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(38, 41);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(125, 13);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Please make a selection:";
            // 
            // btnAddTripRec
            // 
            this.btnAddTripRec.Location = new System.Drawing.Point(172, 41);
            this.btnAddTripRec.Name = "btnAddTripRec";
            this.btnAddTripRec.Size = new System.Drawing.Size(114, 23);
            this.btnAddTripRec.TabIndex = 1;
            this.btnAddTripRec.Text = "Add Trip Record";
            this.btnAddTripRec.UseVisualStyleBackColor = true;
            this.btnAddTripRec.Click += new System.EventHandler(this.btnAddTripRec_Click);
            // 
            // btnSearchTripRec
            // 
            this.btnSearchTripRec.Location = new System.Drawing.Point(172, 70);
            this.btnSearchTripRec.Name = "btnSearchTripRec";
            this.btnSearchTripRec.Size = new System.Drawing.Size(114, 23);
            this.btnSearchTripRec.TabIndex = 2;
            this.btnSearchTripRec.Text = "Search Trip Record";
            this.btnSearchTripRec.UseVisualStyleBackColor = true;
            this.btnSearchTripRec.Click += new System.EventHandler(this.btnSearchTripRec_Click);
            // 
            // btnDeleteTripRec
            // 
            this.btnDeleteTripRec.Location = new System.Drawing.Point(172, 99);
            this.btnDeleteTripRec.Name = "btnDeleteTripRec";
            this.btnDeleteTripRec.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteTripRec.TabIndex = 3;
            this.btnDeleteTripRec.Text = "Delete Trip Record";
            this.btnDeleteTripRec.UseVisualStyleBackColor = true;
            this.btnDeleteTripRec.Click += new System.EventHandler(this.btnDeleteTripRec_Click);
            // 
            // pnlAddTrip
            // 
            this.pnlAddTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddTrip.Controls.Add(this.btnAddTrip);
            this.pnlAddTrip.Controls.Add(this.txbTripKm);
            this.pnlAddTrip.Controls.Add(this.txbTripIncident);
            this.pnlAddTrip.Controls.Add(this.txbTripFuel);
            this.pnlAddTrip.Controls.Add(this.txbTripDist);
            this.pnlAddTrip.Controls.Add(this.txbTripDest);
            this.pnlAddTrip.Controls.Add(this.txbTripID);
            this.pnlAddTrip.Controls.Add(this.label8);
            this.pnlAddTrip.Controls.Add(this.label7);
            this.pnlAddTrip.Controls.Add(this.label6);
            this.pnlAddTrip.Controls.Add(this.label5);
            this.pnlAddTrip.Controls.Add(this.label4);
            this.pnlAddTrip.Controls.Add(this.label3);
            this.pnlAddTrip.Location = new System.Drawing.Point(41, 146);
            this.pnlAddTrip.Name = "pnlAddTrip";
            this.pnlAddTrip.Size = new System.Drawing.Size(317, 251);
            this.pnlAddTrip.TabIndex = 4;
            this.pnlAddTrip.Visible = false;
            this.pnlAddTrip.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddTrip_Paint);
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(142, 202);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrip.TabIndex = 13;
            this.btnAddTrip.Text = "Add";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // txbTripKm
            // 
            this.txbTripKm.Location = new System.Drawing.Point(119, 156);
            this.txbTripKm.Name = "txbTripKm";
            this.txbTripKm.Size = new System.Drawing.Size(100, 20);
            this.txbTripKm.TabIndex = 12;
            // 
            // txbTripIncident
            // 
            this.txbTripIncident.Location = new System.Drawing.Point(119, 132);
            this.txbTripIncident.Name = "txbTripIncident";
            this.txbTripIncident.Size = new System.Drawing.Size(100, 20);
            this.txbTripIncident.TabIndex = 11;
            // 
            // txbTripFuel
            // 
            this.txbTripFuel.Location = new System.Drawing.Point(119, 105);
            this.txbTripFuel.Name = "txbTripFuel";
            this.txbTripFuel.Size = new System.Drawing.Size(100, 20);
            this.txbTripFuel.TabIndex = 10;
            this.txbTripFuel.TextChanged += new System.EventHandler(this.txbFuel_TextChanged);
            // 
            // txbTripDist
            // 
            this.txbTripDist.Location = new System.Drawing.Point(119, 75);
            this.txbTripDist.Name = "txbTripDist";
            this.txbTripDist.Size = new System.Drawing.Size(100, 20);
            this.txbTripDist.TabIndex = 9;
            // 
            // txbTripDest
            // 
            this.txbTripDest.Location = new System.Drawing.Point(119, 42);
            this.txbTripDest.Name = "txbTripDest";
            this.txbTripDest.Size = new System.Drawing.Size(100, 20);
            this.txbTripDest.TabIndex = 8;
            // 
            // txbTripID
            // 
            this.txbTripID.Location = new System.Drawing.Point(119, 14);
            this.txbTripID.Name = "txbTripID";
            this.txbTripID.Size = new System.Drawing.Size(100, 20);
            this.txbTripID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kilometer To Travel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trip Incidents:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Trip Fuel Usage:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trip Distance:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trip Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trip ID:";
            // 
            // pnlSearchTrip
            // 
            this.pnlSearchTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchTrip.Controls.Add(this.richTextBox1);
            this.pnlSearchTrip.Controls.Add(this.btnSearchTrip);
            this.pnlSearchTrip.Controls.Add(this.cmbTripID);
            this.pnlSearchTrip.Controls.Add(this.label1);
            this.pnlSearchTrip.Location = new System.Drawing.Point(406, 41);
            this.pnlSearchTrip.Name = "pnlSearchTrip";
            this.pnlSearchTrip.Size = new System.Drawing.Size(371, 168);
            this.pnlSearchTrip.TabIndex = 5;
            this.pnlSearchTrip.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnSearchTrip
            // 
            this.btnSearchTrip.Location = new System.Drawing.Point(271, 16);
            this.btnSearchTrip.Name = "btnSearchTrip";
            this.btnSearchTrip.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTrip.TabIndex = 2;
            this.btnSearchTrip.Text = "Search";
            this.btnSearchTrip.UseVisualStyleBackColor = true;
            this.btnSearchTrip.Click += new System.EventHandler(this.btnSearchTrip_Click);
            // 
            // cmbTripID
            // 
            this.cmbTripID.FormattingEnabled = true;
            this.cmbTripID.Location = new System.Drawing.Point(131, 16);
            this.cmbTripID.Name = "cmbTripID";
            this.cmbTripID.Size = new System.Drawing.Size(121, 21);
            this.cmbTripID.TabIndex = 1;
            this.cmbTripID.SelectedIndexChanged += new System.EventHandler(this.cmbTripID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Trip ID:";
            // 
            // pnlDeleteTrip
            // 
            this.pnlDeleteTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteTrip.Controls.Add(this.cmbTripDelete);
            this.pnlDeleteTrip.Controls.Add(this.btnDeleteTrip);
            this.pnlDeleteTrip.Controls.Add(this.label2);
            this.pnlDeleteTrip.Location = new System.Drawing.Point(406, 229);
            this.pnlDeleteTrip.Name = "pnlDeleteTrip";
            this.pnlDeleteTrip.Size = new System.Drawing.Size(371, 168);
            this.pnlDeleteTrip.TabIndex = 6;
            this.pnlDeleteTrip.Visible = false;
            // 
            // btnDeleteTrip
            // 
            this.btnDeleteTrip.Location = new System.Drawing.Point(176, 52);
            this.btnDeleteTrip.Name = "btnDeleteTrip";
            this.btnDeleteTrip.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteTrip.TabIndex = 1;
            this.btnDeleteTrip.Text = "Delete";
            this.btnDeleteTrip.UseVisualStyleBackColor = true;
            this.btnDeleteTrip.Click += new System.EventHandler(this.btnDeleteTrip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Trip ID of trip you wish to delete:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
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
            // cmbTripDelete
            // 
            this.cmbTripDelete.FormattingEnabled = true;
            this.cmbTripDelete.Location = new System.Drawing.Point(21, 52);
            this.cmbTripDelete.Name = "cmbTripDelete";
            this.cmbTripDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbTripDelete.TabIndex = 2;
            this.cmbTripDelete.SelectedIndexChanged += new System.EventHandler(this.cmbTripDelete_SelectedIndexChanged);
            // 
            // frmTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 445);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDeleteTrip);
            this.Controls.Add(this.pnlSearchTrip);
            this.Controls.Add(this.pnlAddTrip);
            this.Controls.Add(this.btnDeleteTripRec);
            this.Controls.Add(this.btnSearchTripRec);
            this.Controls.Add(this.btnAddTripRec);
            this.Controls.Add(this.lblSelect);
            this.Name = "frmTrip";
            this.Text = "frmTrip";
            this.pnlAddTrip.ResumeLayout(false);
            this.pnlAddTrip.PerformLayout();
            this.pnlSearchTrip.ResumeLayout(false);
            this.pnlSearchTrip.PerformLayout();
            this.pnlDeleteTrip.ResumeLayout(false);
            this.pnlDeleteTrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnAddTripRec;
        private System.Windows.Forms.Button btnSearchTripRec;
        private System.Windows.Forms.Button btnDeleteTripRec;
        private System.Windows.Forms.Panel pnlAddTrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSearchTrip;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearchTrip;
        private System.Windows.Forms.ComboBox cmbTripID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDeleteTrip;
        private System.Windows.Forms.Button btnDeleteTrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTripKm;
        private System.Windows.Forms.TextBox txbTripIncident;
        private System.Windows.Forms.TextBox txbTripFuel;
        private System.Windows.Forms.TextBox txbTripDist;
        private System.Windows.Forms.TextBox txbTripDest;
        private System.Windows.Forms.TextBox txbTripID;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTripDelete;
    }
}

