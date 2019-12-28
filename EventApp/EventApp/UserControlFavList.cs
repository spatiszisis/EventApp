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
            // gia to dark mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = Color.Black;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }
        }
    }
}
