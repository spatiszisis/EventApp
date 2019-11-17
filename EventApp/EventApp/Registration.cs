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
        public Registration()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ζήσης\Desktop\Σχολή\ΑΟΠΣΕ - ΕΡΓΑΣΙΑ\EventApp\Data.accdb;
                                            Persist Security Info=False;";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Users ([Username] , [Password] , [Email])" + " VALUES (@Username,@Password,@Email)";
                command.Parameters.AddWithValue("@Username", txt_Username.Text);
                command.Parameters.AddWithValue("@Password", txt_Password.Text);
                command.Parameters.AddWithValue("@Email", txt_Email.Text);
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Dispose();
                this.Hide();
                HomePage f2 = new HomePage();
                f2.Show();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
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
    }
}
