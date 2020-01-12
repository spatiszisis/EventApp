﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EventApp
{
    public partial class UserControlSettingsUser : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        public UserControlSettingsUser()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }
        
        private void UserControlSettingsUser_Load(object sender, EventArgs e)
        {

            //Dark Mode
            int c = (int)UserControlSettingsApp.color;
            if (c == 0)
            {
                this.BackColor = UserControlSettingsApp.darkmodecolor;
                label1.ForeColor = System.Drawing.Color.White;
                label8.ForeColor = System.Drawing.Color.White;
                panel1.BackColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                label7.ForeColor = System.Drawing.Color.White;
            }
            else if (c == 1)
            {
                this.BackColor = Color.White;
            }

            //Grammatoseira
            int g = (int)UserControlSettingsApp.gram;
            if (g == 0)
            {
                label4.Font = new Font("Arial", 16, FontStyle.Bold);
                label1.Font = new Font("Arial", 22, FontStyle.Bold);
                label5.Font = new Font("Arial", 11, FontStyle.Bold);
                label7.Font = new Font("Arial", 11, FontStyle.Bold);
                label2.Font = new Font("Arial", 11, FontStyle.Bold);
                label3.Font = new Font("Arial", 11, FontStyle.Bold);
                label6.Font = new Font("Arial", 11, FontStyle.Bold);
            }
            else if (g == 1)
            {
                label4.Font = new Font("Arial", 12, FontStyle.Bold);
                label1.Font = new Font("Arial", 16, FontStyle.Bold);
                label6.Font = new Font("Arial", 8, FontStyle.Bold);
                label5.Font = new Font("Arial", 8, FontStyle.Bold);
                label7.Font = new Font("Arial", 8, FontStyle.Bold);
                label2.Font = new Font("Arial", 8, FontStyle.Bold);
                label3.Font = new Font("Arial", 8, FontStyle.Bold);
            }

            dataGridViewEvents.DataSource = GetEventsList();
            usernameTxt.Text = Login.username;
            passwordTxt.Text = Login.password;

            //Emfanisi twn pliroforiwn diladi Username kai Password
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                string query = "select * from Users where [Username] = @Username and [Password] = @Password";
                cmd.Parameters.AddWithValue("@Username", Login.username);
                cmd.Parameters.AddWithValue("@Password", Login.password);
                cmd.CommandText = query;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emailTxt.Text = reader["Email"].ToString();
                    firstnameTxt.Text = reader["FirstName"].ToString();
                    lastnameTxt.Text = reader["LastName"].ToString();
                    location_box.Text = reader["Location"].ToString();
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
            //Telos
        }

        //Koumpi wste na kanoume edit tis plirofories tou xristi
        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update Users SET [Username] = @Username, [Password] = @Password, [Email] = @Email, [FirstName] = @FirstName, [LastName] = @LastName, [Location] = @Location WHERE [Username] = @Username and [Password] = @Password";
                command.Parameters.AddWithValue("@Username", usernameTxt.Text);
                command.Parameters.AddWithValue("@Password", passwordTxt.Text);
                command.Parameters.AddWithValue("@Email", emailTxt.Text);
                command.Parameters.AddWithValue("@FirstName", firstnameTxt.Text);
                command.Parameters.AddWithValue("@LastName", lastnameTxt.Text);
                command.Parameters.AddWithValue("@Location", location_box.Text);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("The settings was updated! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }
        //Telos

        //Emfanisi ta Events tou xristi diladi auta pou exei dimiourgisei
        private DataTable GetEventsList()
        {
            DataTable dtEvents = new DataTable();

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Events where [UserID] = @UserID";
                command.Parameters.AddWithValue("@UserID", Login.UserID);
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

        //Delete button wste na svisei auta pou thelei
        private void deleteBtn_Click(object sender, EventArgs e)
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

        //Methodos gia to delete
        private void deleteEvents(int id)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete * from Events where [EventsID] = " + id + "";
                command.CommandText = query;

                //Elegxos gia na deis ena thelei na diagrapsei to event
                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully deleted");
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
        //Telos
    }

}
