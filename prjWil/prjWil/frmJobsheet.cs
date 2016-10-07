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
    public partial class frmJobsheet : Form
    {
        public frmJobsheet()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddJobRec_Click(object sender, EventArgs e)
        {
            pnlAddJob.Show();
        }

        private void btnSearchJobRec_Click(object sender, EventArgs e)
        {
            pnlSearchJob.Show();
        }

        private void btnDeleteJobRec_Click(object sender, EventArgs e)
        {
            pnlDeleteJob.Show();
        }

        private void pnlDeleteJob_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddSercice_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE OBJECT
                DBConnect objNewConnect = new DBConnect();
                objNewConnect.OpenConnection();
                //QUERY COMMAND
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@VEHICLE_NO,@SERVICE_TYPE,@APPOINTMENT_TIME,@WORK_TBC);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@VEHICLE_NO", txbVehiNo);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@SERVICE_TYPE", txbServType);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@APPOINTMENT_TIME", txbAppointTime);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@WORK_TBC", txbWork);

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
