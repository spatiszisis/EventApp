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
                    titleTxt.Text           = reader["Title"].ToString();
                    descriptionTxt.Text     = reader["Description"].ToString();
                    dateTxt.Text            = reader["Day"].ToString();
                    timeTxt.Text            = reader["Time"].ToString();
                    categoryTxt.Text        = reader["Category"].ToString();
                    locationTxt.Text        = reader["Location"].ToString();
                    icon = byteArrayToImage((byte[])reader["Images"]);
                    imagePictureBox.Image = icon;
                    EventId = (int)reader["EventsID"];
                }
                reader.Close();
                connection.Close();
                connection.Dispose();
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
                command.CommandText = "insert into FavList ( [EventID], [UserID]) values ( @Eventid, @Userid)";
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
    }
}
