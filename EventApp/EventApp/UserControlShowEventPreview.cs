using System;
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
        Image icon;       
        public int EventId = 0;
        int count = 0;

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

        private void UserControlShowEventPreview_Load(object sender, EventArgs e)
        {
           
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = Color.Black;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }

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
                    titleTxt.Text           = reader["Title"].ToString();
                    descriptionTxt.Text     = reader["Description"].ToString();
                    dateTxt.Text            = reader["Day"].ToString();
                    timeTxt.Text            = reader["Time"].ToString();
                    categoryTxt.Text        = reader["Category"].ToString();
                    locationTxt.Text        = reader["Location"].ToString();
                    icon                    = byteArrayToImage((byte[])reader["Images"]);
                    imagePictureBox.Image   = icon;
                    EventId                 = (int)reader["EventsID"];
                }
                reader.Close();
                connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            //Tha paw den tha paw elenxos an to exei pathsei hdh h oxi
            try
            {

                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                //command1.CommandType = CommandType.Text;
                string query1 = "select * from AttendList where [UserID] = @user and [EventID] = @eventid";
                command1.Parameters.AddWithValue("@user", Login.UserID);
                command1.Parameters.AddWithValue("@eventid", EventId);
                command1.CommandText = query1;
                OleDbDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
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

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }



        }

        private void favlist_button_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into FavList ( [EventID], [UserID]) values (@Eventid, @Userid)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Eventid", EventId);
                command.Parameters.AddWithValue("@Userid", Login.UserID);

                command.ExecuteNonQuery();
                //command.Dispose();
                MessageBox.Show("Saved to favorite! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into AttendList ([UserID], [EventID]) values (@Userid, @Eventid)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Eventid", EventId);
                command.Parameters.AddWithValue("@Userid", Login.UserID);

                command.ExecuteNonQuery();
                //command.Dispose();
                MessageBox.Show("Θα πάτε σε αυτή την εκδήλωση ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }

            goBtn.Visible = false;
            dontgo_btn.Visible = true;
        }

        private void dontgo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete * from AttendList where [EventID] = @Eventid and [UserID] = @Userid";
                command.Parameters.AddWithValue("@Eventid", EventId);
                command.Parameters.AddWithValue("@Userid", Login.UserID);
                command.CommandText = query;
               
                
                    if (command.ExecuteNonQuery() > 0)
                    {
                    dontgo_btn.Visible = false;
                    goBtn.Visible = true;
                    }
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
          
            }
        }
    }
}
