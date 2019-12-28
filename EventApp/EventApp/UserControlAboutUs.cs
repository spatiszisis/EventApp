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
    public partial class UserControlAboutUs : UserControl
    {
        //  UserControlSettingsApp us = new UserControlSettingsApp();
      
        public UserControlAboutUs()
        {
            InitializeComponent();
        }

        private void UserControlAboutUs_Load(object sender, EventArgs e)
        {
            this.BackColor = UserControlSettingsApp.DefaultBackColor; // gia to dark mode
        }
       
    }
}
