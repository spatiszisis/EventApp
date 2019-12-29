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
        /*Bgazei exception sto picture box den trexei me ayton ton tropo to dark mode
        public UserControlAboutUs us1 = new UserControlAboutUs();
        public UserControlContact us2 = new UserControlContact();
        public UserControlCreateEvent us3 = new UserControlCreateEvent();
        public UserControlFavList us4 = new UserControlFavList();
        public UserControlHelp us5 = new UserControlHelp();
        public UserControlSettingsApp us6 = new UserControlSettingsApp();
        public UserControlSettingsUser us7 = new UserControlSettingsUser();
        public UserControlShowEventPreview us8 = new UserControlShowEventPreview();
        public UserControlShowEvents us9 = new UserControlShowEvents();
        public UserControlΗοme us10 = new UserControlΗοme();
        */
        public static int color = 1; // Gia to xrwma
        public static int gram = 1; // Gia tin grammatoseira
        public UserControlSettingsApp()
        {
            InitializeComponent();   
        }

        private void onvalue_CheckedChanged(object sender, EventArgs e)
        {
            if(onvalue.Checked == true)
            {
                /*Bgazei exception sto picture box den trexei me ayton ton tropo to dark mode
                us1.BackColor = Color.FromArgb(0, 0, 0); 
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
                color = 0;
                this.BackColor = Color.Black;
            }
            else
            {
                color = 1;
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
                gram = 0;
                label2.Font = new Font("Arial", 14, FontStyle.Bold);
                label3.Font = new Font("Arial", 14, FontStyle.Bold);
                
            }
            else
            {
                // Meiwsei tis grammatoseiras
                gram = 1;
                label2.Font = new Font("Arial", 12, FontStyle.Bold);
                label3.Font = new Font("Arial", 12, FontStyle.Bold);
            }

        }

    }
}
