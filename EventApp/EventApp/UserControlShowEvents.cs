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
using System.Windows.Documents;

namespace EventApp
{
    public partial class UserControlShowEvents : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        Image icon;
        public int Eventid = 0;

        public UserControlShowEvents()
        {
            InitializeComponent();

        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void UserControlShowEvents_Load(object sender, EventArgs e)
        {
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label1.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }
            try
            {
                connection.ConnectionString = con.ConnectString;
                connection.Open();
                //Emfanisi apo to DataUser me vasi ta click tou xristi

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string query2 = "select distinct [EventID] from DataUser where [UserID] = @Userid";
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
                        listitems2.Day = (DateTime)reader3["Day"];
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
                connection.Close();
            }

            //End Emfanisi apo to DataUser me vasi ta click tou xristi

            //Emfanisi tou search erwtimatos apo to homepage

            //na emfanisei mono to day
            if (UserControlΗοme.SetValueDay != String.Empty && UserControlΗοme.SetValueCategory.Equals("Anything") && UserControlΗοme.SetValueLocation.Equals("Any City"))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command1 = new OleDbCommand();
                    command.Connection = connection;
                    command1.Connection = connection;
                    string query = "select * from Events where [Day] = @Day";
                    command.Parameters.AddWithValue("@Day", UserControlΗοme.SetValueDay);
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
                            listitems.Title = reader["Title"].ToString();
                            listitems.Location = reader["Location"].ToString();
                            listitems.Day = (DateTime)reader["Day"];
                            listitems.Time = reader["Time"].ToString();
                            icon = byteArrayToImage((byte[])reader["images"]);
                            listitems.Icon = icon;
                            listitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

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
                    connection.Close();
                }

            }
            //na emfanisei mono to category
            else if (UserControlΗοme.SetValueCategory != String.Empty && UserControlΗοme.SetValueDay != String.Empty && UserControlΗοme.SetValueLocation.Equals("Any City"))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command1 = new OleDbCommand();
                    command.Connection = connection;
                    command1.Connection = connection;
                    string query = "select * from Events where [Category] = @Category";
                    command.Parameters.AddWithValue("@Category", UserControlΗοme.SetValueCategory);
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
                            listitems.Title = reader["Title"].ToString();
                            listitems.Location = reader["Location"].ToString();
                            listitems.Day = (DateTime)reader["Day"];
                            listitems.Time = reader["Time"].ToString();
                            icon = byteArrayToImage((byte[])reader["images"]);
                            listitems.Icon = icon;
                            listitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

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
                    connection.Close();
                }

            }
            //na emfanisei mono to location
            else if (UserControlΗοme.SetValueLocation != String.Empty && UserControlΗοme.SetValueDay != String.Empty && UserControlΗοme.SetValueCategory.Equals("Anything"))
            { 
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command1 = new OleDbCommand();
                    command.Connection = connection;
                    command1.Connection = connection;
                    string query = "select * from Events where [Location] = @Location";
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
                            listitems.Title = reader["Title"].ToString();
                            listitems.Location = reader["Location"].ToString();
                            listitems.Day = (DateTime)reader["Day"];
                            listitems.Time = reader["Time"].ToString();
                            icon = byteArrayToImage((byte[])reader["images"]);
                            listitems.Icon = icon;
                            listitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

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
                    connection.Close();
                }

            }
            else //Na emfanisei ena event me sigkekrimeni imerominia , category , location
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command1 = new OleDbCommand();
                    command.Connection = connection;
                    command1.Connection = connection;
                    string query = "select * from Events where [Category] = @Category and [Day] = @Day and [Location] = @Location";
                    command.Parameters.AddWithValue("@Category", UserControlΗοme.SetValueCategory);
                    command.Parameters.AddWithValue("@Day", UserControlΗοme.SetValueDay);
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
                            listitems.Title = reader["Title"].ToString();
                            listitems.Location = reader["Location"].ToString();
                            listitems.Day = (DateTime)reader["Day"];
                            listitems.Time = reader["Time"].ToString();
                            icon = byteArrayToImage((byte[])reader["images"]);
                            listitems.Icon = icon;
                            listitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

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
                    connection.Close();
                }
            }

            // na emfanisei ola ta events
            if (UserControlΗοme.SetValueCategory.Equals("All Events"))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command1 = new OleDbCommand();
                    command.Connection = connection;
                    command1.Connection = connection;
                    string query = "select * from Events";
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
                            listitems.Title = reader["Title"].ToString();
                            listitems.Location = reader["Location"].ToString();
                            listitems.Day = (DateTime)reader["Day"];
                            listitems.Time = reader["Time"].ToString();
                            icon = byteArrayToImage((byte[])reader["images"]);
                            listitems.Icon = icon;
                            listitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

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
                    connection.Close();
                }

            }

            /*try
            {
                OleDbCommand command = new OleDbCommand();
                OleDbCommand command1 = new OleDbCommand();
                command.Connection = connection;
                command1.Connection = connection;
                string query = "select * from Events where [Category] like %@Search%";
                command.Parameters.AddWithValue("@Search", HomePage.SetValueSearch);
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
                        listitems.Title = reader["Title"].ToString();
                        listitems.Location = reader["Location"].ToString();
                        listitems.Day = (DateTime)reader["Day"];
                        listitems.Time = reader["Time"].ToString();
                        icon = byteArrayToImage((byte[])reader["images"]);
                        listitems.Icon = icon;
                        listitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

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
                connection.Close();
            }
        */
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}