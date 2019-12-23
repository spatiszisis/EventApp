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
        
        public UserControlShowEvents()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }
        
        private void UserControlShowEvents_Load(object sender, EventArgs e)
        {
            try
            {
                
                OleDbCommand command = new OleDbCommand();
                OleDbCommand command1 = new OleDbCommand();
                command.Connection = connection;
                command1.Connection = connection;
                string query = "select * from Events where [Category] = @Category and [Location] = @Location";
                command.Parameters.AddWithValue("@Location", UserControlΗοme.SetValueCategory);
                command.Parameters.AddWithValue("@Category", UserControlΗοme.SetValueLocation);
                string query1 = "select count(*) from Events";
                command.CommandText = query;
                command1.CommandText = query1;
                connection.Open();
                int countEvents = (int)command1.ExecuteScalar();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventShowPanelUserControl listitems = new EventShowPanelUserControl();
                    for (int i = 0; i < countEvents; i++)
                    {
                        
                        listitems.Title = reader["Title"].ToString();
                        listitems.Location = reader["Location"].ToString();
                        listitems.Day = reader["Day"].ToString();
                        listitems.Time = reader["Time"].ToString();
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