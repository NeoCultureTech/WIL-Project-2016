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
    public partial class frmLogin : Form
    {

        DBconnect dbc = new DBconnect();
        serviceMagr sm;
        rateMgrFrm rm;
        frmTripMgr tp;
        FrmForgotPass fp;
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                dbc.sqlCmd = new SqlCommand(@"SELECT Count(*) FROM Logins WHERE Email=@Email and Password=@Password and UserID=@UserID", dbc.sqlCon);
                dbc.sqlCmd.Parameters.AddWithValue("@Email", emailTBx.Text);
                dbc.sqlCmd.Parameters.AddWithValue("@Password", passTBx.Text);
                dbc.sqlCmd.Parameters.AddWithValue("@UserID", logAsCBx.Text);
                int result = (int)dbc.sqlCmd.ExecuteScalar();
                if (result == 1)
                {
                    MessageBox.Show("Success");
                    if (logAsCBx.Text == "Service Manager")
                    {
                        sm = new serviceMagr();
                        sm.Show();
                        this.Hide();
                    }
                    else if (logAsCBx.Text == "Rates Manager")
                    {
                        rm = new rateMgrFrm();
                        rm.Show();
                        this.Hide();
                    }
                    else if (logAsCBx.Text == "Trip Manager")
                    {
                        tp = new frmTripMgr();
                        tp.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Incorrect Details");
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        } 

        private void forgotPwBtn_Click(object sender, EventArgs e)
        {
            fp = new FrmForgotPass();
            fp.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbc.OpenConnection();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
