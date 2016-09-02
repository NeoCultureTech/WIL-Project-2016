namespace Splash_Test
{
    partial class SplashTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPercent = new System.Windows.Forms.Label();
            this.SplashBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPercent.Location = new System.Drawing.Point(491, 296);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 24);
            this.lblPercent.TabIndex = 8;
            // 
            // SplashBar
            // 
            this.SplashBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SplashBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SplashBar.Location = new System.Drawing.Point(39, 296);
            this.SplashBar.MarqueeAnimationSpeed = 5;
            this.SplashBar.Name = "SplashBar";
            this.SplashBar.Size = new System.Drawing.Size(433, 31);
            this.SplashBar.Step = 0;
            this.SplashBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SplashBar.TabIndex = 9;
            this.SplashBar.Click += new System.EventHandler(this.SplashBar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 339);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.SplashBar);
            this.Name = "SplashTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SplashBar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar SplashBar;
        private System.Windows.Forms.Timer timer1;
    }
}

