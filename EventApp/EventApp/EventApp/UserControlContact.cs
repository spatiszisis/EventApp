using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class UserControlContact : UserControl
    {
        public UserControlContact()
        {
            InitializeComponent();
        }

        private void nameTxt_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailTxt.Clear();
        }

        private void numberTxt_Click(object sender, EventArgs e)
        {
            numberTxt.Clear();
        }

        private void messageTxt_Click(object sender, EventArgs e)
        {
            messageTxt.Clear();
        }
    }
}
