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
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO RATES VALUES (@PAY_AMOUNT,@EMPLOYEE_ID);", objNewConnect.sqlConn);
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

        private void btnSearchEmp_Click(object sender, EventArgs e)
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

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            int EMPLOYEE_ID = int.Parse(cmbRatesDelete.SelectedValue.ToString());
            DBConnect objConnect = new DBConnect();
            objConnect.OpenConnection();
            try
            {
                objConnect.sqlCmd = new SqlCommand("DELETE FROM RATES WHERE (EMPLOYEE_ID =@EMPLOYEE_ID);", objConnect.sqlConn);
                objConnect.sqlCmd.Parameters.AddWithValue("@EMPLOYEE_ID", EMPLOYEE_ID);

                objConnect.sqlDR = objConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY DELETED RATES FROM DATABASE.");

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
