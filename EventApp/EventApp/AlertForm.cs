using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class AlertForm : Form
    {
        public static int but = 0;
        public AlertForm()
        {
            InitializeComponent();
            // this.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gia na kleinei to notification form
            but = 1;
            AlertForm a = new AlertForm();
            this.Close();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            // Gia to dark mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }
              Timer myTimer = new Timer();
              myTimer.Interval = (10 * 1000); // 10 sec
              myTimer.Tick += new EventHandler(MyTimer_Tick);
              myTimer.Start();
          }
             private void MyTimer_Tick(object sender, EventArgs e)
             {
                 this.Close();
             }
        }
    }

