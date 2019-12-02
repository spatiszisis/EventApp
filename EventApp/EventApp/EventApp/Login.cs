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
using Connect;

namespace EventApp
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            String Username = "";
            String Password = "";
            String Email = "";
            String FirstName = "";
            String LastName = "";
            String Location = "";
            

            connection.Open();

            OleDbCommand command = new OleDbCommand();
            OleDbCommand command2 = new OleDbCommand();
            OleDbCommand command3 = new OleDbCommand();
            command.Connection = connection;
            command2.Connection = connection;
            command3.Connection = connection;
            command.CommandText = "select * from Users where Username='" + txt_Username.Text + "' and Password= '" + txt_Password.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
                
                UserID = (int)reader["UsersID"];
                Username = (String)reader["Username"];
                Password = (String)reader["Password"];
                if (!DBNull.Value.Equals(reader["Email"]))
                {  Email = (String)reader["Email"];         }
                if (!DBNull.Value.Equals(reader["FirstName"]))
                {  FirstName = (String)reader["FirstName"]; }
                if (!DBNull.Value.Equals(reader["LastName"])) 
                {  LastName = (String)reader["LastName"];   }
                if (!DBNull.Value.Equals(reader["Location"]))
                {  Location = (String)reader["Location"];   }
            }
            reader.Close();
            if (count == 1)
            {
                
                command2.CommandText = "CREATE TABLE LoggedInUser([UsersID] int , [Username] text , [Password] text , [Email] text , [FirstName] text , [LastName] text , [Location] text )";
                command2.ExecuteNonQuery();
                //MessageBox.Show("Username and password is correct");
                
                command3.CommandText = "INSERT INTO LoggedInUser ( [UsersID] , [Username] , [Password] , [Email] , [FirstName] , [LastName] , [Location] ) VALUES (@UserID,@Usernname,@Password,@Email,@FirstName,@LastName,@Location)";
                command3.Parameters.AddWithValue("@UserID", UserID);
                command3.Parameters.AddWithValue("@Usernname", Username);
                command3.Parameters.AddWithValue("@Password", Password);
                command3.Parameters.AddWithValue("@Email", Email);
                command3.Parameters.AddWithValue("@FirstName", FirstName);
                command3.Parameters.AddWithValue("@LastName", LastName);
                command3.Parameters.AddWithValue("@Location", Location);
                command3.ExecuteNonQuery();

                connection.Close();
                connection.Dispose();
                this.Hide();
                HomePage f2 = new HomePage();
                f2.Show();

            }
            else
            {
                MessageBox.Show("Username and password is not correct");
            }


            connection.Close();
        }


        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
        }


        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
            txt_Password.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration re = new Registration();
            re.Show();
        }

        private void closeFromLogin_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kleinei tin Efarmogh
            connection.ConnectionString = con.ConnectString;
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DROP TABLE LoggedInUser; ";
            try { 
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
            }
            catch(System.Data.OleDb.OleDbException) 
            {   
                connection.Close();
                connection.Dispose();
                Application.Exit();
            }
           
        }
    }
}
