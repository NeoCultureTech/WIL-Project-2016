using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
namespace Email
{
    public partial class FrmForgotPass : Form
    {
        public FrmForgotPass()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String Email = TxtEmail.Text;
            String Password = TxtPass.Text;

            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//domain Path
                client.EnableSsl = true;
                client.Timeout = 1000000;

                client.DeliveryMethod = SmtpDeliveryMethod.Network;//Netword being used
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Email, Password);//Email Recipient

                MailMessage msg = new MailMessage();//Creating the message to send
                msg.To.Add(Email);
                msg.From = new MailAddress("kohlfaul@gmail.com");
                msg.Subject = "Testing 1 2...";
                msg.Body = "New password  = 00000";
                client.Send(msg);

                this.Hide();
                MessageBox.Show("Email send with your new pasword details");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void hidePass()
        {
            if (chkShowPassword.Checked)
            {
                TxtPass.PasswordChar = '\0';
            }
            else
            {
                TxtPass.PasswordChar = '*';
            }
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            hidePass();
        }
        public void clearText()//method for clearing text in text feild
        {
            TxtEmail.Text = "";
            TxtPass.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }
    }
}
