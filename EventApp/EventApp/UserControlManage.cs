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

namespace EventApp
{
    public partial class UserControlManage : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        public UserControlManage()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        private void UserControlManage_Load(object sender, EventArgs e)
        {
            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label1.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }

            dataGridViewUsers.DataSource = GetUsersList();
            dataGridViewEvents.DataSource = GetUsersEvents();
        }

        private DataTable GetUsersList()
        {
            DataTable dtUsers = new DataTable();

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Users";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                dtUsers.Load(reader);

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }

            return dtUsers;
        }

        private DataTable GetUsersEvents()
        {
            DataTable dtEvents = new DataTable();

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Events";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                dtEvents.Load(reader);

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

            return dtEvents;
        }

        private void deleteUsersBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {
                String selected = dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                deleteUsers(id);
            }
        }

        private void deleteEventsBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewEvents.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {
                String selected = dataGridViewEvents.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                deleteEvents(id);
            }
            
        }
        private void deleteUsers(int id)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete * from Users where [UsersID] = " + id + "";
                command.CommandText = query;

                //PROMPT FOR CONFIRMATION BEFORE DELETING
                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully deleted");
                        dataGridViewUsers.Refresh();
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void deleteEvents(int id)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete * from Events where [EventsID] = " + id + "";
                command.CommandText = query;

                //PROMPT FOR CONFIRMATION BEFORE DELETING
                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully deleted");
                        dataGridViewEvents.Refresh();
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControlManage scse = new UserControlManage();
            scse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControlManage scse = new UserControlManage();
            scse.Show();
        }
    }
}
