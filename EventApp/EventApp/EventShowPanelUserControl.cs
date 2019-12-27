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

        public int userid = 0;
        public static int eventid = 0;

        private void EventShowPanelUserControl_Click(object sender, EventArgs e)
        {

            title = Title;

            //Kanei anazitisi gia na parei to EventID kai to UserID wste na ta emfanizei sta Recomended

            try
            {
                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "select * from Events where [Title] = @Title";
                command1.Parameters.AddWithValue("@Title", title);
                command1.Connection = connection;

                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    eventid = (int)reader["EventsID"];
                }

                reader.Close();

                OleDbCommand command2 = new OleDbCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "select * from Users where [Username] = @Name";
                command2.Parameters.AddWithValue("@Name", Login.username);
                command2.Connection = connection;

                OleDbDataReader reader1 = command2.ExecuteReader();

                while (reader1.Read())
                {
                    userid = (int)reader1["UsersID"];
                }

                reader1.Close();

                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into DataUser ([UserID],[EventID]) values (@UserID, @EventID)";
                command.Parameters.AddWithValue("@UserID", userid);
                command.Parameters.AddWithValue("@EventID", eventid);
                command.Connection = connection;

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }

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
