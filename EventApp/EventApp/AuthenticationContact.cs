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

namespace EventApp
{
    public partial class AuthenticationContact : Form
    {
        public AuthenticationContact()
        {
            InitializeComponent();
        }

        private void AuthenticationContact_Load(object sender, EventArgs e)
        {
            txt_Username.Text = UserControlContact.Username;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(txt_Username.Text, "adopseteam@gmail.com", UserControlContact.Subject, UserControlContact.Body);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(txt_Username.Text,txt_Password.Text );
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);

                /*SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
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
                MessageBox.Show("Successfully Sent. ");*/

                if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlContact"))
                {
                    UserControlContact scse = new UserControlContact();
                    scse.Dock = DockStyle.Fill;
                    HomePage.Instance.PnlContainer.Controls.Add(scse);
                }
                HomePage.Instance.PnlContainer.Controls["UserControlContact"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }
    }
}
