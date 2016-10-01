using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmEdit
{
    public class DBConnect
    {
        //Declarations
        public SqlConnection sqlCon;
        public SqlCommand sqlCmd;
        public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;

        //Method to create connection to database
        public void OpenConnection()
        {
            try
            {
                sqlCon = new SqlConnection();
                sqlCon.ConnectionString = ("Data Source=DANIELH\\SQL_DANIEL;Initial Catalog=ProgAssignment2;Integrated Security=True");
                sqlCon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error - Connection not established! \n" + e.Message);
            }
        }

        //Method to give/execute commands
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

        //Method changes the SqlCommand to have appropriate values (Requires parameters)
        public void SetSqlCommand(SqlCommand cmd)
        {
            sqlCmd = cmd;
        }

        //Method creates a new SqlCommand that requires no parameters
        public void SetSqlCommand()
        {
            sqlCmd = new SqlCommand();
        }

        //Method
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

        //Method
        public static SqlDataAdapter GetSqlDataAdapter(SqlConnection sqlCon)
        {
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            return sqlDA;
        }

        //Method
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

        //Method that closes the connection
        public void CloseConnection()
        {
            try
            {
                sqlCon.Close();
            }
            catch (Exception Ex3)
            {
                MessageBox.Show("Error - Connection not closed! \n" + Ex3.Message);
            }
        }
    }
}
