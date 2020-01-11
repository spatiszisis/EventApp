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
            AlertForm a = new AlertForm();
            this.Close();
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

            //Ta event pou einai konta se auton
            try
            {
                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string query1 = "select * from Events where [Location] = @Location";
                command1.Parameters.AddWithValue("@Location", Login.Location);
                command1.CommandText = query1;
                OleDbDataReader reader = command1.ExecuteReader();

                EventShowPanelUserControl listitems = new EventShowPanelUserControl();
                while (reader.Read())
                {
                   
                        listitems.Title         = reader["Title"].ToString();
                        listitems.Location      = reader["Location"].ToString();
                        listitems.Day           = (DateTime)reader["Day"];
                        listitems.Time          = reader["Time"].ToString();
                        icon                    = byteArrayToImage((byte[])reader["images"]);
                        listitems.Icon          = icon;
                        listitems.BorderStyle   = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanelEventNear.Controls.Count < 0)
                        {
                            flowLayoutPanelEventNear.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanelEventNear.Controls.Add(listitems);
                        }

                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
                connection.Close();
            }
        }

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
