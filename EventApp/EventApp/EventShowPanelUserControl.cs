using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect;
using System.Data.OleDb;

namespace EventApp
{
    public partial class EventShowPanelUserControl : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        public EventShowPanelUserControl()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        private string _title;
        private string _location;
        private string _day;
        private string _time;
        private Image _icon;
        public static string title = "";
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

        private void EventShowPanelUserControl_Click(object sender, EventArgs e)
        {

            title = Title;

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEventPreview"))
            {
                UserControlShowEventPreview scse = new UserControlShowEventPreview();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEventPreview"].BringToFront();
        }

    }
}
