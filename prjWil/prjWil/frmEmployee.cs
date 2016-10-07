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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmpRec_Click(object sender, EventArgs e)
        {
            pnlAddEmp.Show();
        }

        private void btnSearchEmpRec_Click(object sender, EventArgs e)
        {
            pnlSearchEmp.Show();
        }

        private void btnDeleteEmpRec_Click(object sender, EventArgs e)
        {
            pnlDeleteEmp.Show();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                //CREATE OBJECT
                DBConnect objNewConnect = new DBConnect();
                objNewConnect.OpenConnection();
                //QUERY COMMAND
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@EMPLOYEE_ID,@EMPLOYEE_ROLE,@EMPLOYEE_OVERTIME,@ADMIN_ID);", objNewConnect.sqlConn);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ID", txbEmpID);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ROLE", txbEmpRole);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_OVERTIME", txbEmpOver);
                objNewConnect.sqlCmd.Parameters.AddWithValue("@ADMIN_ID", txbAdminID);

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
