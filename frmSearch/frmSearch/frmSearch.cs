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

namespace frmSearch
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration
                string searchType = cboSearchType.Text;

                if (searchType.Equals("Surname"))
                {
                    string enter = txtEnterHere.Text;
                    DBConnect dObj = new DBConnect();
                    dObj.OpenConnection();
                    

                    dObj.sqlCmd = new SqlCommand("SELECT * FROM PATIENT WHERE PAT_SURNAME=@Search", dObj.sqlCon);
                    dObj.sqlCmd.Parameters.AddWithValue("@Search", enter);

                    int rows = dObj.sqlCmd.ExecuteNonQuery();
                    dObj.sqlCmd.Connection = dObj.sqlCon;

                    dObj.sqlDR = dObj.sqlCmd.ExecuteReader();
                    while (dObj.sqlDR.Read())
                    {
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_ID", dObj.sqlDR["PAT_ID"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_NAME", dObj.sqlDR["PAT_NAME"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_SURNAME", dObj.sqlDR["PAT_SURNAME"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_CONTACT_NO", dObj.sqlDR["PAT_NO"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "APPOINTMENT_DATE", dObj.sqlDR["APPOINT_DATE"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "APPOINTMENT_TIMES", dObj.sqlDR["APPOINT_TIMES"].ToString() });
                    }
                    dObj.sqlDR.Close();
                    dObj.sqlCon.Close();
                }

                else if (searchType.Equals("Contact Number"))
                {
                    string enter = txtEnterHere.Text;
                    DBConnect dObj = new DBConnect();
                    dObj.OpenConnection();

                    dObj.sqlCmd = new SqlCommand("SELECT * FROM PATIENT WHERE PAT_NO=@Search", dObj.sqlCon);
                    dObj.sqlCmd.Parameters.AddWithValue("@Search", enter);

                    int rows = dObj.sqlCmd.ExecuteNonQuery();
                    dObj.sqlCmd.Connection = dObj.sqlCon;

                    dObj.sqlDR = dObj.sqlCmd.ExecuteReader();
                    while (dObj.sqlDR.Read())
                    {
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_ID", dObj.sqlDR["PAT_ID"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_NAME", dObj.sqlDR["PAT_NAME"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_SURNAME", dObj.sqlDR["PAT_SURNAME"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "PATIENT_CONTACT_NO", dObj.sqlDR["PAT_NO"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "APPOINTMENT_DATE", dObj.sqlDR["APPOINT_DATE"].ToString() });
                        dgvDisplay.Rows.Add(new object[] { "APPOINTMENT_TIME", dObj.sqlDR["APPOINT_TIMES"].ToString() });
                    }
                    dObj.sqlDR.Close();
                    dObj.sqlCon.Close();
                }
            }
            catch (System.ArgumentException ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            catch (System.ObjectDisposedException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            catch (System.FormatException ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            catch (System.IndexOutOfRangeException ex4)
            {
                MessageBox.Show(ex4.Message);
            }
            catch (SqlException ex5)
            {
                MessageBox.Show(ex5.Message);
            } 
        }
    }
}
