using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjWILForms
{
    public partial class AddRec : Form
    {
        SqlCommand insert;
        SqlConnection conn;
        public AddRec()
        {
            InitializeComponent();
        }

        private void AddRec_Load(object sender, EventArgs e)
        {
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Connection string
            conn = new SqlConnection(@"Data Source = VCDNSTDST04PC43\VARSITYCOLLEGE;Initial Catalog = CargoFleetDB; Integrated Security = True");

            //insert sql command
            insert = new SqlCommand("INSERT INTO Trip(TRIP_ID, TRIP_DESTINATION, TRIP_DISTANCE, TRIP_FUEL_USAGE, TRIP_INCIDENTS, DRIVER_ID, KilometresToTravel) VALUES (@TRIP_ID, @TRIP_DESTINATION, @TRIP_DISTANCE, @TRIP_FUEL_USAGE, @TRIP_INCIDENTS, @DRIVER_ID, @KilometresToTravel)", conn);
            insert.Parameters.AddWithValue("@TRIP_ID", tripIDTBx.Text);
            insert.Parameters.AddWithValue("@TRIP_DESTINATION", DestTBx.Text);
            insert.Parameters.AddWithValue("@TRIP_DISTANCE", DistanceTBx.Text);
            insert.Parameters.AddWithValue("@TRIP_FUEL_USAGE", fuelTBx.Text);
            insert.Parameters.AddWithValue("@TRIP_INCIDENTS", incidentsTBx.Text);
            insert.Parameters.AddWithValue("@DRIVER_ID", drivIdTBx.Text);
            insert.Parameters.AddWithValue("@KilometresToTravel", travelTBx.Text);

            //
            if (tripIDTBx.Text == string.Empty)
            {
                MessageBox.Show("Trip ID Cannot be Null");
                return;
            }
            else if (drivIdTBx.Text == string.Empty)
            {
                MessageBox.Show("Diver ID Cannot be Null");
                return;
            }


            try
            {
                conn.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Register done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                conn.Close();
            }
        }
    }
}
