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

namespace frmEdit
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Declarations
            string patientID = txtEditID.Text;
            string patientName = txtEditName.Text;
            string patientSurname = txtEditSurname.Text;
            string patientNumber = txtEditContactNum.Text;
            string appointmentDate = dtpEditAppointDate.Text;
            string appointmentTime = txtEditAppointTime.Text;

            try
            {
                DBConnect db = new DBConnect();
                db.OpenConnection();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Parameters.AddWithValue("@patientID", txtEditID.Text);
                sqlCmd.Parameters.AddWithValue("@patientName", txtEditName.Text);
                sqlCmd.Parameters.AddWithValue("@patientSurname", txtEditSurname.Text);
                sqlCmd.Parameters.AddWithValue("@patientNumber", txtEditContactNum.Text);
                sqlCmd.Parameters.AddWithValue("@appointmentDate", dtpEditAppointDate.Text);
                sqlCmd.Parameters.AddWithValue("@appointmentTime", txtEditAppointTime.Text);
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
