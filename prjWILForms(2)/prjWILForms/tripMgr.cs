using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjWILForms
{
    public partial class frmTripMgr : Form
    {
        DBconnect dbc = new DBconnect();

        AddRec AR;
        delRec DR;
        frmLogin lg;

        public frmTripMgr()
        {
            InitializeComponent();
        }

        private void frmTripMgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            lg = new frmLogin();
            lg.Show();
        }

        private void frmTripMgr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cargoFleetDBDataSet1.Trip' table. You can move, or remove it, as needed.
            //this.tripTableAdapter1.Fill(this.cargoFleetDBDataSet1.Trip);
            try
            {
                //dbc.OpenConnection();
                //dbc.sqlCmd = new SqlCommand(@"SELECT Count(*) FROM Trip" dbc.sqlCon);
                //dbc.sqlCmd.Parameters.AddWithValue("@L_Name");

                //dbc.sqlCmd.ExecuteNonQuery();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                //DataGridView dgv, SqlCommand cmd, SqlDataAdapter sqlDA, SqlConnection conn
                dbc.sqlCmd = new SqlCommand(@"SELECT Count(*) FROM Trip");


                dbc.DisplayDetails(tripMgrDataGrid, dbc.sqlCmd, dbc.sqlCmd.CommandText, sqlDA,dbc.sqlCon);

            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

            //dbc.OpenConnection();
            //@"SELECT Count(*) FROM Logins WHERE Email=@Email and Password=@Password and UserID=@UserID", dbc.sqlCon);
            //dbc.sqlCmd = new SqlCommand(@"SELECT * FROM Trip" dbc.sqlCon);
            //tripMgrDataGrid.DataSource = cargoFleetDBDataSet.Trip;
            //dbc.sqlCmd.ExecuteNonQuery();
        }

        private void viewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void AddRecBtn_Click(object sender, EventArgs e)
        {
            AR = new AddRec();
            AR.Show();
        }

        private void delRecBtn_Click(object sender, EventArgs e)
        {
            DR = new delRec();
            DR.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            tripMgrDataGrid.Refresh();
            tripMgrDataGrid.Update();
        }

        private void mnuTripMgrBtn_Click(object sender, EventArgs e)
        {
            lg = new frmLogin();
            lg.Show();
        }
    }
}
