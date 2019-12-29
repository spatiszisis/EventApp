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
    public partial class UserControlHelp : UserControl
    {
        public UserControlHelp()
        {
            InitializeComponent();
        }

        private void UserControlHelp_Load(object sender, EventArgs e)
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
                label4.Font = new Font("Arial", 16, FontStyle.Bold);
                label17.Font = new Font("Arial", 16, FontStyle.Bold);
                label6.Font = new Font("Arial", 16, FontStyle.Bold);
                label18.Font = new Font("Arial", 11, FontStyle.Bold);
                label19.Font = new Font("Arial", 11, FontStyle.Bold);
                label20.Font = new Font("Arial", 11, FontStyle.Bold);
                label21.Font = new Font("Arial", 11, FontStyle.Bold);
                label22.Font = new Font("Arial", 11, FontStyle.Bold);
                label23.Font = new Font("Arial", 11, FontStyle.Bold);
                label13.Font = new Font("Arial", 11, FontStyle.Regular);
                label12.Font = new Font("Arial", 11, FontStyle.Regular);
                label11.Font = new Font("Arial", 11, FontStyle.Regular);
                label10.Font = new Font("Arial", 11, FontStyle.Regular);
                label5.Font = new Font("Arial", 11, FontStyle.Regular);
                label7.Font = new Font("Arial", 11, FontStyle.Regular);
                label9.Font = new Font("Arial", 11, FontStyle.Regular);
                label14.Font = new Font("Arial", 11, FontStyle.Regular);
                label15.Font = new Font("Arial", 11, FontStyle.Regular);
                label16.Font = new Font("Arial", 11, FontStyle.Regular);
            }
            else if (g == 1)
            {
                label4.Font = new Font("Arial", 12, FontStyle.Bold);
                label6.Font = new Font("Arial", 12, FontStyle.Bold);
                label17.Font = new Font("Arial", 12, FontStyle.Bold);
                label18.Font = new Font("Arial", 9, FontStyle.Bold);
                label19.Font = new Font("Arial", 9, FontStyle.Bold);
                label20.Font = new Font("Arial", 9, FontStyle.Bold);
                label21.Font = new Font("Arial", 9, FontStyle.Bold);
                label22.Font = new Font("Arial", 9, FontStyle.Bold);
                label23.Font = new Font("Arial", 9, FontStyle.Bold);
                label13.Font = new Font("Arial", 9, FontStyle.Regular);
                label12.Font = new Font("Arial", 9, FontStyle.Regular);
                label11.Font = new Font("Arial", 9, FontStyle.Regular);
                label10.Font = new Font("Arial", 9, FontStyle.Regular);
                label5.Font = new Font("Arial", 9, FontStyle.Regular);
                label7.Font = new Font("Arial", 9, FontStyle.Regular);
                label9.Font = new Font("Arial", 9, FontStyle.Regular);
                label14.Font = new Font("Arial", 9, FontStyle.Regular);
                label15.Font = new Font("Arial", 9, FontStyle.Regular);
                label16.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }

    }
}
