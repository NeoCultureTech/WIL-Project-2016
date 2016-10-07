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
    public partial class frmRates : Form
    {
        public frmRates()
        {
            InitializeComponent();
        }

        private void btnAddEmpRec_Click(object sender, EventArgs e)
        {
            pnlAddRates.Show();
        }

        private void btnSearchEmpRec_Click(object sender, EventArgs e)
        {
            pnlSearchRates.Show();
        }

        private void btnDeleteEmpRec_Click(object sender, EventArgs e)
        {
            pnlDeleteRates.Show();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE OBJECT
                DBConnect objNewConnect = new DBConnect();
                objNewConnect.OpenConnection();
                //QUERY COMMAND
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@PAY_AMOUNT,@EMPLOYEE_ID);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@PAY_AMOUNT", txbPayAmt);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ID", txbEmpID);


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
