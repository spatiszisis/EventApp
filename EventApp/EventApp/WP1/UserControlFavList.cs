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
using System.IO;

namespace EventApp
{
    public partial class UserControlFavList : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        Image icon;
        public int userid = 0;
        public int Eventid = 0;
        public UserControlFavList()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void UserControlFavList_Load(object sender, EventArgs e)
        {
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label1.ForeColor = System.Drawing.Color.White;
                panel1.BackColor = System.Drawing.Color.White;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }

            //i agapimeni lista tou

            try
            {
                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string query1 = "select distinct [EventID] from FavList where [UserID] = @Userid";
                command1.Parameters.AddWithValue("@Userid", Login.UserID);
                command1.CommandText = query1;
                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    Eventid = (Int16)reader["EventID"];

                    EventShowPanelUserControl listitems = new EventShowPanelUserControl();

                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;
                    string query2 = "select * from Events where [EventsID] = @Eventid";
                    command2.Parameters.AddWithValue("@Eventid", Eventid);
                    command2.CommandText = query2;
                    OleDbDataReader reader2 = command2.ExecuteReader();

                    while (reader2.Read())
                    {

                        listitems.Title         = reader2["Title"].ToString();
                        listitems.Location      = reader2["Location"].ToString();
                        listitems.Day           = (DateTime)reader2["Day"];
                        listitems.Time          = reader2["Time"].ToString();
                        icon                    = byteArrayToImage((byte[])reader2["images"]);
                        listitems.Icon          = icon;
                        listitems.BorderStyle   = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanelFav.Controls.Count < 0)
                        {
                            flowLayoutPanelFav.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanelFav.Controls.Add(listitems);
                        }

                    }
                    reader2.Close();
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
                connection.Close();
            }

            //Ta events pou tha paei

            try
            {
                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string query1 = "select distinct [EvenTID] from AttendList where [UserID] = @Userid";
                command1.Parameters.AddWithValue("@Userid", Login.UserID);
                command1.CommandText = query1;
                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    Eventid = (int)reader["EvenTID"];

                    EventShowPanelUserControl listitems = new EventShowPanelUserControl();

                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;
                    string query2 = "select * from Events where [EventsID] = @Eventid";
                    command2.Parameters.AddWithValue("@Eventid", Eventid);
                    command2.CommandText = query2;
                    OleDbDataReader reader2 = command2.ExecuteReader();

                    while (reader2.Read())
                    {

                        listitems.Title             = reader2["Title"].ToString();
                        listitems.Location          = reader2["Location"].ToString();
                        listitems.Day               = (DateTime)reader2["Day"];
                        listitems.Time              = reader2["Time"].ToString();
                        icon                        = byteArrayToImage((byte[])reader2["images"]);
                        listitems.Icon              = icon;
                        listitems.BorderStyle       = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanelGoEvents.Controls.Count < 0)
                        {
                            flowLayoutPanelGoEvents.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanelGoEvents.Controls.Add(listitems);
                        }

                    }
                    reader2.Close();
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
                connection.Close();

            }
        }
    }
}
