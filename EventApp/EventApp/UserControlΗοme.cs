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
using RestSharp;

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
            SetValueDay      = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            SetValueLocation = locationCombo.Text;
            SetValueCategory = categoryCombo.Text;
            

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEvents"))
            {
                UserControlShowEvents scse = new UserControlShowEvents();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEvents"].BringToFront();
            
        }

        private void UserControlΗοme_Load(object sender, EventArgs e)
        {
            locationCombo.SelectedText = "Any City";
            categoryCombo.SelectedText = "Anything";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
