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
using Connect;

namespace EventApp
{
    public partial class UserControlShowEventPreview : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();

        public UserControlShowEventPreview()
        {
            InitializeComponent();
            Connect1 c = new Connect1 ();
            connection.ConnectionString = con.ConnectString;
        }

        private void UserControlShowEventPreview_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Events where [Title] = @Title";
                command.Parameters.AddWithValue("@Title", EventShowPanelUserControl.title);
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    titleTxt.Text = reader["Title"].ToString();
                    descriptionTxt.Text = reader["Description"].ToString();
                    dateTxt.Text = reader["Day"].ToString();
                    timeTxt.Text = reader["Time"].ToString();
                    categoryTxt.Text = reader["Category"].ToString();
                    locationTxt.Text = reader["Location"].ToString();
                    // imagePictureBox.Image = LoadPhoto()
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
               
            }
        }

        private Image LoadPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void closeBack_Click(object sender, EventArgs e)
        {
            
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
