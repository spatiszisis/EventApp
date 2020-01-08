namespace EventApp
{
    partial class UserControlΗοme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlΗοme));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EventApp.Properties.Resources._67091909_420668218790060_6866743294223712256_n;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1453, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.categoryCombo);
            this.panel1.Controls.Add(this.locationCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(869, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 377);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(315, 281);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 81);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(46, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "And I\'m in the mood for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "In";
            // 
            // categoryCombo
            // 
            this.categoryCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.categoryCombo.ForeColor = System.Drawing.Color.Gray;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Anything",
            "All Events",
            "Concerts",
            "Comedy",
            "Education",
            "Festival",
            "Food",
            "Galleries",
            "Health",
            "Holiday",
            "Movies",
            "Museums",
            "Networking",
            "Politics",
            "Technology",
            "Other"});
            this.categoryCombo.Location = new System.Drawing.Point(46, 242);
            this.categoryCombo.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(241, 32);
            this.categoryCombo.TabIndex = 3;
            this.categoryCombo.Text = "Anything";
            // 
            // locationCombo
            // 
            this.locationCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.locationCombo.ForeColor = System.Drawing.Color.Gray;
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Items.AddRange(new object[] {
            "Thessaloniki",
            "Athens",
            "Patra",
            "Larisa",
            "Ioannina",
            "Volos",
            "Herakleion",
            "Kavala",
            "Giannena",
            "Aleksandroupoli"});
            this.locationCombo.Location = new System.Drawing.Point(46, 163);
            this.locationCombo.Margin = new System.Windows.Forms.Padding(4);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(241, 32);
            this.locationCombo.TabIndex = 2;
            this.locationCombo.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "I want to go out";
            // 
            // UserControlΗοme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlΗοme";
            this.Size = new System.Drawing.Size(1453, 785);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
