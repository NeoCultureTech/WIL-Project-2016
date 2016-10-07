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
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@EMPLOYEE_ID,@EMPLOYEE_OVERTIME,@HOURS_WORKED);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ID", txbEmpID);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_OVERTIME", txbEmpOver);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@HOURS_WORKED", txbHours);



                objNewConnect.sqlDR = objNewConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFULLY ADDED NEW VEHICLE TO THE DATABASE");//FEEDBACK
                objNewConnect.sqlDR.Close();
                objNewConnect.sqlConn.Close(); //CLOSE CONNECTION

            }

            catch
            {

            }
        }
    }
}
