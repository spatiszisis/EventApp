using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class UserControlSettingsApp : UserControl
    {
        private FormBorderStyle FormBorderStyle;

        private UserControlAboutUs us1;
        //arxi
       
        //
        
        public UserControlSettingsApp()
        {
            InitializeComponent();
          
        }

        private void onvalue_CheckedChanged(object sender, EventArgs e)
        {
            if(onvalue.Checked == true)
            {
               /* UserControlAboutUs us1 = new UserControlAboutUs();
                //
                UserControlContact us2 = new UserControlContact();
                UserControlCreateEvent us3 = new UserControlCreateEvent();
                UserControlFavList us4 = new UserControlFavList();
                UserControlHelp us5 = new UserControlHelp();
                UserControlSettingsApp us6 = new UserControlSettingsApp();
                UserControlSettingsUser us7 = new UserControlSettingsUser();
                UserControlShowEventPreview us8 = new UserControlShowEventPreview();
                UserControlShowEvents us9 = new UserControlShowEvents();
                UserControlΗοme us10 = new UserControlΗοme();*/


                /*
                us1.BackColor = Color.FromArgb(34, 36, 49);
                //
                us2.BackColor = Color.FromArgb(0, 0, 0);
                us3.BackColor = Color.FromArgb(0, 0, 0);
                us4.BackColor = Color.FromArgb(0, 0, 0);
                us5.BackColor = Color.FromArgb(0, 0, 0);
                us6.BackColor = Color.FromArgb(0, 0, 0);
                us7.BackColor = Color.FromArgb(0, 0, 0);
                us8.BackColor = Color.FromArgb(0, 0, 0);
                us9.BackColor = Color.FromArgb(0, 0, 0);
                us10.BackColor = Color.FromArgb(0, 0, 0);
        
            */

            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void checkboxchangeborderstyleform_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxchangeborderstyleform.Checked == true)
            {
                //HomePage hp = new HomePage();
                FormBorderStyle = FormBorderStyle.Sizable;
                // Auksisi tis grammatoseiras
                label2.Font = new Font("Arial", 14, FontStyle.Bold);
                label3.Font = new Font("Arial", 14, FontStyle.Bold);
                // UserControlContact
                /* label1
                 label2.Text
                 label3
                 label4
                 label5
                 label6
                 label7
                 label8
                 label9
                 label10*/
                //UserControlAboutUs us1 = new UserControlAboutUs();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onvalue.Checked == true)
            {
               /* UserControlAboutUs us1 = new UserControlAboutUs();
                //
                UserControlContact us2 = new UserControlContact();
                UserControlCreateEvent us3 = new UserControlCreateEvent();
                UserControlFavList us4 = new UserControlFavList();
                UserControlHelp us5 = new UserControlHelp();
                UserControlSettingsApp us6 = new UserControlSettingsApp();
                UserControlSettingsUser us7 = new UserControlSettingsUser();
                UserControlShowEventPreview us8 = new UserControlShowEventPreview();
                UserControlShowEvents us9 = new UserControlShowEvents();
                UserControlΗοme us10 = new UserControlΗοme();

                */

               // us1.BackColor = Color.FromArgb(12, 12, 12);
                /*/  
                us2.BackColor = Color.FromArgb(0, 0, 0);
                us3.BackColor = Color.FromArgb(0, 0, 0);
                us4.BackColor = Color.FromArgb(0, 0, 0);
                us5.BackColor = Color.FromArgb(0, 0, 0);
                us6.BackColor = Color.FromArgb(0, 0, 0);
                us7.BackColor = Color.FromArgb(0, 0, 0);
                us8.BackColor = Color.FromArgb(0, 0, 0);
                us9.BackColor = Color.FromArgb(0, 0, 0);
                us10.BackColor = Color.Black;

              
                us10.BringToFront(); // otan patame apply meta epistrefei sto home */
            }

            if (checkboxchangeborderstyleform.Checked == true)
            {
                label2.Font = new Font("Arial", 14, FontStyle.Bold);
                label3.Font = new Font("Arial", 14, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
                label1.Font = new Font("Arial", 24, FontStyle.Bold);
             //   us1.Font = new Font("Arial", 14, FontStyle.Bold);
            }


        }
    }
}
