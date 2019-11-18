namespace EventApp
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Contact = new System.Windows.Forms.Button();
            this.About_Us = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Create_Event = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.User_label = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(763, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 272);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "And I\'m in the mood for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "In";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Anything",
            "Party",
            "Film",
            "Festivals",
            "Tournament",
            "Game or Competition",
            "Trip",
            "Tour",
            "Seminar or Talk",
            "Other"});
            this.comboBox3.Location = new System.Drawing.Point(38, 183);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Thessaloniki",
            "Athens",
            "Patra",
            "Larisa",
            "Ioannina",
            "Volos",
            "Herakleion"});
            this.comboBox2.Location = new System.Drawing.Point(38, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Any date"});
            this.comboBox1.Location = new System.Drawing.Point(38, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "I want to go out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.Contact);
            this.panel2.Controls.Add(this.About_Us);
            this.panel2.Controls.Add(this.Help);
            this.panel2.Controls.Add(this.Create_Event);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 635);
            this.panel2.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Salmon;
            this.SidePanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SidePanel.Location = new System.Drawing.Point(0, 191);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 59);
            this.SidePanel.TabIndex = 4;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = global::EventApp.Properties.Resources.oie_1895421D1UY7qaw;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 158);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Contact
            // 
            this.Contact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Contact.ForeColor = System.Drawing.Color.Snow;
            this.Contact.Image = global::EventApp.Properties.Resources.icons8_mail_contact_24;
            this.Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contact.Location = new System.Drawing.Point(10, 515);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(155, 50);
            this.Contact.TabIndex = 4;
            this.Contact.Text = "Contact";
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            this.Contact.MouseLeave += new System.EventHandler(this.Contact_MouseLeave);
            this.Contact.MouseHover += new System.EventHandler(this.Contact_MouseHover);
            // 
            // About_Us
            // 
            this.About_Us.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.About_Us.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.About_Us.ForeColor = System.Drawing.Color.Snow;
            this.About_Us.Image = global::EventApp.Properties.Resources.icons8_about_24;
            this.About_Us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_Us.Location = new System.Drawing.Point(10, 440);
            this.About_Us.Name = "About_Us";
            this.About_Us.Size = new System.Drawing.Size(155, 46);
            this.About_Us.TabIndex = 3;
            this.About_Us.Text = "About us";
            this.About_Us.UseVisualStyleBackColor = true;
            this.About_Us.Click += new System.EventHandler(this.About_Us_Click);
            this.About_Us.MouseLeave += new System.EventHandler(this.About_Us_MouseLeave);
            this.About_Us.MouseHover += new System.EventHandler(this.About_Us_MouseHover);
            // 
            // Help
            // 
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Help.ForeColor = System.Drawing.Color.Snow;
            this.Help.Image = global::EventApp.Properties.Resources.icons8_help_24;
            this.Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help.Location = new System.Drawing.Point(10, 360);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(155, 51);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            this.Help.MouseHover += new System.EventHandler(this.Help_MouseHover);
            // 
            // Create_Event
            // 
            this.Create_Event.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Create_Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Create_Event.ForeColor = System.Drawing.Color.Snow;
            this.Create_Event.Image = global::EventApp.Properties.Resources.icons8_create_24;
            this.Create_Event.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_Event.Location = new System.Drawing.Point(10, 279);
            this.Create_Event.Name = "Create_Event";
            this.Create_Event.Size = new System.Drawing.Size(155, 52);
            this.Create_Event.TabIndex = 1;
            this.Create_Event.Text = "Create Event";
            this.Create_Event.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Create_Event.UseVisualStyleBackColor = true;
            this.Create_Event.Click += new System.EventHandler(this.Create_Event_Click);
            this.Create_Event.MouseLeave += new System.EventHandler(this.Create_Event_MouseLeave);
            this.Create_Event.MouseHover += new System.EventHandler(this.Create_Event_MouseHover_1);
            // 
            // Home
            // 
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Home.ForeColor = System.Drawing.Color.Snow;
            this.Home.Image = global::EventApp.Properties.Resources.icons8_home_24;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(10, 191);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(155, 59);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Home_MouseClick);
            this.Home.MouseLeave += new System.EventHandler(this.Home_MouseLeave);
            this.Home.MouseHover += new System.EventHandler(this.Home_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.User_label);
            this.panel3.Controls.Add(this.Settings);
            this.panel3.Controls.Add(this.Search);
            this.panel3.Controls.Add(this.Logout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(165, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 79);
            this.panel3.TabIndex = 3;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_label.Location = new System.Drawing.Point(466, 31);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(0, 13);
            this.User_label.TabIndex = 3;
            // 
            // Settings
            // 
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(814, 21);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(34, 33);
            this.Settings.TabIndex = 2;
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(870, 21);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(37, 33);
            this.Search.TabIndex = 1;
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(941, 21);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(33, 33);
            this.Logout.TabIndex = 0;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button About_Us;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Create_Event;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel SidePanel;
    }
}