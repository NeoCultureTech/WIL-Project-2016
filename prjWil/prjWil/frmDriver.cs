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
                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO DRIVER VALUES (@DRIVER_ID,@DRIVER_NAME);", objNewConnect.sqlConn);
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

        private void btnSearchDriver_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objPopulateCbo = new DBConnect();
                objPopulateCbo.OpenConnection();
                objPopulateCbo.sqlCmd = new SqlCommand("SELECT Driver ID FROM Driver;", objPopulateCbo.sqlConn);
                objPopulateCbo.sqlDR = objPopulateCbo.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("DRIVER_ID", typeof(string));
                dt.Load(objPopulateCbo.sqlDR);

                cmbDriverID.ValueMember = "DRIVER_ID";
                cmbDriverID.DisplayMember = "DRIVER_ID";
                cmbDriverID.DataSource = dt;
                objPopulateCbo.sqlConn.Close();
            }
            catch
            {

            }
        }

        private void cmbDriverID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            int DRIVER_ID = int.Parse(cmbDriverDelete.SelectedValue.ToString());
            DBConnect objConnect = new DBConnect();
            objConnect.OpenConnection();
            try
            {
                objConnect.sqlCmd = new SqlCommand("DELETE FROM DRIVER WHERE (DRIVER_ID =@DRIVER_ID);", objConnect.sqlConn);
                objConnect.sqlCmd.Parameters.AddWithValue("@DRIVER_ID", DRIVER_ID);

                objConnect.sqlDR = objConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY DELETED DRIVER FROM DATABASE.");

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
