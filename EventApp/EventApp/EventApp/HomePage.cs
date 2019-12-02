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
using Connect;

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

        Connect1 con = new Connect1();
        public HomePage()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;

            String Username = "";
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT [Username] FROM [LoggedInUser]";
            command.Connection = connection;
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { Username = (String)reader["Username"]; }
            connection.Close();
            connection.Dispose();
            NameLabel.Text = Username;
        }

        
        private void HomePage_Load(object sender, EventArgs e)
        {
            _obj = this;

            UserControlΗοme uc = new UserControlΗοme();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
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



        //Telos Properties button

        //Arxi Click Method gia na allazei panel
        private void Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            UserControlΗοme uc = new UserControlΗοme();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Create_Event_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Create_Event.Height;
            SidePanel.Top = Create_Event.Top;
            UserControlCreateEvent uc = new UserControlCreateEvent();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Help.Height;
            SidePanel.Top = Help.Top;
            UserControlHelp uc = new UserControlHelp();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void About_Us_Click(object sender, EventArgs e)
        {
            SidePanel.Height = About_Us.Height;
            SidePanel.Top = About_Us.Top;
            UserControlAboutUs uc = new UserControlAboutUs();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Contact.Height;
            SidePanel.Top = Contact.Top;
            UserControlContact uc = new UserControlContact();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void usersettingsBtn_Click(object sender, EventArgs e)
        {
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
            UserControlFavList uc = new UserControlFavList();
            uc.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        //Telos Click Method gia na allazei panel

        //Arxi Exit, Log Out    

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kleinei tin Efarmogh
            connection.ConnectionString = con.ConnectString;
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DROP TABLE LoggedInUser; ";
            try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
            }
            catch (System.Data.OleDb.OleDbException)
            { 
                connection.Close();
                connection.Dispose();
                Application.Exit();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        { 
            connection.ConnectionString = con.ConnectString;
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DROP TABLE LoggedInUser; ";

            try 
            { 
                 command.Connection = connection;
                 connection.Open();
                 command.ExecuteNonQuery();
                 connection.Close();
                 connection.Dispose();
                 this.Hide();
                 Login lgform = new Login();
                 lgform.Show();


            }
            catch (System.Data.OleDb.OleDbException)
            {
                 connection.Close();
                 connection.Dispose();
                 this.Hide();
                 Login lgform = new Login();
                 lgform.Show();
            }
            
           
           
           
        }

        //Telos Exit, Log Out  

        //Arxi Alla Properties 

        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Clear();
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = con.ConnectString;
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Events";
            command.Connection = connection;
            connection.Open();

            if(searchTxt.Text != null)
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                { 
                    //to afisa....auto einai gia to search
                }
            }
            connection.Close();
        }


        //Telos Alla Properties 
    }
}
