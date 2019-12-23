using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using Connect;

namespace EventApp
{
    public partial class UserControlΗοme : System.Windows.Forms.UserControl
    {
        Connect1 con = new Connect1();
        public UserControlΗοme()
        {
            InitializeComponent();
        }
        public static string SetValueDay = "";
        public static string SetValueLocation = "";
        public static string SetValueCategory = "";
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //SetValueDay = dateTimePicker1.Text;
            SetValueLocation = locationCombo.Text;
            SetValueCategory = categoryCombo.Text;
            UserControlShowEvents us = new UserControlShowEvents();
            us.Show();

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEvents"))
            {
                UserControlShowEvents scse = new UserControlShowEvents();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEvents"].BringToFront();
        }
    }
}
