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
            SetValueDay = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            SetValueLocation = locationCombo.Text;
            SetValueCategory = categoryCombo.Text;
            

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEvents"))
            {
                UserControlShowEvents scse = new UserControlShowEvents();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEvents"].BringToFront();


            var client = new RestClient("https://community-eventful.p.rapidapi.com/events/search?q=music&app_key=6t36739SKFQD49hW");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-eventful.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "c8810b1a79msh4ae5777760c25a0p12c7a6jsnc6efe4bf0b60");
            IRestResponse response = client.Execute(request);
        }
    }
}
