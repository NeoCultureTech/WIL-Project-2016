using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Splash_Test
{
    public partial class SplashTest : Form
    {
        public SplashTest()
        {
            InitializeComponent();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if (SplashBar.Value <= 80)
            {
                Random rnPercent = new Random();
                int rnNum1 = rnPercent.Next(1, 31);
                SplashBar.Value += rnNum1;
                lblPercent.Text = SplashBar.Value.ToString() + "%";
            }

            else if (SplashBar.Value >= 80)//slows down the progress bar
            {
                Random rn1Percent = new Random();
                int rnNum2 = rn1Percent.Next(1, 2);
                SplashBar.Value += rnNum2;
                lblPercent.Text = SplashBar.Value.ToString() + "%";

                if (SplashBar.Value >= 100)
                {
                    timer1.Stop();
                    MessageBox.Show("End Of Splash");
                     
                }

            }
        }

        
    }
}
