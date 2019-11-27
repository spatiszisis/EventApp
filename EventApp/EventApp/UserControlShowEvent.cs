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

namespace EventApp
{
    public partial class UserControlShowEvent : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UserControlShowEvent()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ζήσης\Desktop\Σχολή\ΑΟΠΣΕ - ΕΡΓΑΣΙΑ\GitHub\adopse-omada2-master\adopse-omada2-master (1)\adopse-omada2-master\EventApp\Data.accdb;
                                            Persist Security Info=False;";
        }

        private void UserControlShowEvent_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Events where";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
