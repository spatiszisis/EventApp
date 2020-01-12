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
using RestSharp;

namespace EventApp
{
    public partial class UserControlΗοme : System.Windows.Forms.UserControl
    {
        Connect con = new Connect();
        public UserControlΗοme()
        {
            InitializeComponent();
            
        }
        public static string SetValueDay = "";
        public static string SetValueLocation = "";
        public static string SetValueCategory = "";

        //Pairnei tis times wste na tis xrisimopioisei sto EventShow
        private void searchBtn_Click(object sender, EventArgs e)
        {
            SetValueDay      = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            SetValueLocation = locationCombo.Text;
            SetValueCategory = categoryCombo.Text;
            

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEvents"))
            {
                UserControlShowEvents scse = new UserControlShowEvents();
                scse.button_main_search();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEvents"].BringToFront();
            
        }
        //Telos

        private void UserControlΗοme_Load(object sender, EventArgs e)
        {
            locationCombo.SelectedText = "Any City";
            categoryCombo.SelectedText = "Anything";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
