using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    public class Connect1
    {
        private string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\adopse\adopse-omada2\EventApp\Database.accdb";

        public string ConnectString { get => connectString; set => connectString = value; }
    }
}
