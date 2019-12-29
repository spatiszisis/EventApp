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
                this.BackColor = Color.Black;
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

        

        private void delete_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewUsers.SelectedRows)
            {
                dataGridViewUsers.Rows.RemoveAt(item.Index);
            }

            foreach (DataGridViewRow item in this.dataGridViewEvents.SelectedRows)
            {
                dataGridViewEvents.Rows.RemoveAt(item.Index);
            }
        }
    }
}
