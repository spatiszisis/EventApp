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

namespace EventApp
{
    public partial class UserControlCreateEvent : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UserControlCreateEvent()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ζήσης\Desktop\Σχολή\ΑΟΠΣΕ - ΕΡΓΑΣΙΑ\GitHub\adopse-omada2-master\adopse-omada2-master (1)\adopse-omada2-master\EventApp\Data.accdb;
                                            Persist Security Info=False;";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Events ([Title] , [Category] , [Type], [Description] , [Image] , [Location] , [Day] , [Time] )" + " VALUES (@Title,@Category,@Type,@Description,@Image,@Location,@Day,@Time)";
                command.Parameters.AddWithValue("@Title", title_txt.Text);
                command.Parameters.AddWithValue("@Category", category_box.Text);
                command.Parameters.AddWithValue("@Type", type_box.Text);
                command.Parameters.AddWithValue("@Description", description_txt.Text);
                command.Parameters.AddWithValue("@Image", picImage_box);
                command.Parameters.AddWithValue("@Location", location_txt.Text);
                command.Parameters.AddWithValue("@Day", dateTimePicker);
                command.Parameters.AddWithValue("@Time", time_txt.Text);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Dispose();
                if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEvent"))
                {
                    UserControlShowEvent scse = new UserControlShowEvent();
                    scse.Dock = DockStyle.Fill;
                    HomePage.Instance.PnlContainer.Controls.Add(scse);
                }
                HomePage.Instance.PnlContainer.Controls["UserControlShowEvent"].BringToFront();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void loadimage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                picImage_box.ImageLocation = picPath;
            }
        }

        private void discard_btn_Click(object sender, EventArgs e)
        {
            title_txt.Text = null;
            type_box = null;
            category_box = null;
            description_txt.Text = null;
            location_txt.Text = null;
            dateTimePicker = null;
            time_txt.Text = null;
            picImage_box = null;
        }
    }
}
