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

namespace prjDBConnect
{
    public partial class frmDBConnect : Form
    {
        public frmDBConnect()
        {
            InitializeComponent();
        }

        public class DBconnect
        {
            frmDBConnect objMethods = new frmDBConnect();

            public SqlConnection sqlCon;
            public SqlCommand sqlCmd;
            public SqlDataReader sqlDR;
            public SqlDataAdapter sqlDA;

            public void OpenConnection()
            {
                try
                {
                    sqlCon = new SqlConnection();
                    sqlCon.ConnectionString = ("Data Source  = (local);Initial Catalog = WIL Database; Integrated Security = True");
                    sqlCon.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error - Connection not established! \n" + e.Message);
                }
            }

            public void GiveCommand(String gSql)
            {
                try
                {
                    sqlCmd = new SqlCommand();
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = gSql;
                }

                catch (Exception e)
                {
                    MessageBox.Show("Error - Command not executed! \n" + e.Message);
                }
            }

            public SqlDataReader GetSqlDR(String gSQL)
            {
                SqlDataReader sqlDR;
                try
                {
                    OpenConnection();
                    GiveCommand(gSQL);
                    sqlDR = sqlCmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error - Database Error! \n" + ex.Message);
                    sqlDR = null;
                }
                return sqlDR;
            }

            public static SqlDataAdapter GetSqlDataAdapter(SqlConnection sqlCon)
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                return sqlDA;

                //Command list

            }

            public void DisplayDetails(DataGridView dgv, String gSql)
            {
                try
                {
                    dgv.AutoResizeColumns();
                    GiveCommand(gSql);
                    sqlDA = new SqlDataAdapter(sqlCmd);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (SqlException Ex1)
                {
                    MessageBox.Show("Error! \n" + Ex1.Message);

                }
                catch (Exception Ex2)
                {
                    MessageBox.Show("Error! \n" + Ex2.Message);
                }
            }

            public void CloseConnection()
            {
                try
                {
                    sqlCon.Close();
                }
                catch (Exception Ex3)
                {
                    MessageBox.Show("Error! \n" + Ex3.Message);
                }
            }
        }
    }
}
