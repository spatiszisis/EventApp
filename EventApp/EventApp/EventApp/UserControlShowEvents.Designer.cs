namespace EventApp
{
    partial class UserControlShowEvents
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
            this.dayTxt = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.Label();
            this.moodTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayTxt
            // 
            this.dayTxt.AutoSize = true;
            this.dayTxt.Location = new System.Drawing.Point(275, 181);
            this.dayTxt.Name = "dayTxt";
            this.dayTxt.Size = new System.Drawing.Size(24, 17);
            this.dayTxt.TabIndex = 0;
            this.dayTxt.Text = "....";
            // 
            // cityTxt
            // 
            this.cityTxt.AutoSize = true;
            this.cityTxt.Location = new System.Drawing.Point(275, 246);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(24, 17);
            this.cityTxt.TabIndex = 1;
            this.cityTxt.Text = "....";
            // 
            // moodTxt
            // 
            this.moodTxt.AutoSize = true;
            this.moodTxt.Location = new System.Drawing.Point(275, 306);
            this.moodTxt.Name = "moodTxt";
            this.moodTxt.Size = new System.Drawing.Size(24, 17);
            this.moodTxt.TabIndex = 2;
            this.moodTxt.Text = "....";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(71, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 58);
            this.label2.TabIndex = 24;
            this.label2.Text = "Events";
            // 
            // UserControlShowEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moodTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.dayTxt);
            this.Name = "UserControlShowEvents";
            this.Size = new System.Drawing.Size(1453, 791);
            this.Load += new System.EventHandler(this.UserControlShowEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayTxt;
        private System.Windows.Forms.Label cityTxt;
        private System.Windows.Forms.Label moodTxt;
        private System.Windows.Forms.Label label2;
    }
}
