using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace EventApp
{
    public partial class AlertForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        Image icon;
        public AlertForm()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Gia na kleinei to notification form
            //AlertForm a = new AlertForm();
            this.Dispose();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            
            //-----------------------------------------------------------------------------
            /* 
             * Edo otan anoigei h forma kleinei meta apo 10 sec.
             * To provlima einai oti kai apo to koumpi ton eidopoihsewn
             * na anoikseis tin forma meta apo 10 sec tha kleisei.
             * Na kleinei mono thn proti fora pou anoigei h forma ginetai apo
             * to HomePage_Load alla den douleuei
             */
            // Arxi
            Timer myTimer = new Timer();
            myTimer.Interval = (10 * 1000); // 10 sec
            myTimer.Tick += new EventHandler(MyTimer_Tick);
            myTimer.Start();

            //Emfanisei twn event analoga me to location pou exei
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                OleDbCommand command1 = new OleDbCommand();
                command.Connection = connection;
                command1.Connection = connection;
                string query = "select * from Events where [Location] = @Location";
                command.Parameters.AddWithValue("@Location", Login.Location);
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

                        if (flowLayoutPanelEventNear.Controls.Count < 0)
                        {
                            flowLayoutPanelEventNear.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanelEventNear.Controls.Add(listitems);
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
            //Telos
        }
        //Telos

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
