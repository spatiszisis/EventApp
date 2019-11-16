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
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ζήσης\Desktop\Σχολή\ΑΟΠΣΕ - ΕΡΓΑΣΙΑ\EventApp\Data.accdb;
                                            Persist Security Info=False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Users where Username='" + txt_Username.Text + "' and Password= '" + txt_Password.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                //MessageBox.Show("Username and password is correct");
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration re = new Registration();
            re.Show();
        }
    }
}
