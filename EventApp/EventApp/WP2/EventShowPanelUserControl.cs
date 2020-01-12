﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EventApp
{
    public partial class EventShowPanelUserControl : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        public EventShowPanelUserControl()
        {
            InitializeComponent();
        }

        private string _title;
        private string _location;
        private DateTime _day;
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
        //public DateTime idate; 
        public DateTime Day
        {
            get { return _day; }
            set { _day = value; dateTimePicker1.Value = value; }
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

        //Kanei anazitisi gia na parei to EventID kai to UserID wste na ta emfanizei sta Recomended
        private void EventShowPanelUserControl_Click(object sender, EventArgs e)
        {
            title = Title;

            try
            {
                connection.ConnectionString = con.ConnectString;
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

                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into DataUser ([UserID],[EventID]) values (@UserID, @EventID)";
                command.Parameters.AddWithValue("@UserID", Login.UserID);
                command.Parameters.AddWithValue("@EventID", eventid);
                command.Connection = connection;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEventPreview"))
            {
                UserControlShowEventPreview scse = new UserControlShowEventPreview();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEventPreview"].BringToFront();
        }
        //Telos

    }
}
