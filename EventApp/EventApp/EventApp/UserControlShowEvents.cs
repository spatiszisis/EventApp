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
        public string date, city, category;
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
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Events";
                DataSet data = new DataSet();
                //string countRows = "select count(*) from Events";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EventShowPanelUserControl[] listitems = new EventShowPanelUserControl[10];
                    for (int i = 0; i < listitems.Length; i++)
                    {
                        listitems[i] = new EventShowPanelUserControl();

                        listitems[i].Title      = reader["Title"].ToString();
                        listitems[i].Location   = reader["Location"].ToString();
                        listitems[i].Day        = reader["Day"].ToString();
                        listitems[i].Time       = reader["Time"].ToString();
                        listitems[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(listitems[i]);
                        }
                    }
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        /*private void populateItems()
        {
            EventShowPanelUserControl[] listitems = new EventShowPanelUserControl[10];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new EventShowPanelUserControl();

                listitems[i].Title = "MPAAS";
                listitems[i].Location = "asda";
                listitems[i].Day = "asdssssss";
                listitems[i].Time = "12:00";
                listitems[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listitems[i]);
                }
            }
        }*/

    }
}

/*for (int i = 0; i <= 10; i++)
                    {
                        Panel panel1 = new Panel();
                        Label label1 = new Label();
                        Label label2 = new Label();
                        Label label3 = new Label();
                        Label label4 = new Label();
                        panel1.Location = new Point(56, 72);
                        panel1.Size = new Size(212, 200);
                        panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                        label1.Location = new Point(15, 15);
                        label1.Text = reader["Title"].ToString();
                        label1.Size = new Size(104, 16);

                        label2.Location = new Point(20, 20);
                        label2.Text = reader["Day"].ToString();
                        label2.Size = new Size(104, 16);

                        label3.Location = new Point(25, 25);
                        label3.Text = reader["Time"].ToString();
                        label3.Size = new Size(104, 16);

                        label4.Location = new Point(30, 30);
                        label4.Text = reader["Location"].ToString();
                        label4.Size = new Size(104, 16);

                        flowLayoutPanel1.Controls.Add(panel1);
                        panel1.Controls.Add(label1);
                        panel1.Controls.Add(label2);
                        panel1.Controls.Add(label3);
                        panel1.Controls.Add(label4);
                    }
*/