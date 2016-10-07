using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWILForms
{
    public partial class rateMgrFrm : Form
    {
        public rateMgrFrm()
        {
            InitializeComponent();
        }

        private void rateMgrFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
        }
    }
}
