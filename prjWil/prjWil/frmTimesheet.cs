using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWil
{
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTimeRec_Click(object sender, EventArgs e)
        {
            pnlAddTime.Show();
        }

        private void btnSearchTimeRec_Click(object sender, EventArgs e)
        {
            pnlSearchTime.Show();
        }

        private void btnDeleteTimeRec_Click(object sender, EventArgs e)
        {
            pnlDeleteTime.Show();
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE OBJECT
                DBConnect objNewConnect = new DBConnect();
                objNewConnect.OpenConnection();
                //QUERY COMMAND
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TIMESHEET VALUES (@EMPLOYEE_ID,@EMPLOYEE_OVERTIME,@HOURS_WORKED);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ID", txbEmpID);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_OVERTIME", txbEmpOver);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@HOURS_WORKED", txbHours);



                objNewConnect.sqlDR = objNewConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFULLY ADDED NEW EMPLOYEE TO THE DATABASE");//FEEDBACK
                objNewConnect.sqlDR.Close();
                objNewConnect.sqlConn.Close(); //CLOSE CONNECTION

            }

            catch
            {

            }
        }

        private void btnSearchTime_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objPopulateCbo = new DBConnect();
                objPopulateCbo.OpenConnection();
                objPopulateCbo.sqlCmd = new SqlCommand("SELECT EMPLOYEE ID FROM RATES;", objPopulateCbo.sqlConn);
                objPopulateCbo.sqlDR = objPopulateCbo.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("EMPLOYEE_ID", typeof(string));
                dt.Load(objPopulateCbo.sqlDR);

                cmbEmpID.ValueMember = "EMPLOYEE_ID";
                cmbEmpID.DisplayMember = "EMPLOYEE_ID";
                cmbEmpID.DataSource = dt;
                objPopulateCbo.sqlConn.Close();
            }
            catch
            {

            }
        }

        private void btnDeleteTime_Click(object sender, EventArgs e)
        {
            int EMPLOYEE_ID = int.Parse(cmbTimesheetDelete.SelectedValue.ToString());
            DBConnect objConnect = new DBConnect();
            objConnect.OpenConnection();
            try
            {
                objConnect.sqlCmd = new SqlCommand("DELETE FROM TIMESHEET WHERE (EMPLOYEE_ID =@EMPLOYEE_ID);", objConnect.sqlConn);
                objConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ID", EMPLOYEE_ID);

                objConnect.sqlDR = objConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY DELETED TIMESHEET FROM DATABASE.");

                objConnect.sqlDR.Close();
                objConnect.sqlConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion unsuccessful." + ex.Message);
            }
        }
    }
}
