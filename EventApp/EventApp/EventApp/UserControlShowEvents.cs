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
    public partial class UserControlShowEvents : UserControl
    {
        public string date, city, category;

        public UserControlShowEvents()
        {
            InitializeComponent();
        }

        private void UserControlShowEvents_Load(object sender, EventArgs e)
        {
            dayTxt.Text = date;
            cityTxt.Text = city;
            moodTxt.Text = category;
        }
    }
}
