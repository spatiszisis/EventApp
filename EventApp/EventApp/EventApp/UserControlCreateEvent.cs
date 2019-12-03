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
using System.Drawing.Imaging;

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




        private void loadimage_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                //dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBox.Image = Image.FromFile(dlg.FileName);
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

        private void save_btn_Click(object sender, EventArgs e)
        {

            //MemoryStream ms = new MemoryStream();
            //picImage_box.Image.Save(ms, ImageFormat.Png);
            //byte[] photo = ms.GetBuffer();

            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Events (title,category,description,[Day],[Time],location,[Image]) values (@Title, @Category, @Description, @Day, @Time, @Location, @Image)";
            command.Connection = connection;
            byte[] yourPhoto = imageToByteArray(picBox.Image);
            command.Parameters.AddWithValue("@Title", title_txt.Text);
            command.Parameters.AddWithValue("@Category", category_box.Text);
            command.Parameters.AddWithValue("@Description", description_txt.Text);
            command.Parameters.Add("@Day", OleDbType.Date).Value = dateTimePicker.Value;
            command.Parameters.AddWithValue("@Time", time_txt.Text);
            command.Parameters.AddWithValue("@Location", location_txt.Text);
            command.Parameters.AddWithValue("@Image", yourPhoto);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Event Saved! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
            finally
            {

            }
        }
        public byte[] imageToByteArray(Image iImage)
        {
            MemoryStream mMemoryStream = new MemoryStream();
            iImage.Save(mMemoryStream, ImageFormat.Png);
            return mMemoryStream.ToArray();
        }


        //Telos Click Method gia ta koumpia
    }
}
