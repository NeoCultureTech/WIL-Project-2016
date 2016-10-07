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
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        private void btnAddServiceRec_Click(object sender, EventArgs e)
        {
            pnlAddService.Show();
        }

        private void btnSearchServiceRec_Click(object sender, EventArgs e)
        {
            pnlSearchService.Show();
        }

        private void btnDeleteServiceRec_Click(object sender, EventArgs e)
        {
            pnlDeleteService.Show();
        }

        private void btnAddSercice_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE OBJECT
                DBConnect objNewConnect = new DBConnect();
                objNewConnect.OpenConnection();
                //QUERY COMMAND
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@APPOINTMENT_TIME,@VEHICLE_NO,@SERVICE_TO_PERFORM,@PROCEDURE_CODE,@SERVICE_DESCRIPTION);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@APPOINTMENT_TIME", txbAppointTime);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@VEHICLE_NO", txbVehNo);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@SERVICE_TO_PERFORM",txbServPerform);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@PROCEDURE_CODE", txbProcCode);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@SERVICE_DESCRIPTION", txbServDescrip);


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
