using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace EventApp
{
    public partial class UserControlContact : UserControl
    {
        public UserControlContact()
        {
            InitializeComponent();
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailTxt.Clear();
        }

        private void subjectTxt_Click(object sender, EventArgs e)
        {
            subjectTxt.Clear();
        }

        private void messageTxt_Click(object sender, EventArgs e)
        {
            messageTxt.Clear();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("adopseteam@gmail.com", "Asd123456.");
                MailMessage msg = new MailMessage();
                msg.To.Add(emailTxt.Text);
                msg.From = new MailAddress("adopseteam@gmail.com"); 
                msg.Subject = subjectTxt.Text;
                msg.Body = messageTxt.Text;
                client.Send(msg);
                MessageBox.Show("Successfully Sent. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                emailTxt.Text = "example@gmail.com";
                subjectTxt.Text = "Give an subject";
                messageTxt.Text = "Leave your message...";
            }
        }

        private void UserControlContact_Load(object sender, EventArgs e)
        {
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = Color.Black;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }
            //Grammatoseira
            int g = (int)UserControlSettingsApp.gram;
            if (g == 0)
            {
                label5.Font = new Font("Arial", 16, FontStyle.Bold);
                label6.Font = new Font("Arial", 16, FontStyle.Bold);
                label7.Font = new Font("Arial", 16, FontStyle.Bold);
            }
            else if (g == 1)
            {
                label5.Font = new Font("Arial", 14, FontStyle.Bold);
                label6.Font = new Font("Arial", 14, FontStyle.Bold);
                label7.Font = new Font("Arial", 14, FontStyle.Bold);
            }
        }
    }
}
