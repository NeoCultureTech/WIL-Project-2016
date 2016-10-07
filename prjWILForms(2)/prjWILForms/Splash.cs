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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timerSplash.Start();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Stop();
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
