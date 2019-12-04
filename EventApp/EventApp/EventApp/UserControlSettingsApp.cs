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
        public UserControlSettingsApp()
        {
            InitializeComponent();
        }

        private void onvalue_CheckedChanged(object sender, EventArgs e)
        {
            if(onvalue.Checked == true)
            {
                UserControlAboutUs us1 = new UserControlAboutUs();
                UserControlContact us2 = new UserControlContact();
                UserControlCreateEvent us3 = new UserControlCreateEvent();
                UserControlFavList us4 = new UserControlFavList();
                UserControlHelp us5 = new UserControlHelp();
                UserControlSettingsApp us6 = new UserControlSettingsApp();
                UserControlSettingsUser us7 = new UserControlSettingsUser();
                UserControlShowEventPreview us8 = new UserControlShowEventPreview();
                UserControlShowEvents us9 = new UserControlShowEvents();

                us1.BackColor = Color.FromArgb(34, 36, 49);
                us2.BackColor = Color.FromArgb(34, 36, 49);
                us3.BackColor = Color.FromArgb(34, 36, 49);
                us4.BackColor = Color.FromArgb(34, 36, 49);
                us5.BackColor = Color.FromArgb(34, 36, 49);
                us6.BackColor = Color.FromArgb(34, 36, 49);
                us7.BackColor = Color.FromArgb(34, 36, 49);
                us8.BackColor = Color.FromArgb(34, 36, 49);
                us9.BackColor = Color.FromArgb(34, 36, 49);
                
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
