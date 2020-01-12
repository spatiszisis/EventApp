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
    public partial class UserControlManage : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
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

        //Emfanisi twn Users kai Events antistoixa sto DataGridView
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
            catch (Exception ex)
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
        //Telos


        //Afairesi twn Users apo to datagridview
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
        //Telos

        //Afairesi twn Events apo to datagridview
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
        //Telos

        //Methodoi gia afairesi antistoixa gia Users kai Events
        private void deleteUsers(int id)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete * from Users where [UsersID] = " + id + "";
                command.CommandText = query;

                //Elegxos ena thelei na to diagrapsei 
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
            finally
            {
                dataGridViewUsers.Refresh();
                dataGridViewUsers.Update();
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
            finally
            {
                dataGridViewEvents.Refresh();
                dataGridViewEvents.Update();
            }
        }
        //Telos

    }
}
