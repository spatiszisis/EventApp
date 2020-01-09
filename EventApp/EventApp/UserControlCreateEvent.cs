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
using System.Drawing.Imaging;

namespace EventApp
{
    public partial class UserControlCreateEvent : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        public String imgpath = "";

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

        private byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, format);
            return ms.ToArray();
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(picBox.Image);
            byte[] imagebt = ImageToByte(bm, System.Drawing.Imaging.ImageFormat.Jpeg);

            EventShowPanelUserControl.title = title_txt.Text;
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Events ([Title],[Category],[Description],[Day],[Time],[Location],[images],[UserID]) values (@Title, @Category, @Description, @Day, @Time, @Location, @Images,@UserID)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@Title", title_txt.Text);
                command.Parameters.AddWithValue("@Category", category_box.Text);
                command.Parameters.AddWithValue("@Description", description_txt.Text);
                command.Parameters.Add("@Day", dateTimePicker.Value.Date.ToString("dd-MM-yyyy"));
                command.Parameters.AddWithValue("@Time", time_txt.Text);
                command.Parameters.AddWithValue("@Location", location_txt.Text);
                command.Parameters.AddWithValue("@Images", imagebt);
                command.Parameters.AddWithValue("@UserID", Login.UserID);

                command.ExecuteNonQuery();
                MessageBox.Show("Event Saved! ");
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
                connection.Dispose();
            }
            finally
            {
                title_txt.Text = "Event Title";
                category_box.Text = "Please Select";
                description_txt.Text  = "Add Description...";
                this.dateTimePicker.CustomFormat = null;
                time_txt.Text = "Time";
                location_txt.Text = "Search for location";
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

        private void loadimage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgpath = dlg.FileName.ToString();
                picBox.ImageLocation = imgpath;
            }
        }

        private void UserControlCreateEvent_Load(object sender, EventArgs e)
        {
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label1.ForeColor = System.Drawing.Color.White;
                panel1.BackColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                panel2.BackColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                panel3.BackColor = System.Drawing.Color.White;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }
        }
    }
}
