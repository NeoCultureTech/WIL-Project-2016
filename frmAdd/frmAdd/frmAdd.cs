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

namespace frmAdd
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Declarations
            string patientID = txtAddID.Text;
            string patientName = txtAddName.Text;
            string patientSurname = txtAddSurname.Text;
            string patientNumber = txtAddContactNum.Text;
            string appointmentDate = dtpAddAppointDate.Text;
            string appointmentTime = txtAddAppointTime.Text;

            try
            {
                DBConnect db = new DBConnect();
                db.OpenConnection();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Parameters.AddWithValue("@patientID", txtAddID.Text);
                sqlCmd.Parameters.AddWithValue("@patientName", txtAddName.Text);
                sqlCmd.Parameters.AddWithValue("@patientSurname", txtAddSurname.Text);
                sqlCmd.Parameters.AddWithValue("@patientNumber", txtAddContactNum.Text);
                sqlCmd.Parameters.AddWithValue("@appointmentDate", dtpAddAppointDate.Text);
                sqlCmd.Parameters.AddWithValue("@appointmentTime", txtAddAppointTime.Text);
                db.SetSqlCommand(sqlCmd);
                string insertStatement = "INSERT INTO Patient VALUES (@patientID, @patientName, @patientSurname, @patientNumber, @appointmentDate, @appointmentTime)";
                db.GiveCommand(insertStatement);
                MessageBox.Show("Patient data successfully added!");

                db.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
