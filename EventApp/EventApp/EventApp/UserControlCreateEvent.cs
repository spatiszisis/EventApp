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
    public partial class UserControlCreateEvent : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        public UserControlCreateEvent()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        //Arxi Clear Method gia ta text

        private void title_txt_Click(object sender, EventArgs e)
        {
            title_txt.Clear();
        }

        private void description_txt_Click(object sender, EventArgs e)
        {
            description_txt.Clear();
        }

        private void location_txt_Click(object sender, EventArgs e)
        {
            location_txt.Clear();
        }

        private void time_txt_Click(object sender, EventArgs e)
        {
            time_txt.Clear();
        }

        //Telos Clear Method gia ta text


        //Arxi Click Method gia ta koumpia

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Events ([Title] , [Category] , [Description] , [Image] , [LocationID] , [Day] , [Time] )" + " VALUES (@Title,@Category,@Description,@Image,@LocationID,@Day,@Time)";
                command.Parameters.AddWithValue("@Title", title_txt.Text);
                command.Parameters.AddWithValue("@Category", category_box.Text);
                command.Parameters.AddWithValue("@Description", description_txt.Text);
                command.Parameters.AddWithValue("@Image", SavePhoto());
                command.Parameters.AddWithValue("@LocationID", location_txt.Text);
                command.Parameters.AddWithValue("@Day", dateTimePicker.Text);
                command.Parameters.AddWithValue("@Time", time_txt.Text);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Dispose();
                MessageBox.Show("Event Saved! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            picImage_box.Image.Save(ms, picImage_box.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void loadimage_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    picImage_box.Image = new Bitmap(dlg.FileName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void discard_btn_Click_1(object sender, EventArgs e)
        {
            //title_txt.Text = null;
            //category_box = null;
            //description_txt.Text = null;
            //location_txt.Text = null;
            //dateTimePicker = null;
            //time_txt.Text = null;
            //picImage_box.Image = null;

            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEventPreview"))
            {
                UserControlShowEventPreview scse = new UserControlShowEventPreview();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEventPreview"].BringToFront();
        }

       

        //Telos Click Method gia ta koumpia
    }
}
