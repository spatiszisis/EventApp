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
    public partial class UserControlFavList : UserControl
    {
        public UserControlFavList()
        {
            InitializeComponent();
        }

        private void UserControlFavList_Load(object sender, EventArgs e)
        {
            this.BackColor = UserControlSettingsApp.DefaultBackColor; // gia to dark mode
        }
    }
}
