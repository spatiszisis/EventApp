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

        public UserControlShowEventPreview()
        {
            InitializeComponent();
            Connect1 c = new Connect1 ();
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
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

    }
}
