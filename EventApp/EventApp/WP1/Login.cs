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

namespace EventApp
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }
        public static string username = "";
        public static string password = "";
        public static string Location = "";
        public static Boolean isAdmin; //Metavliti gia na doume ean einai admin i oxi 
        public static int UserID = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Elegxei ena iparxei o xristis ean dn iparxei tou petaei katallilo minima
            try
            {
                String Username = "";
                String Password = "";
                String Email = "";
                String FirstName = "";
                String LastName = "";

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
                    { Email = (String)reader["Email"]; }
                    if (!DBNull.Value.Equals(reader["FirstName"]))
                    { FirstName = (String)reader["FirstName"]; }
                    if (!DBNull.Value.Equals(reader["LastName"]))
                    { LastName = (String)reader["LastName"]; }
                    if (!DBNull.Value.Equals(reader["Location"]))
                    { Location = (String)reader["Location"]; }
                    isAdmin = (Boolean)reader["isAdmin"];
                }

                reader.Close();

                if (count == 1)
                {
                    username = txt_Username.Text;
                    password = txt_Password.Text;
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    HomePage f2 = new HomePage();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Username and password is not correct");
                    connection.Close();
                }


                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            finally
            {
                txt_Username.Text = "Username";
                txt_Password.Text = "Password";
            }
            
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
        }
    }
}
