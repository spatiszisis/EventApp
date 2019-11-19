﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            SidePanel.Height = Create_Event.Height;
            userControlCreateEvent1.BringToFront();
            SidePanel.Height = Home.Height;
            userControlΗοme1.BringToFront();
            userControlAboutUs1.BringToFront();
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(85, 61, 69);  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Home.ForeColor = Color.Black;
        }
        
        private void Home_MouseLeave(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(87, 96, 122);  //epanafora tou xrwmatos otan fygei to pontiki
            Home.ForeColor = Color.Snow;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            userControlΗοme1.BringToFront();
        }

        private void Create_Event_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Create_Event.Height;
            SidePanel.Top = Create_Event.Top;
            userControlCreateEvent1.BringToFront();
        }

        private void Create_Event_MouseHover_1(object sender, EventArgs e)
        {
            Create_Event.BackColor = Color.FromArgb(85, 61, 69);  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Create_Event.ForeColor = Color.Black;
        }
        private void Create_Event_MouseLeave(object sender, EventArgs e)
        {
            Create_Event.BackColor = Color.FromArgb(87, 96, 122);  //epanafora tou xrwmatos otan fygei to pontiki
            Create_Event.ForeColor = Color.Snow;
        } 

        private void Help_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Help.Height;
            SidePanel.Top = Help.Top;
        }
        
        private void Help_MouseHover(object sender, EventArgs e)
        {
            Help.BackColor = Color.FromArgb(85, 61, 69);  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Help.ForeColor = Color.Black;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackColor = Color.FromArgb(87, 96, 122);  //epanafora tou xrwmatos otan fygei to pontiki
            Help.ForeColor = Color.Snow;
        }
        
        private void About_Us_Click(object sender, EventArgs e)
        {
            SidePanel.Height = About_Us.Height;
            SidePanel.Top = About_Us.Top;
            userControlAboutUs1.BringToFront();
        }

        private void About_Us_MouseHover(object sender, EventArgs e)
        {
            About_Us.BackColor = Color.FromArgb(85, 61, 69);   
            About_Us.ForeColor = Color.Black;
        }
        
        private void About_Us_MouseLeave(object sender, EventArgs e)
        {
            About_Us.BackColor = Color.FromArgb(87, 96, 122);  
            About_Us.ForeColor = Color.Snow;
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Contact.Height;
            SidePanel.Top = Contact.Top;
        }

        private void Contact_MouseHover(object sender, EventArgs e)
        {
            Contact.BackColor = Color.FromArgb(85, 61, 69);
            Contact.ForeColor = Color.Black;
        }

        private void Contact_MouseLeave(object sender, EventArgs e)
        {
            Contact.BackColor = Color.FromArgb(87, 96, 122);
            Contact.ForeColor = Color.Snow;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kleinei tin Efarmogh
        }

        
    }
}
