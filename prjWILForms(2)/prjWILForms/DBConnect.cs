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

namespace prjWILForms
{
    public class DBconnect
    {
        public SqlConnection sqlCon;
        public SqlCommand sqlCmd;
        public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;

        public void OpenConnection()
        {
            try
            {
                sqlCon = new SqlConnection();
                sqlCon.ConnectionString = (@"Data Source = VCDNSTDST04PC17\VARSITYCOLLEGE;Initial Catalog = CargoFleetDB; Integrated Security = True");
                sqlCon.Open();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error - Connection not established! \n" + e.Message);
            }
        }

        public void GiveCommand(String gSql, SqlConnection conn)
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
                GiveCommand(gSQL, sqlCon);
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

        public void DisplayDetails(DataGridView dgv, SqlCommand cmd,string sqlText, SqlDataAdapter sqlDA, SqlConnection conn)
        {
            try
            {
                conn = sqlCon;
                cmd = sqlCmd;
                sqlText = cmd.CommandText;
                conn = new SqlConnection();
                OpenConnection();
                cmd = new SqlCommand(sqlText, conn);
                sqlDA = new SqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDA.Fill(dtRecord);
                dgv.DataSource = dtRecord;
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

