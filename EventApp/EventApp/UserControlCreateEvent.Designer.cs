namespace EventApp
{
    partial class UserControlCreateEvent
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
            this.description_txt = new System.Windows.Forms.TextBox();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.discard_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.picImage_box = new System.Windows.Forms.PictureBox();
            this.loadimage_btn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.location_txt = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage_box)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // description_txt
            // 
            this.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_txt.Location = new System.Drawing.Point(87, 348);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(473, 152);
            this.description_txt.TabIndex = 2;
            // 
            // title_txt
            // 
            this.title_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txt.Location = new System.Drawing.Point(87, 176);
            this.title_txt.Multiline = true;
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(473, 43);
            this.title_txt.TabIndex = 1;
            this.title_txt.Text = "\r\n  Event Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(77, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(86, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(698, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 58);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date and Time";
            // 
            // time_txt
            // 
            this.time_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_txt.Location = new System.Drawing.Point(708, 228);
            this.time_txt.Multiline = true;
            this.time_txt.Name = "time_txt";
            this.time_txt.Size = new System.Drawing.Size(482, 43);
            this.time_txt.TabIndex = 11;
            this.time_txt.Text = "Time";
            // 
            // discard_btn
            // 
            this.discard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.discard_btn.Location = new System.Drawing.Point(750, 687);
            this.discard_btn.Name = "discard_btn";
            this.discard_btn.Size = new System.Drawing.Size(169, 53);
            this.discard_btn.TabIndex = 14;
            this.discard_btn.Text = "Discard";
            this.discard_btn.UseVisualStyleBackColor = false;
            this.discard_btn.Click += new System.EventHandler(this.discard_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.save_btn.Location = new System.Drawing.Point(1021, 687);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(169, 53);
            this.save_btn.TabIndex = 15;
            this.save_btn.Text = "Save/Continue";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // picImage_box
            // 
            this.picImage_box.Location = new System.Drawing.Point(708, 320);
            this.picImage_box.Name = "picImage_box";
            this.picImage_box.Size = new System.Drawing.Size(482, 215);
            this.picImage_box.TabIndex = 16;
            this.picImage_box.TabStop = false;
            // 
            // loadimage_btn
            // 
            this.loadimage_btn.Location = new System.Drawing.Point(708, 566);
            this.loadimage_btn.Name = "loadimage_btn";
            this.loadimage_btn.Size = new System.Drawing.Size(104, 52);
            this.loadimage_btn.TabIndex = 17;
            this.loadimage_btn.Text = "Load Image";
            this.loadimage_btn.UseVisualStyleBackColor = true;
            this.loadimage_btn.Click += new System.EventHandler(this.loadimage_btn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(708, 176);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(295, 22);
            this.dateTimePicker.TabIndex = 19;
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "Attraction",
            "Camp,Trip, or Retreat",
            "Class, Training, or Workshop",
            "Concert or Performance",
            "Conference",
            "Convention",
            "Dinner or Gala",
            "Festival",
            "Game or Competition",
            "Meeting or Networking Event",
            "Party or Social Gathering",
            "Rally",
            "Tour"});
            this.type_box.Location = new System.Drawing.Point(87, 283);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(211, 24);
            this.type_box.TabIndex = 20;
            this.type_box.Text = "Type";
            // 
            // category_box
            // 
            this.category_box.FormattingEnabled = true;
            this.category_box.Items.AddRange(new object[] {
            "Business & Professional",
            "Family & Education",
            "Fashion & Beauty",
            "Film, Media & Entertainment",
            "Food & Drink",
            "Health & Wellness",
            "Home & Lifestyle",
            "Music",
            "Science & Technoology",
            "Seasocal & Holiday"});
            this.category_box.Location = new System.Drawing.Point(349, 283);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(211, 24);
            this.category_box.TabIndex = 21;
            this.category_box.Text = "Category";
            // 
            // location_txt
            // 
            this.location_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "Thessaloniki",
            "Athina",
            "Patra"});
            this.location_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.location_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.location_txt.Location = new System.Drawing.Point(87, 662);
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(436, 22);
            this.location_txt.TabIndex = 22;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.location_txt);
            this.panel.Controls.Add(this.category_box);
            this.panel.Controls.Add(this.type_box);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Controls.Add(this.loadimage_btn);
            this.panel.Controls.Add(this.picImage_box);
            this.panel.Controls.Add(this.save_btn);
            this.panel.Controls.Add(this.discard_btn);
            this.panel.Controls.Add(this.time_txt);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.title_txt);
            this.panel.Controls.Add(this.description_txt);
            this.panel.Controls.Add(this.Content);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1453, 791);
            this.panel.TabIndex = 8;
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1453, 791);
            this.Content.TabIndex = 23;
            // 
            // UserControlCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UserControlCreateEvent";
            this.Size = new System.Drawing.Size(1453, 791);
            ((System.ComponentModel.ISupportInitialize)(this.picImage_box)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.Button discard_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.PictureBox picImage_box;
        private System.Windows.Forms.Button loadimage_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.TextBox location_txt;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel Content;
    }
}
