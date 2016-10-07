namespace prjWILForms
{
    partial class frmTripMgr
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tripMgrDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cargoFleetDBDataSet1 = new prjWILForms.CargoFleetDBDataSet1();
            this.cargoFleetDBDataSet = new prjWILForms.CargoFleetDBDataSet();
            this.cancelTripMgrBtn = new System.Windows.Forms.Button();
            this.AddRecBtn = new System.Windows.Forms.Button();
            this.editRec = new System.Windows.Forms.Button();
            this.mnuTripMgrBtn = new System.Windows.Forms.Button();
            this.delRecBtn = new System.Windows.Forms.Button();
            this.tripTableAdapter = new prjWILForms.CargoFleetDBDataSetTableAdapters.TripTableAdapter();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripTableAdapter1 = new prjWILForms.CargoFleetDBDataSet1TableAdapters.TripTableAdapter();
            this.tripBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tripBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripMgrDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoFleetDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoFleetDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 47);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(534, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome: user101";
            // 
            // tripMgrDataGrid
            // 
            this.tripMgrDataGrid.AllowUserToAddRows = false;
            this.tripMgrDataGrid.AllowUserToDeleteRows = false;
            this.tripMgrDataGrid.AllowUserToOrderColumns = true;
            this.tripMgrDataGrid.AutoGenerateColumns = false;
            this.tripMgrDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripMgrDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.tripMgrDataGrid.DataSource = this.tripBindingSource3;
            this.tripMgrDataGrid.Location = new System.Drawing.Point(0, 68);
            this.tripMgrDataGrid.Name = "tripMgrDataGrid";
            this.tripMgrDataGrid.ReadOnly = true;
            this.tripMgrDataGrid.Size = new System.Drawing.Size(743, 279);
            this.tripMgrDataGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TRIP_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "TRIP_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TRIP_DESTINATION";
            this.dataGridViewTextBoxColumn9.HeaderText = "TRIP_DESTINATION";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TRIP_DISTANCE";
            this.dataGridViewTextBoxColumn10.HeaderText = "TRIP_DISTANCE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TRIP_FUEL_USAGE";
            this.dataGridViewTextBoxColumn11.HeaderText = "TRIP_FUEL_USAGE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TRIP_INCIDENTS";
            this.dataGridViewTextBoxColumn12.HeaderText = "TRIP_INCIDENTS";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DRIVER_ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "DRIVER_ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "KilometresToTravel";
            this.dataGridViewTextBoxColumn14.HeaderText = "KilometresToTravel";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // tripBindingSource3
            // 
            this.tripBindingSource3.DataMember = "Trip";
            this.tripBindingSource3.DataSource = this.cargoFleetDBDataSet1;
            // 
            // cargoFleetDBDataSet1
            // 
            this.cargoFleetDBDataSet1.DataSetName = "CargoFleetDBDataSet1";
            this.cargoFleetDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoFleetDBDataSet
            // 
            this.cargoFleetDBDataSet.DataSetName = "CargoFleetDBDataSet";
            this.cargoFleetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelTripMgrBtn
            // 
            this.cancelTripMgrBtn.Location = new System.Drawing.Point(13, 382);
            this.cancelTripMgrBtn.Name = "cancelTripMgrBtn";
            this.cancelTripMgrBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelTripMgrBtn.TabIndex = 3;
            this.cancelTripMgrBtn.Text = "Cancel";
            this.cancelTripMgrBtn.UseVisualStyleBackColor = true;
            // 
            // AddRecBtn
            // 
            this.AddRecBtn.Location = new System.Drawing.Point(650, 353);
            this.AddRecBtn.Name = "AddRecBtn";
            this.AddRecBtn.Size = new System.Drawing.Size(81, 23);
            this.AddRecBtn.TabIndex = 4;
            this.AddRecBtn.Text = "Add Record";
            this.AddRecBtn.UseVisualStyleBackColor = true;
            this.AddRecBtn.Click += new System.EventHandler(this.AddRecBtn_Click);
            // 
            // editRec
            // 
            this.editRec.Location = new System.Drawing.Point(624, 382);
            this.editRec.Name = "editRec";
            this.editRec.Size = new System.Drawing.Size(107, 23);
            this.editRec.TabIndex = 5;
            this.editRec.Text = "Edit Record";
            this.editRec.UseVisualStyleBackColor = true;
            // 
            // mnuTripMgrBtn
            // 
            this.mnuTripMgrBtn.Location = new System.Drawing.Point(322, 382);
            this.mnuTripMgrBtn.Name = "mnuTripMgrBtn";
            this.mnuTripMgrBtn.Size = new System.Drawing.Size(75, 23);
            this.mnuTripMgrBtn.TabIndex = 8;
            this.mnuTripMgrBtn.Text = "Main Menu";
            this.mnuTripMgrBtn.UseVisualStyleBackColor = true;
            this.mnuTripMgrBtn.Click += new System.EventHandler(this.mnuTripMgrBtn_Click);
            // 
            // delRecBtn
            // 
            this.delRecBtn.Location = new System.Drawing.Point(534, 352);
            this.delRecBtn.Name = "delRecBtn";
            this.delRecBtn.Size = new System.Drawing.Size(90, 23);
            this.delRecBtn.TabIndex = 9;
            this.delRecBtn.Text = "Delete Record";
            this.delRecBtn.UseVisualStyleBackColor = true;
            this.delRecBtn.Click += new System.EventHandler(this.delRecBtn_Click);
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(534, 382);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.cargoFleetDBDataSet1;
            // 
            // tripTableAdapter1
            // 
            this.tripTableAdapter1.ClearBeforeFill = true;
            // 
            // frmTripMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 417);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delRecBtn);
            this.Controls.Add(this.mnuTripMgrBtn);
            this.Controls.Add(this.editRec);
            this.Controls.Add(this.AddRecBtn);
            this.Controls.Add(this.cancelTripMgrBtn);
            this.Controls.Add(this.tripMgrDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "frmTripMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTripMgr_FormClosing);
            this.Load += new System.EventHandler(this.frmTripMgr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripMgrDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoFleetDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoFleetDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tripMgrDataGrid;
        private System.Windows.Forms.Button cancelTripMgrBtn;
        private System.Windows.Forms.Button AddRecBtn;
        private System.Windows.Forms.Button editRec;
        private System.Windows.Forms.Button mnuTripMgrBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPDESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPDISTANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPFUELUSAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPINCIDENTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRIVERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometresToTravelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delRecBtn;
        private System.Windows.Forms.BindingSource tripBindingSource1;
        private System.Windows.Forms.BindingSource tripBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private CargoFleetDBDataSet cargoFleetDBDataSet;
        private CargoFleetDBDataSetTableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.Button refreshBtn;
        private CargoFleetDBDataSet1 cargoFleetDBDataSet1;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private CargoFleetDBDataSet1TableAdapters.TripTableAdapter tripTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource tripBindingSource3;
    }
}