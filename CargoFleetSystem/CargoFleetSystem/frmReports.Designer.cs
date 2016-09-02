namespace CargoFleetSystem
{
    partial class frmReports
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
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabVehicleStatus = new System.Windows.Forms.TabPage();
            this.tabServiceApp = new System.Windows.Forms.TabPage();
            this.tabServiceReq = new System.Windows.Forms.TabPage();
            this.tabServiceComp = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabTimesheet = new System.Windows.Forms.TabPage();
            this.lblSelectReport = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabReports.SuspendLayout();
            this.tabVehicleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabVehicleStatus);
            this.tabReports.Controls.Add(this.tabServiceApp);
            this.tabReports.Controls.Add(this.tabServiceReq);
            this.tabReports.Controls.Add(this.tabServiceComp);
            this.tabReports.Controls.Add(this.tabReport);
            this.tabReports.Controls.Add(this.tabTimesheet);
            this.tabReports.Location = new System.Drawing.Point(12, 64);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(632, 435);
            this.tabReports.TabIndex = 0;
            // 
            // tabVehicleStatus
            // 
            this.tabVehicleStatus.Controls.Add(this.dataGridView1);
            this.tabVehicleStatus.Location = new System.Drawing.Point(4, 22);
            this.tabVehicleStatus.Name = "tabVehicleStatus";
            this.tabVehicleStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleStatus.Size = new System.Drawing.Size(624, 409);
            this.tabVehicleStatus.TabIndex = 0;
            this.tabVehicleStatus.Text = "Vehicle Status Report";
            this.tabVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // tabServiceApp
            // 
            this.tabServiceApp.Location = new System.Drawing.Point(4, 22);
            this.tabServiceApp.Name = "tabServiceApp";
            this.tabServiceApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceApp.Size = new System.Drawing.Size(624, 409);
            this.tabServiceApp.TabIndex = 1;
            this.tabServiceApp.Text = "Service Appointment List";
            this.tabServiceApp.UseVisualStyleBackColor = true;
            // 
            // tabServiceReq
            // 
            this.tabServiceReq.Location = new System.Drawing.Point(4, 22);
            this.tabServiceReq.Name = "tabServiceReq";
            this.tabServiceReq.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceReq.Size = new System.Drawing.Size(624, 409);
            this.tabServiceReq.TabIndex = 2;
            this.tabServiceReq.Text = "Service Requirements";
            this.tabServiceReq.UseVisualStyleBackColor = true;
            // 
            // tabServiceComp
            // 
            this.tabServiceComp.Location = new System.Drawing.Point(4, 22);
            this.tabServiceComp.Name = "tabServiceComp";
            this.tabServiceComp.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceComp.Size = new System.Drawing.Size(624, 409);
            this.tabServiceComp.TabIndex = 3;
            this.tabServiceComp.Text = "Services Completed";
            this.tabServiceComp.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(624, 409);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Trip Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tabTimesheet
            // 
            this.tabTimesheet.Location = new System.Drawing.Point(4, 22);
            this.tabTimesheet.Name = "tabTimesheet";
            this.tabTimesheet.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimesheet.Size = new System.Drawing.Size(624, 409);
            this.tabTimesheet.TabIndex = 5;
            this.tabTimesheet.Text = "Timesheet Report";
            this.tabTimesheet.UseVisualStyleBackColor = true;
            // 
            // lblSelectReport
            // 
            this.lblSelectReport.AutoSize = true;
            this.lblSelectReport.Location = new System.Drawing.Point(12, 29);
            this.lblSelectReport.Name = "lblSelectReport";
            this.lblSelectReport.Size = new System.Drawing.Size(253, 13);
            this.lblSelectReport.TabIndex = 1;
            this.lblSelectReport.Text = "Please Select The Report You Would Like To View:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(284, 539);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(375, 539);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 538);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 609);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSelectReport);
            this.Controls.Add(this.tabReports);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.tabReports.ResumeLayout(false);
            this.tabVehicleStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabVehicleStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabServiceApp;
        private System.Windows.Forms.TabPage tabServiceReq;
        private System.Windows.Forms.TabPage tabServiceComp;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabTimesheet;
        private System.Windows.Forms.Label lblSelectReport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
    }
}