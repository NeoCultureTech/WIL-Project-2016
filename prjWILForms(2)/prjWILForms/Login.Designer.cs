namespace prjWILForms
{
    partial class frmLogin
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
            this.logAsCBx = new System.Windows.Forms.ComboBox();
            this.logAsLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passTBx = new System.Windows.Forms.TextBox();
            this.rememCBx = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.creditLbl = new System.Windows.Forms.Label();
            this.uNameLbl = new System.Windows.Forms.Label();
            this.emailTBx = new System.Windows.Forms.TextBox();
            this.forgotPwBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logAsCBx
            // 
            this.logAsCBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logAsCBx.FormattingEnabled = true;
            this.logAsCBx.Items.AddRange(new object[] {
            "Trip Manager",
            "Rates Manager",
            "Service Manager"});
            this.logAsCBx.Location = new System.Drawing.Point(69, 84);
            this.logAsCBx.Name = "logAsCBx";
            this.logAsCBx.Size = new System.Drawing.Size(121, 21);
            this.logAsCBx.TabIndex = 0;
            this.logAsCBx.Text = "Rates Manager";
            // 
            // logAsLbl
            // 
            this.logAsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logAsLbl.AutoSize = true;
            this.logAsLbl.Location = new System.Drawing.Point(12, 92);
            this.logAsLbl.Name = "logAsLbl";
            this.logAsLbl.Size = new System.Drawing.Size(51, 13);
            this.logAsLbl.TabIndex = 1;
            this.logAsLbl.Text = "Login As:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(15, 167);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // passTBx
            // 
            this.passTBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passTBx.Location = new System.Drawing.Point(69, 160);
            this.passTBx.Name = "passTBx";
            this.passTBx.PasswordChar = '*';
            this.passTBx.Size = new System.Drawing.Size(121, 20);
            this.passTBx.TabIndex = 3;
            this.passTBx.UseSystemPasswordChar = true;
            // 
            // rememCBx
            // 
            this.rememCBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rememCBx.AutoSize = true;
            this.rememCBx.Location = new System.Drawing.Point(13, 209);
            this.rememCBx.Name = "rememCBx";
            this.rememCBx.Size = new System.Drawing.Size(94, 17);
            this.rememCBx.TabIndex = 4;
            this.rememCBx.Text = "Remember me";
            this.rememCBx.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.logoLbl);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 53);
            this.panel1.TabIndex = 5;
            // 
            // logoLbl
            // 
            this.logoLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoLbl.AutoSize = true;
            this.logoLbl.ForeColor = System.Drawing.Color.White;
            this.logoLbl.Location = new System.Drawing.Point(105, 22);
            this.logoLbl.Name = "logoLbl";
            this.logoLbl.Size = new System.Drawing.Size(70, 13);
            this.logoLbl.TabIndex = 0;
            this.logoLbl.Text = "LOGO HERE";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.Location = new System.Drawing.Point(186, 262);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.Location = new System.Drawing.Point(13, 261);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // creditLbl
            // 
            this.creditLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditLbl.AutoSize = true;
            this.creditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLbl.Location = new System.Drawing.Point(73, 296);
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(102, 9);
            this.creditLbl.TabIndex = 8;
            this.creditLbl.Text = "2106 In association with -----";
            // 
            // uNameLbl
            // 
            this.uNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uNameLbl.AutoSize = true;
            this.uNameLbl.Location = new System.Drawing.Point(13, 130);
            this.uNameLbl.Name = "uNameLbl";
            this.uNameLbl.Size = new System.Drawing.Size(55, 13);
            this.uNameLbl.TabIndex = 9;
            this.uNameLbl.Text = "Username";
            // 
            // emailTBx
            // 
            this.emailTBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTBx.Location = new System.Drawing.Point(69, 122);
            this.emailTBx.Name = "emailTBx";
            this.emailTBx.Size = new System.Drawing.Size(121, 20);
            this.emailTBx.TabIndex = 10;
            // 
            // forgotPwBtn
            // 
            this.forgotPwBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forgotPwBtn.BackColor = System.Drawing.Color.Transparent;
            this.forgotPwBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forgotPwBtn.Location = new System.Drawing.Point(12, 232);
            this.forgotPwBtn.Name = "forgotPwBtn";
            this.forgotPwBtn.Size = new System.Drawing.Size(105, 23);
            this.forgotPwBtn.TabIndex = 11;
            this.forgotPwBtn.Text = "Forgot Password?";
            this.forgotPwBtn.UseVisualStyleBackColor = false;
            this.forgotPwBtn.Click += new System.EventHandler(this.forgotPwBtn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(273, 314);
            this.Controls.Add(this.forgotPwBtn);
            this.Controls.Add(this.emailTBx);
            this.Controls.Add(this.uNameLbl);
            this.Controls.Add(this.creditLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rememCBx);
            this.Controls.Add(this.passTBx);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.logAsLbl);
            this.Controls.Add(this.logAsCBx);
            this.MinimumSize = new System.Drawing.Size(102, 38);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox logAsCBx;
        private System.Windows.Forms.Label logAsLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passTBx;
        private System.Windows.Forms.CheckBox rememCBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logoLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label creditLbl;
        private System.Windows.Forms.Label uNameLbl;
        private System.Windows.Forms.TextBox emailTBx;
        private System.Windows.Forms.Button forgotPwBtn;
    }
}

