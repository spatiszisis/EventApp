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
        public int UserID = 0;
        public String Username = "";
        public String Password = "";
        public String Email = "";
        public String FirstName = "";
        public String LastName = "";
        public String Location = "";

        private void UserControlSettingsUser_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from LoggedInUser";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                 
                while (reader.Read())
                {
                    UserID = (int)reader["UsersID"];
                    Username = (String)reader["Username"];
                    usernameTxt.Text = reader["Username"].ToString();
                    Password = (String)reader["Password"];
                    passwordTxt.Text = reader["Password"].ToString();
                    if (!DBNull.Value.Equals(reader["Email"]))
                    { Email = (String)reader["Email"]; }
                    if (!DBNull.Value.Equals(reader["FirstName"]))
                    { FirstName = (String)reader["FirstName"]; }
                    if (!DBNull.Value.Equals(reader["LastName"]))
                    { LastName = (String)reader["LastName"]; }
                    if (!DBNull.Value.Equals(reader["Location"]))
                    { Location = (String)reader["Location"]; }
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update Users SET [Password] = @Password, [Email] = @Email, [FirstName] = @FirstName, [LastName] = @LastName, [Location] = @Location WHERE [UsersID] = @UserID ";
                command.Parameters.AddWithValue("@UserID", this.UserID);
                command.Parameters.AddWithValue("@Password", passwordTxt.Text);
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
