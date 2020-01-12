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

        public UserControlSettingsApp()
        {
            InitializeComponent();
        }

        private void onvalue_CheckedChanged(object sender, EventArgs e)
        {
            if(onvalue.Checked == true)
            {
                UserControlAboutUs us1 = new UserControlAboutUs();
                

                us1.BackColor = Color.FromArgb(34, 36, 49);
                
                
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
                
            }
        }
    }
}
