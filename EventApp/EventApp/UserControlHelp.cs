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
            this.BackColor = UserControlSettingsApp.DefaultBackColor; // gia to dark mode
            // Gia tin auksomoiosh thw grammatoseiras
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
