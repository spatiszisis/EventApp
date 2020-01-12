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

        public static string Username = "";
        public static string Subject = "";
        public static string Body = "";

        //Pairnei tis plirofories pou vazoume wste na tis emfanisei sto Authendication
        private void sendBtn_Click(object sender, EventArgs e)
        {
            Username = emailTxt.Text;
            Subject = subjectTxt.Text;
            Body = messageTxt.Text;

            AuthenticationContact au = new AuthenticationContact();
            au.Show();
        }

        private void UserControlContact_Load(object sender, EventArgs e)
        {
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label1.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                label7.ForeColor = System.Drawing.Color.White;
                panel1.BackColor = System.Drawing.Color.White;
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
