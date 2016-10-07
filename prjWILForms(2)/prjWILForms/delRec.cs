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
    public partial class delRec : Form
    {
        SqlCommand deleteCmd;
        SqlConnection conn;
        public delRec()
        {
            InitializeComponent();
        }

        private void delRec_Load(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source = VCDNSTDST04PC43\VARSITYCOLLEGE;Initial Catalog = CargoFleetDB; Integrated Security = True");
            deleteCmd = new SqlCommand("DELETE FROM Trip WHERE Trip_ID =" + tripTBx.Text, conn);
            try
            {
                conn.Open();
                deleteCmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
