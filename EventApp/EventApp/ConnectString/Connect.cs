using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Connect
    {
        private string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Giannis\Desktop\Νέος φάκελος (2)\EventApp\Database.accdb";

        public string ConnectString { get => connectString; set => connectString = value; }
    }
}
