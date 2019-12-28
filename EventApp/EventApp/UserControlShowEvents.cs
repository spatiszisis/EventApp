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
        public int Eventid = 0;

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

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string query2 = "select * from DataUser where [UserID] = @Userid";
                command2.Parameters.AddWithValue("@Userid", Login.UserID);
                command2.CommandText = query2;
                OleDbDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    Eventid = (int)reader2["EventID"];

                    EventShowPanelUserControl listitems2 = new EventShowPanelUserControl();

                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection;
                    string query3 = "select * from Events where [EventsID] = @Eventid";
                    command3.Parameters.AddWithValue("@Eventid", Eventid);
                    command3.CommandText = query3;
                    OleDbDataReader reader3 = command3.ExecuteReader();

                    while (reader3.Read())
                    {

                        listitems2.Title = reader3["Title"].ToString();
                        listitems2.Location = reader3["Location"].ToString();
                        listitems2.Day = reader3["Day"].ToString();
                        listitems2.Time = reader3["Time"].ToString();
                        icon = byteArrayToImage((byte[])reader3["images"]);
                        listitems2.Icon = icon;
                        listitems2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanel2.Controls.Count < 0)
                        {
                            flowLayoutPanel2.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel2.Controls.Add(listitems2);
                        }

                    }
                    reader3.Close();


                }
                reader2.Close();

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
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
            finally
            {
                UserControlΗοme.SetValueLocation = "";
                UserControlΗοme.SetValueCategory = "";
                connection.Close();
                connection.Dispose();
            }
        }

    }
}