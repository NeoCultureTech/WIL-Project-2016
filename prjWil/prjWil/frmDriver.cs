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
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }

        private void btnAddDriverRec_Click(object sender, EventArgs e)
        {
            pnlAddDriver.Show();
        }

        private void btnSearchDriverRec_Click(object sender, EventArgs e)
        {
            pnlSearchDriver.Show();
        }

        private void btnDeleteDriverRec_Click(object sender, EventArgs e)
        {
            pnlDeleteDriver.Show();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE OBJECT
                DBConnect objNewConnect = new DBConnect();
                objNewConnect.OpenConnection();
                //QUERY COMMAND
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@DRIVER_ID,@DRIVER_NAME);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@DRIVER_ID", txbDriverID);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@DRIVER_NAME", txbDriverName);
                

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
