using EventApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Documents;

namespace EventApp
{
    public partial class HomePage : Form

    {

        static HomePage _obj;


        public static HomePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new HomePage();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        private OleDbConnection connection = new OleDbConnection();
        Timer t = new Timer(); // Dilwsh tou timer
        Connect con = new Connect();

        public HomePage()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
            NameLabel.Text = Login.username;
            managerBtn.Visible = false;
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            _obj = this;

            UserControlΗοme uc = new UserControlΗοme();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);

            if (Login.isAdmin == true)
            {
                managerBtn.Visible = true;
            }

            //Elegxos gia to ama iparxei Location i oxi kai analoga tha trexei
            if (Login.Location == "")
            {
                //nothing
            }
            else
            {
                // Gia to notification Form
                t.Interval = 500; // meta apo 2 sec na anoigei h forma gia ta notification
                t.Tick += new EventHandler(OnTimerTicked);
                t.Start();
            }

        }

        //Notification 
        public void OnTimerTicked(object sender, EventArgs e)
        {
            t.Stop();
            AlertForm formdois = new AlertForm();
            formdois.Show();
        }

        //Start Properties button

        private void Home_MouseHover(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(85, 61, 69);  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Home.ForeColor = Color.Black;
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(87, 96, 122);  //epanafora tou xrwmatos otan fygei to pontiki
            Home.ForeColor = Color.Snow;
        }

        private void Create_Event_MouseHover_1(object sender, EventArgs e)
        {
            Create_Event.BackColor = Color.FromArgb(85, 61, 69);  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Create_Event.ForeColor = Color.Black;
        }
        private void Create_Event_MouseLeave(object sender, EventArgs e)
        {
            Create_Event.BackColor = Color.FromArgb(87, 96, 122);  //epanafora tou xrwmatos otan fygei to pontiki
            Create_Event.ForeColor = Color.Snow;
        }

        private void Help_MouseHover(object sender, EventArgs e)
        {
            Help.BackColor = Color.FromArgb(85, 61, 69);  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Help.ForeColor = Color.Black;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackColor = Color.FromArgb(87, 96, 122);  //epanafora tou xrwmatos otan fygei to pontiki
            Help.ForeColor = Color.Snow;
        }

        private void About_Us_MouseHover(object sender, EventArgs e)
        {
            About_Us.BackColor = Color.FromArgb(85, 61, 69);
            About_Us.ForeColor = Color.Black;
        }

        private void About_Us_MouseLeave(object sender, EventArgs e)
        {
            About_Us.BackColor = Color.FromArgb(87, 96, 122);
            About_Us.ForeColor = Color.Snow;
        }

        private void Contact_MouseHover(object sender, EventArgs e)
        {
            Contact.BackColor = Color.FromArgb(85, 61, 69);
            Contact.ForeColor = Color.Black;
        }

        private void Contact_MouseLeave(object sender, EventArgs e)
        {
            Contact.BackColor = Color.FromArgb(87, 96, 122);
            Contact.ForeColor = Color.Snow;
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(85, 61, 69);
            exitBtn.ForeColor = Color.Black;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(87, 96, 122);
            exitBtn.ForeColor = Color.Snow;
        }

        private void settingsBtn_MouseHover(object sender, EventArgs e)
        {
            settingsBtn.BackColor = Color.FromArgb(85, 61, 69);
            settingsBtn.ForeColor = Color.Black;
        }

        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            settingsBtn.BackColor = Color.FromArgb(87, 96, 122);
            settingsBtn.ForeColor = Color.Snow;
        }

        private void managerBtn_MouseHover(object sender, EventArgs e)
        {
            managerBtn.BackColor = Color.FromArgb(85, 61, 69);
            managerBtn.ForeColor = Color.Black;
        }

        private void managerBtn_MouseLeave(object sender, EventArgs e)
        {
            managerBtn.BackColor = Color.FromArgb(87, 96, 122);
            managerBtn.ForeColor = Color.Snow;
        }

        //Telos Properties button

        //Arxi Click Method gia na allazei panel
        private void Home_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear(); ////////
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            UserControlΗοme uc = new UserControlΗοme();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Create_Event_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            SidePanel.Height = Create_Event.Height;
            SidePanel.Top = Create_Event.Top;
            UserControlCreateEvent uc = new UserControlCreateEvent();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            SidePanel.Height = Help.Height;
            SidePanel.Top = Help.Top;
            UserControlHelp uc = new UserControlHelp();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void About_Us_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            SidePanel.Height = About_Us.Height;
            SidePanel.Top = About_Us.Top;
            UserControlAboutUs uc = new UserControlAboutUs();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            SidePanel.Height = Contact.Height;
            SidePanel.Top = Contact.Top;
            UserControlContact uc = new UserControlContact();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void usersettingsBtn_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            UserControlSettingsUser uc = new UserControlSettingsUser();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            UserControlSettingsApp uc = new UserControlSettingsApp();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void favlistBtn_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            UserControlFavList uc = new UserControlFavList();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }
        private void managerBtn_Click(object sender, EventArgs e)
        {
            PnlContainer.Controls.Clear();
            SidePanel.Height = managerBtn.Height;
            SidePanel.Top = managerBtn.Top;
            UserControlManage uc = new UserControlManage();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            AlertForm uc = new AlertForm();
            uc.Show();
        }

        //Telos Click Method gia na allazei panel

        //Arxi Exit, Log Out    

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login.username = "";
            Login.password = "";
            Login.Location = "";
            Login lgform = new Login();
            lgform.Show();
        }

        //Telos Exit, Log Out  

        //Arxi Alla Properties 

        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Clear();
        }

        Image icon;

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //search box
        private void searchBtn_Click(object sender, EventArgs e)
        {
            UserControlShowEvents uc = new UserControlShowEvents();
            
            if (searchTxt.Text == "Thessaloniki" || searchTxt.Text == "Athens" || searchTxt.Text == "Patra" || searchTxt.Text == "Larissa" || searchTxt.Text == "Kavala" || searchTxt.Text == "Giannena" || searchTxt.Text == "Volos" || searchTxt.Text == "Alexandroupoli" || searchTxt.Text == "Herakleion")
            {
                uc.locationsearch(searchTxt.Text);
                uc.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(uc);
                uc.BringToFront();
            }
            if(searchTxt.Text == "Concerts" || searchTxt.Text == "Comedy" || searchTxt.Text == "Education" || searchTxt.Text == "Festival" || searchTxt.Text == "Food" || searchTxt.Text == "Galleries" || searchTxt.Text == "Health" || searchTxt.Text == "Holiday" || searchTxt.Text == "Movies" || searchTxt.Text == "Museums" || searchTxt.Text == "Networking" || searchTxt.Text == "Technology" || searchTxt.Text == "Politics")
            {
                uc.categorysearch(searchTxt.Text);
                uc.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(uc);
                uc.BringToFront();
            }
            

        }

        //Telos Alla Properties 
    }
}
