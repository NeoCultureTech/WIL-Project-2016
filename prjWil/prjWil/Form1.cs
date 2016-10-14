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
    public partial class frmTrip : Form
    {
        public frmTrip()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddTrip_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbFuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchTrip_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objPopulateCbo = new DBConnect();
                objPopulateCbo.OpenConnection();
                objPopulateCbo.sqlCmd = new SqlCommand("SELECT Trip ID FROM Trip;", objPopulateCbo.sqlConn);
                objPopulateCbo.sqlDR = objPopulateCbo.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TRIP_ID", typeof(string));
                dt.Load(objPopulateCbo.sqlDR);

                cmbTripID.ValueMember = "TRIP_ID";
                cmbTripID.DisplayMember = "TRIP_ID";
                cmbTripID.DataSource = dt;
                objPopulateCbo.sqlConn.Close();
            }
            catch
            {

            }
        }

        private void btnAddTripRec_Click(object sender, EventArgs e)
        {
            pnlAddTrip.Show();
        }

        private void btnSearchTripRec_Click(object sender, EventArgs e)
        {
            pnlSearchTrip.Show();
        }

        private void btnDeleteTripRec_Click(object sender, EventArgs e)
        {
            pnlDeleteTrip.Show();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            try
            {
				//CREATE OBJECT
                                DBConnect objNewConnect = new DBConnect();
                                objNewConnect.OpenConnection();
				//QUERY COMMAND
                                objNewConnect.sqlCmd = new SqlCommand("INSERT INTO TRIP VALUES (@TRIP_ID,@TRIP_DESTINATION,@TRIP_DISTANCE,@TRIP_FUEL_USAGE,@TRIP_INCIDENTS, @KilometresToTravel);", objNewConnect.sqlConn);
                                objNewConnect.sqlCmd.Parameters.AddWithValue("@TRIP_ID", txbTripID);
                                objNewConnect.sqlCmd.Parameters.AddWithValue("@TRIP_DESTINATION", txbTripDest);
                                objNewConnect.sqlCmd.Parameters.AddWithValue("@TRIP_DISTANCE", txbTripDist);
                                objNewConnect.sqlCmd.Parameters.AddWithValue("@TRIP_FUEL_USAGE", txbTripFuel);
                                objNewConnect.sqlCmd.Parameters.AddWithValue("@TRIP_INCIDENTS", txbTripIncident);
                                objNewConnect.sqlCmd.Parameters.AddWithValue("@KilometresToTravel", txbTripKm);
                                
                                objNewConnect.sqlDR = objNewConnect.sqlCmd.ExecuteReader();

                                MessageBox.Show("SUCCESSFULLY ADDED NEW VEHICLE TO THE DATABASE");//FEEDBACK
                                objNewConnect.sqlDR.Close();
                                objNewConnect.sqlConn.Close(); //CLOSE CONNECTION
                                
            }   

			    catch
			      {

			      }

            }

        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
           int TRIP_ID = int.Parse(cmbTripDelete.SelectedValue.ToString());
            DBConnect objConnect = new DBConnect();
            objConnect.OpenConnection();
            try
            {
                objConnect.sqlCmd = new SqlCommand("DELETE FROM TRIP WHERE (TRIP_ID =@TRIP_ID);", objConnect.sqlConn);
                objConnect.sqlCmd.Parameters.AddWithValue("@TRIP_ID", TRIP_ID);

                objConnect.sqlDR = objConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY DELETED TRIP FROM DATABASE.");

                objConnect.sqlDR.Close();
                objConnect.sqlConn.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion unsuccessful." + ex.Message);
            }
        }

        private void cmbTripDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnect objPopulateCbo = new DBConnect();
                objPopulateCbo.OpenConnection();
                objPopulateCbo.sqlCmd = new SqlCommand("SELECT Distinct TRIP_ID FROM TRIP;", objPopulateCbo.sqlConn);
                objPopulateCbo.sqlDR = objPopulateCbo.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TRIP_ID", typeof(string));
                dt.Load(objPopulateCbo.sqlDR);

                cmbTripDelete.ValueMember = "TRIP_ID";
                cmbTripDelete.DisplayMember = "TRIP_ID";
                cmbTripDelete.DataSource = dt;

                objPopulateCbo.sqlConn.Close();
            }

            catch
            {

            }
        }

        private void cmbTripID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnect objPopulateCbo = new DBConnect();
                objPopulateCbo.OpenConnection();
                objPopulateCbo.sqlCmd = new SqlCommand("SELECT Distinct TRIP_ID FROM TRIP;", objPopulateCbo.sqlConn);
                objPopulateCbo.sqlDR = objPopulateCbo.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TRIP_ID", typeof(string));
                dt.Load(objPopulateCbo.sqlDR);

                cmbTripDelete.ValueMember = "TRIP_ID";
                cmbTripDelete.DisplayMember = "TRIP_ID";
                cmbTripDelete.DataSource = dt;

                objPopulateCbo.sqlConn.Close();
            }

            catch
            {

            }
        }
    }
    }

