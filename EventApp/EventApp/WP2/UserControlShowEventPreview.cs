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
using System.Windows.Media.Imaging;
using EventApp.Properties;

namespace EventApp
{
    public partial class UserControlShowEventPreview : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        Image icon;
        public int UserId = 0;
        public int EventId = 0;

        public UserControlShowEventPreview()
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

        public static int numRating = 0; //gia na metraei ta asteria
        public Boolean favlist; //boolean gia to favlist
        public Boolean ratingBol; //boolean gia to rating
        private void UserControlShowEventPreview_Load(object sender, EventArgs e)
        {
            //Wrap text
            descriptionTxt.MaximumSize = new Size(550, 0);
            descriptionTxt.AutoSize = true;

            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                titleTxt.ForeColor = System.Drawing.Color.White;
                descriptionTxt.ForeColor = System.Drawing.Color.White;
                timeTxt.ForeColor = System.Drawing.Color.White;
                locationTxt.ForeColor = System.Drawing.Color.White;
                categoryTxt.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label1.ForeColor = System.Drawing.Color.White;
                usernumber_label.ForeColor = System.Drawing.Color.White;
                panel1.BackColor = System.Drawing.Color.White;
                panel2.BackColor = System.Drawing.Color.White;
                panel3.BackColor = System.Drawing.Color.White;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }

            //Diavazei to event kai to emfanizei
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
                    dateTimePicker1.Value = (DateTime)reader["Day"];
                    timeTxt.Text = reader["Time"].ToString();
                    categoryTxt.Text = reader["Category"].ToString();
                    locationTxt.Text = reader["Location"].ToString();
                    icon = byteArrayToImage((byte[])reader["Images"]);
                    imagePictureBox.Image = icon;
                    EventId = (int)reader["EventsID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
            finally
            {
                connection.Close();

            }
            //Telos

            //Emfanisei osa asteria exei dwsei apo proigoumeno insert
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string query1 = "select * from Rating where [EventID] = @Eventid";
                command1.Parameters.AddWithValue("@Eventid", EventId);
                command1.CommandText = query1;

                OleDbDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    ratingBol = true;
                    numRating = (int)reader1["Rating"];
                    if (numRating == 1)
                    {
                        this.star1Btn.Image = new Bitmap(Resources.star);
                    }
                    else if (numRating == 2)
                    {
                        this.star1Btn.Image = new Bitmap(Resources.star);
                        this.star2Btn.Image = new Bitmap(Resources.star);
                    }
                    else if (numRating == 3)
                    {
                        this.star1Btn.Image = new Bitmap(Resources.star);
                        this.star2Btn.Image = new Bitmap(Resources.star);
                        this.star3Btn.Image = new Bitmap(Resources.star);
                    }
                    else if (numRating == 4)
                    {
                        this.star1Btn.Image = new Bitmap(Resources.star);
                        this.star2Btn.Image = new Bitmap(Resources.star);
                        this.star3Btn.Image = new Bitmap(Resources.star);
                        this.star4Btn.Image = new Bitmap(Resources.star);
                    }
                    else if (numRating == 5)
                    {
                        this.star1Btn.Image = new Bitmap(Resources.star);
                        this.star2Btn.Image = new Bitmap(Resources.star);
                        this.star3Btn.Image = new Bitmap(Resources.star);
                        this.star4Btn.Image = new Bitmap(Resources.star);
                        this.star5Btn.Image = new Bitmap(Resources.star);
                    }
                }

                reader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
            finally
            {
                connection.Close();

            }
            //Telos


