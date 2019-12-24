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
    public partial class Registration : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect1 con = new Connect1();
        public Registration()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {   //elegxos an yparxei hdh xrhsths idios
            connection.ConnectionString = con.ConnectString;
            OleDbCommand elegxos = new OleDbCommand();
            elegxos.CommandType = CommandType.Text;
            elegxos.CommandText = "select * from Users where Username='" + txt_Username.Text + "' and Password= '" + txt_Password.Text + "'";
            elegxos.Connection = connection;
            connection.Open();


            OleDbDataReader readerelegxos = elegxos.ExecuteReader();
            int countelegxos = 0;
            while (readerelegxos.Read())
            {
                countelegxos++;
            }

            if (countelegxos == 1)
            {
                txt_Username.Clear();
                txt_Password.Clear();
                txt_Email.Clear();
                connection.Close();
                connection.Dispose();
                return;
            }
            else
            {

                try
                {
                    //dhmiourgia xrhsth
                    OleDbCommand command = new OleDbCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO Users ([Username] , [Password] , [Email])" + " VALUES (@Username,@Password,@Email)";
                    command.Parameters.AddWithValue("@Username", txt_Username.Text);
                    command.Parameters.AddWithValue("@Password", txt_Password.Text);
                    command.Parameters.AddWithValue("@Email", txt_Email.Text);
                    command.Connection = connection;

               
                    command.ExecuteNonQuery();
                    connection.Close();
          
                    //dhmiourgia session
                    int UserID = 0;
                    String Username = "";
                    String Password = "";
                    String Email = "";
                    String FirstName = "";
                    String LastName = "";
                    String Location = "";


                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;
                    connection.Open();
                    command1.CommandText = "select * from Users where Username='" + txt_Username.Text + "' and Password= '" + txt_Password.Text + "'";

                    OleDbDataReader reader = command1.ExecuteReader();
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
                    }
                    reader.Close();
                    if (count == 1)
                    {
                        Login.username = txt_Username.Text;
                        Login.password = txt_Password.Text;
                        connection.Close();
                        connection.Dispose();
                        this.Hide();
                        HomePage f2 = new HomePage();
                        f2.Show();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

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

        private void txt_Email_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();

        }

        private void closeFromRegistration_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kleinei tin Efarmogh
        }
    }
}
