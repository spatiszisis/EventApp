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

        

        /*private byte[] savePhoto()
        {
            MemoryStream ms = new MemoryStream();
            picBox.Image.Save(ms, picBox.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(dlg.FileName);
            }
        }*/
        
        private void save_btn_Click(object sender, EventArgs e)
        {
            EventShowPanelUserControl.title = title_txt.Text;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Events ([Title],[Category],[Description],[Day],[Time],[Location]) values (@Title, @Category, @Description, @Day, @Time, @Location)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Title", title_txt.Text);
                command.Parameters.AddWithValue("@Category", category_box.Text);
                command.Parameters.AddWithValue("@Description", description_txt.Text);
                command.Parameters.Add("@Day", OleDbType.Date).Value = dateTimePicker.Value;
                command.Parameters.AddWithValue("@Time", time_txt.Text);
                command.Parameters.AddWithValue("@Location", location_txt.Text);
                //command.Parameters.AddWithValue("@Images", savePhoto());

                command.ExecuteNonQuery();
                //command.Dispose();
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
                title_txt.Clear();
                category_box.Text = "Please Select";
                description_txt.Clear();
                dateTimePicker = null;
                time_txt.Clear();
                location_txt.Clear();
                picBox.Image = null;
            }
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
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