            //Emfanisis tha paw/den tha paw koumpi analoga me to ti eixe dhlwsei prin o xrhsths
            try
            {

                connection.Open();
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string query2 = "select * from AttendList where [UserID] = @user and [EvenTID] = @eventid";
                command2.Parameters.AddWithValue("@user", Login.UserID);
                command2.Parameters.AddWithValue("@eventid", EventId);
                command2.CommandText = query2;
                int count = 0;
                OleDbDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    goBtn.Visible = true;
                    dontgo_btn.Visible = false;
                }
                else
                {
                    goBtn.Visible = false;
                    dontgo_btn.Visible = true;
                }
                reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();

            }
            //Telos

            //Emfanisei posoi tha pane sto antistoixo event
            try
            {
                connection.Open();
                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = connection;
                string query3 = "select * from AttendList where [EvenTID] = @eventid";
                command3.Parameters.AddWithValue("@eventid", EventId);
                command3.CommandText = query3;
                OleDbDataReader reader3 = command3.ExecuteReader();
                int count = 0;

                while (reader3.Read())
                {
                    count++;
                }
                usernumber_label.Text = count.ToString();
                reader3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
            //Telos

            //Na tsekarei ean iparxei sigkekrimeno event sti FavList
            try
            {

                connection.Open();
                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = connection;
                string query3 = "select * from FavList where [UserID] = @Userid and [EventID] = @eventid";
                command3.Parameters.AddWithValue("@Userid", Login.UserID);
                command3.Parameters.AddWithValue("@eventid", EventId);
                command3.CommandText = query3;
                OleDbDataReader reader3 = command3.ExecuteReader();
                int count = 0;
                while (reader3.Read())
                {
                    count++;
                }
                if (count == 0)
                {
                    this.favlist_button.Image = new Bitmap(Resources.likeNo);
                    favlist = false;
                }
                else
                {
                    this.favlist_button.Image = new Bitmap(Resources.likeYes);
                    favlist = true;

                }

                reader3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
            //Telos
        }

        //Button wste na kanei insert to event sti FavList
        private void favlist_button_Click(object sender, EventArgs e)
        {

            if (favlist)
            {
                try
                {

                    connection.Open();
                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection;
                    string query3 = "delete * from FavList where [UserID] = @Userid and [EventID] = @Eventid";
                    command3.Parameters.AddWithValue("@Userid", Login.UserID);
                    command3.Parameters.AddWithValue("@eventid", EventId);
                    command3.CommandText = query3;
                    command3.ExecuteScalar();
                    MessageBox.Show("Deleted from favorite list! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    connection.Close();
                }
                this.favlist_button.Image = new Bitmap(Resources.likeNo);
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into FavList ([EventID], [UserID]) values (@Eventid, @Userid)";
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Eventid", EventId);
                    command.Parameters.AddWithValue("@Userid", Login.UserID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Saved to favorite list! ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    connection.Close();
                }
                this.favlist_button.Image = new Bitmap(Resources.likeYes);
            }

        }
        //Telos

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Button gia ta asteria analoga posa pataei na allazei kai img
        private void star1Btn_Click(object sender, EventArgs e)
        {
            int num = 1;
            InsertRating(num);
            this.star1Btn.Image = new Bitmap(Resources.star);
        }

        private void star2Btn_Click(object sender, EventArgs e)
        {
            int num = 2;

            InsertRating(num);
            this.star1Btn.Image = new Bitmap(Resources.star);
            this.star2Btn.Image = new Bitmap(Resources.star);
        }

        private void star3Btn_Click(object sender, EventArgs e)
        {
            int num = 3;

            InsertRating(num);
            this.star1Btn.Image = new Bitmap(Resources.star);
            this.star2Btn.Image = new Bitmap(Resources.star);
            this.star3Btn.Image = new Bitmap(Resources.star);
        }

        private void star4Btn_Click(object sender, EventArgs e)
        {
            int num = 4;

            InsertRating(num);
            this.star1Btn.Image = new Bitmap(Resources.star);
            this.star2Btn.Image = new Bitmap(Resources.star);
            this.star3Btn.Image = new Bitmap(Resources.star);
            this.star4Btn.Image = new Bitmap(Resources.star);
        }

        private void star5Btn_Click(object sender, EventArgs e)
        {
            int num = 5;

            InsertRating(num);
            this.star1Btn.Image = new Bitmap(Resources.star);
            this.star2Btn.Image = new Bitmap(Resources.star);
            this.star3Btn.Image = new Bitmap(Resources.star);
            this.star4Btn.Image = new Bitmap(Resources.star);
            this.star5Btn.Image = new Bitmap(Resources.star);
        }
        //Telos

        //Methodos gia na kanei insert ta asteria sti vasi
        public void InsertRating(int ratingNum)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Rating ( [UserID], [EventID], [Rating]) values (@Userid, @Eventid, @Rating)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Userid", Login.UserID);
                command.Parameters.AddWithValue("@Eventid", EventId);
                command.Parameters.AddWithValue("@Rating", ratingNum);

                command.ExecuteNonQuery();
                MessageBox.Show("Saved your Rating! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }
        //Telos

        //Button gia to tha paei dn tha paei antistoixa
        private void dontgo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                string query = "delete * from AttendList where [UserID] = @Userid and [EvenTID] = @Eventid";
                command.Parameters.AddWithValue("@Userid", Login.UserID);
                command.Parameters.AddWithValue("@Eventid", EventId);
                command.CommandText = query;


                if (command.ExecuteNonQuery() > 0)
                {
                    dontgo_btn.Visible = false;
                    goBtn.Visible = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into AttendList ([UserID], [EvenTID]) values (@Userid, @Eventid)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Userid", Login.UserID);
                command.Parameters.AddWithValue("@Eventid", EventId);

                command.ExecuteNonQuery();
                MessageBox.Show("Have fun! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }
            finally
            {
                connection.Close();
            }

            goBtn.Visible = false;
            dontgo_btn.Visible = true;
        }
        //Telos
    }
}
