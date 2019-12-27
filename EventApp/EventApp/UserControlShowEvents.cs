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
using System.Windows.Documents;

namespace EventApp
{
    public partial class UserControlShowEvents : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        Image icon;

        public UserControlShowEvents()
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

        private void UserControlShowEvents_Load(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();
                //Emfanisi apo to DataUser me vasi ta click tou xristi

                OleDbCommand command00 = new OleDbCommand();
                command00.Connection = connection;
                string query00 = "select * from Events where [EventsID] = @EventID";
                command00.Parameters.AddWithValue("@EventID", EventShowPanelUserControl.eventid);
                command00.CommandText = query00;


                OleDbCommand command01 = new OleDbCommand();
                command01.Connection = connection;
                string query01 = "select count(*) from DataUser";
                command01.CommandText = query01;
                int countEvents00 = (int)command01.ExecuteScalar();

                OleDbDataReader reader00 = command00.ExecuteReader();

                while (reader00.Read())
                {
                    EventShowPanelUserControl listitems = new EventShowPanelUserControl();
                    for (int i = 0; i < countEvents00; i++)
                    {
                        listitems.Title         = reader00["Title"].ToString();
                        listitems.Location      = reader00["Location"].ToString();
                        listitems.Day           = reader00["Day"].ToString();
                        listitems.Time          = reader00["Time"].ToString();
                        icon                    = byteArrayToImage((byte[])reader00["images"]);
                        listitems.Icon          = icon;
                        listitems.BorderStyle   = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanel2.Controls.Count < 0)
                        {
                            flowLayoutPanel2.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel2.Controls.Add(listitems);
                        }
                    }
                }
                
                reader00.Close();

                //Emfanisi tou search erwtimatos apo to homepage

                OleDbCommand command = new OleDbCommand();
                OleDbCommand command1 = new OleDbCommand();
                command.Connection = connection;
                command1.Connection = connection;
                string query = "select * from Events where [Category] = @Category and [Location] = @Location";
                command.Parameters.AddWithValue("@Category", UserControlΗοme.SetValueCategory);
                //command.Parameters.AddWithValue("@Day", UserControlΗοme.SetValueDay);  and [Day] = @Day 
                command.Parameters.AddWithValue("@Location", UserControlΗοme.SetValueLocation);
                string query1 = "select count(*) from Events";
                command.CommandText = query;
                command1.CommandText = query1;
                int countEvents = (int)command1.ExecuteScalar();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EventShowPanelUserControl listitems = new EventShowPanelUserControl();
                    for (int i = 0; i < countEvents; i++)
                    {
                        listitems.Title         = reader["Title"].ToString();
                        listitems.Location      = reader["Location"].ToString();
                        listitems.Day           = reader["Day"].ToString();
                        listitems.Time          = reader["Time"].ToString();
                        icon                    = byteArrayToImage((byte[])reader["images"]);
                        listitems.Icon          = icon;
                        listitems.BorderStyle   = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(listitems);
                        }
                    }
                }
                connection.Dispose();
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

    }
}