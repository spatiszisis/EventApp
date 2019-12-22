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
    public partial class EventShowPanelUserControl : UserControl
    {
        public EventShowPanelUserControl()
        {
            InitializeComponent();
        }

        private string _title;
        private string _location;
        private string _day;
        private string _time;
        private Image _icon;

        public string Title
        {
            get { return _title; }
            set { _title = value; titleTxt.Text = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; locationTxt.Text = value; }
        }

        public string Day
        {
            get { return _day; }
            set { _day = value; dayTxt.Text = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; timeTxt.Text = value; }
        }

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picImage.Image = value; }
        }

        private void EventShowPanelUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void EventShowPanelUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
