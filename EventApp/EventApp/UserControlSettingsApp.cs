﻿using System;
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
    public partial class UserControlSettingsApp : UserControl
    {
        private FormBorderStyle FormBorderStyle;
        public static int color; // Gia to xrwma
        public static int gram; // Gia tin grammatoseira
        public UserControlSettingsApp()
        {
            InitializeComponent();
        }

        private void onvalue_CheckedChanged(object sender, EventArgs e)
        {
            if(onvalue.Checked == true)
            {
                color = 0;
                this.BackColor = Color.Black;
            }
            else
            {
                color = 1;
                this.BackColor = Color.White;
            }
        }

        private void checkboxchangeborderstyleform_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxchangeborderstyleform.Checked == true)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                // Auksisi tis grammatoseiras
                gram = 0;
                label2.Font = new Font("Arial", 14, FontStyle.Bold);
                label3.Font = new Font("Arial", 14, FontStyle.Bold);
            }
            else
            {
                // Meiwsei tis grammatoseiras
                gram = 1;
                label2.Font = new Font("Arial", 12, FontStyle.Bold);
                label3.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }
    }
}
