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
        public AlertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gia na kleinei to notification form
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
            /* 
             * Edo otan anoigei h forma kleinei meta apo 10 sec.
             * To provlima einai oti kai apo to koumpi ton eidopoihsewn
             * na anoikseis tin forma meta apo 10 sec tha kleisei.
             * Na kleinei mono thn proti fora pou anoigei h forma ginetai apo
             * to HomePage_Load alla den douleuei
             */// Arxi
            Timer myTimer = new Timer();
            myTimer.Interval = (10 * 1000); // 10 sec
            myTimer.Tick += new EventHandler(MyTimer_Tick);
            myTimer.Start();
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        // Telos  
    }
}

