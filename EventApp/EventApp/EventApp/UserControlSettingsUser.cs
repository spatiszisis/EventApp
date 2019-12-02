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

                usernameTxt.Text = Username;
                passwordTxt.Text = Password;
                emailTxt.Text = Email;
                firstnameTxt.Text = FirstName;
                lastnameTxt.Text = LastName;
                locationTxt.Text = Location;

                

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
                command.CommandText = "update Users set Username=@Username Password=@Password Email=@Email FirstName=@FirstName LastName=@LastName Location=@Location where UsersID= ";
                command.Parameters.AddWithValue("@Username", usernameTxt.Text);
                command.Parameters.AddWithValue("@Password", passwordTxt.Text);
                command.Parameters.AddWithValue("@Email", emailTxt.Text);
                command.Parameters.AddWithValue("@FirstName", firstnameTxt.Text);
                command.Parameters.AddWithValue("@LastName", lastnameTxt.Text);
                command.Parameters.AddWithValue("@Location", locationTxt.Text);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Dispose();
              
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Username = usernameTxt.Text;
            Password = passwordTxt.Text;
            Email = emailTxt.Text;
            FirstName = firstnameTxt.Text;
            LastName = lastnameTxt.Text;
            Location = locationTxt.Text;
           try
           {
               connection.Open();
               OleDbCommand command = new OleDbCommand();
               command.CommandType = CommandType.Text;
               command.Parameters.AddWithValue("UsersID", UserID);
               command.Parameters.AddWithValue("Username", Username);
               command.Parameters.AddWithValue("Password", Password);
               command.Parameters.AddWithValue("Email", Email);
               command.Parameters.AddWithValue("FirstName", FirstName);
               command.Parameters.AddWithValue("LastName", LastName);
               command.Parameters.AddWithValue("Location", Location);
               command.Connection = connection;
               command.CommandText = "UPDATE Users SET [Username]= ? , [Password]= ? , [Email]= ? , [FirstName]= ? , [LastName]= ? , [Location]= ?  WHERE [UsersID]= ? ";
              


               command.ExecuteNonQuery();
               connection.Dispose();

               MessageBox.Show("Data Saved! ");

               connection.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error " + ex);
           }
            
        }
    }

        
    
}
