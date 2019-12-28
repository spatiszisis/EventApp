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
using Connect;


namespace EventApp
{
    public partial class UserControlSettingsUser : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        public UserControlSettingsUser()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }
        
        private void UserControlSettingsUser_Load(object sender, EventArgs e)
        {
            this.BackColor = UserControlSettingsApp.DefaultBackColor; // gia to dark mode
            usernameTxt.Text = Login.username;
            passwordTxt.Text = Login.password;

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
                    locationTxt.Text = reader["Location"].ToString();
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update Users SET [Username] = @Username, [Password] = @Password, [Email] = @Email, [FirstName] = @FirstName, [LastName] = @LastName, [Location] = @Location WHERE [Username] = @Username and [Password] = @Password";
                command.Parameters.AddWithValue("@Username", Login.username);
                command.Parameters.AddWithValue("@Password", Login.password);
                command.Parameters.AddWithValue("@Email", emailTxt.Text);
                command.Parameters.AddWithValue("@FirstName", firstnameTxt.Text);
                command.Parameters.AddWithValue("@LastName", lastnameTxt.Text);
                command.Parameters.AddWithValue("@Location", locationTxt.Text);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                //connection.Dispose();
                MessageBox.Show("The settings was updated! ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }

    }

}
