using System;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kleinei tin Efarmogh
        }

         private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            Home.BackColor = Color.Salmon;  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Home.ForeColor = Color.Black;
        }
        
        private void Home_MouseLeave(object sender, EventArgs e)
        {
            Home.BackColor = Color.DimGray;  //epanafora tou xrwmatos otan fygei to pontiki
            Home.ForeColor = Color.Snow;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
        }


        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create_Event_Click(object sender, EventArgs e)
        {
              SidePanel.Height = Create_Event.Height;
              SidePanel.Top = Create_Event.Top;
        }

        private void Create_Event_MouseHover_1(object sender, EventArgs e)
        {
            Create_Event.BackColor = Color.Salmon;  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Create_Event.ForeColor = Color.Black;
        }
        private void Create_Event_MouseLeave(object sender, EventArgs e)
        {
            Create_Event.BackColor = Color.DimGray;  //epanafora tou xrwmatos otan fygei to pontiki
            Create_Event.ForeColor = Color.Snow;
        } 

        private void Help_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Help.Height;
            SidePanel.Top = Help.Top;
        }
        
        private void Help_MouseHover(object sender, EventArgs e)
        {
            Help.BackColor = Color.Salmon;  //allagei xrwma otan pernas to pontiki panw apto koumpi 
            Help.ForeColor = Color.Black;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackColor = Color.DimGray;  //epanafora tou xrwmatos otan fygei to pontiki
            Help.ForeColor = Color.Snow;
        }
        
        private void About_Us_Click(object sender, EventArgs e)
        {
            SidePanel.Height = About_Us.Height;
            SidePanel.Top = About_Us.Top;
        }

        private void About_Us_MouseHover(object sender, EventArgs e)
        {
            About_Us.BackColor = Color.Salmon;   
            About_Us.ForeColor = Color.Black;
        }
        
        private void About_Us_MouseLeave(object sender, EventArgs e)
        {
            About_Us.BackColor = Color.DimGray;  
            About_Us.ForeColor = Color.Snow;
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Contact.Height;
            SidePanel.Top = Contact.Top;
        }

        private void Contact_MouseHover(object sender, EventArgs e)
        {
            Contact.BackColor = Color.Salmon;
            Contact.ForeColor = Color.Black;
        }

        private void Contact_MouseLeave(object sender, EventArgs e)
        {
            Contact.BackColor = Color.DimGray;
            Contact.ForeColor = Color.Snow;
        }
    }
}
