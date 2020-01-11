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
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label2.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                label7.ForeColor = System.Drawing.Color.White;
                label8.ForeColor = System.Drawing.Color.White;
                label10.ForeColor = System.Drawing.Color.White;
                label11.ForeColor = System.Drawing.Color.White;
                label12.ForeColor = System.Drawing.Color.White;
                label13.ForeColor = System.Drawing.Color.White;
                label14.ForeColor = System.Drawing.Color.White;
                label16.ForeColor = System.Drawing.Color.White;
                label17.ForeColor = System.Drawing.Color.White;
                label18.ForeColor = System.Drawing.Color.White;
                label19.ForeColor = System.Drawing.Color.White;
                label20.ForeColor = System.Drawing.Color.White;
                label21.ForeColor = System.Drawing.Color.White;
                label22.ForeColor = System.Drawing.Color.White;
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
                label4.Font = new Font("Arial", 16, FontStyle.Bold);
                label17.Font = new Font("Arial", 16, FontStyle.Bold);
                label6.Font = new Font("Arial", 16, FontStyle.Bold);
                label18.Font = new Font("Arial", 11, FontStyle.Bold);
                label19.Font = new Font("Arial", 11, FontStyle.Bold);
                label20.Font = new Font("Arial", 11, FontStyle.Bold);
                label21.Font = new Font("Arial", 11, FontStyle.Bold);
                label22.Font = new Font("Arial", 11, FontStyle.Bold);
                label13.Font = new Font("Arial", 11, FontStyle.Regular);
                label12.Font = new Font("Arial", 11, FontStyle.Regular);
                label11.Font = new Font("Arial", 11, FontStyle.Regular);
                label10.Font = new Font("Arial", 11, FontStyle.Regular);
                label5.Font = new Font("Arial", 11, FontStyle.Regular);
                label7.Font = new Font("Arial", 11, FontStyle.Regular);
                label14.Font = new Font("Arial", 11, FontStyle.Regular);
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
                label13.Font = new Font("Arial", 9, FontStyle.Regular);
                label12.Font = new Font("Arial", 9, FontStyle.Regular);
                label11.Font = new Font("Arial", 9, FontStyle.Regular);
                label10.Font = new Font("Arial", 9, FontStyle.Regular);
                label5.Font = new Font("Arial", 9, FontStyle.Regular);
                label7.Font = new Font("Arial", 9, FontStyle.Regular);
                label14.Font = new Font("Arial", 9, FontStyle.Regular);
                label16.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }

    }
}
