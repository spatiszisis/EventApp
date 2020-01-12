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
    public partial class Registration : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Connect con = new Connect();
        public Registration()
        {
            InitializeComponent();
            connection.ConnectionString = con.ConnectString;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Elegxos an yparxei hdh xrhsths idios kai emfanisi katallilou minimatos
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
                    MessageBox.Show("Username and password is exist! ");
                    connection.Close();
                    connection.Dispose();
                    return;
                    txt_Username.Text = "Username";
                    txt_Password.Text = "Password";
                    txt_Email.Text = "example@gmail.com";
                }
                else
                {
                    try
                    {

                        //Dimiourgia tou xristi
                        OleDbCommand command = new OleDbCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO Users ([Username] , [Password] , [Email])" + " VALUES (@Username,@Password,@Email)";
                        command.Parameters.AddWithValue("@Username", txt_Username.Text);
                        command.Parameters.AddWithValue("@Password", txt_Password.Text);
                        command.Parameters.AddWithValue("@Email", txt_Email.Text);
                        command.Connection = connection;
                        command.ExecuteNonQuery();

                        Login.username = txt_Username.Text;
                        Login.password = txt_Password.Text;
                        MessageBox.Show("The account was created! ");
                        connection.Dispose();
                        this.Hide();
                        Login f2 = new Login();
                        f2.Show();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                        connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
                connection.Close();
            }
            finally
            {
                txt_Username.Text = "Username";
                txt_Password.Text = "Password";
                txt_Email.Text = "example@gmail.com";
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
