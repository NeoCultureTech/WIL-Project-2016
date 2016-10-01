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

namespace frmDelete
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Declarations
            string patientID = txtDelID.Text;
            string patientName = txtDelName.Text;
            string patientSurname = txtDelSurname.Text;
            string patientNumber = txtDelContactNum.Text;
            string appointmentDate = dtpDelAppointDate.Text;
            string appointmentTime = txtDelAppointTime.Text;

            try
            {
                DBConnect db = new DBConnect();
                db.OpenConnection();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Parameters.AddWithValue("@patientID", txtDelID.Text);
                sqlCmd.Parameters.AddWithValue("@patientName", txtDelName.Text);
                sqlCmd.Parameters.AddWithValue("@patientSurname", txtDelSurname.Text);
                sqlCmd.Parameters.AddWithValue("@patientNumber", txtDelContactNum.Text);
                sqlCmd.Parameters.AddWithValue("@appointmentDate", dtpDelAppointDate.Text);
                sqlCmd.Parameters.AddWithValue("@appointmentTime", txtDelAppointTime.Text);
                db.SetSqlCommand(sqlCmd);
                string deleteStatement = "DELETE FROM Patient VALUES (@patientID, @patientName, @patientSurname, @patientNumber, @appointmentDate, @appointmentTime)";
                db.GiveCommand(deleteStatement);
                MessageBox.Show("Patient data successfully deleted!");

                db.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
