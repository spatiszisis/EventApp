using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect;

namespace EventApp
{
    public partial class UserControlΗοme : UserControl
    {
        Connect1 con = new Connect1();
        public UserControlΗοme()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.PnlContainer.Controls.ContainsKey("UserControlShowEvents"))
            {
                UserControlShowEvents scse = new UserControlShowEvents();
                scse.Dock = DockStyle.Fill;
                HomePage.Instance.PnlContainer.Controls.Add(scse);
            }
            HomePage.Instance.PnlContainer.Controls["UserControlShowEvents"].BringToFront();
        }
    }
}
