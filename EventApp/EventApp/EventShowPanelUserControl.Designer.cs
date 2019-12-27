namespace EventApp
{
    partial class EventShowPanelUserControl
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.titleTxt = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.Label();
            this.dayTxt = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(159, 92);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Location = new System.Drawing.Point(5, 108);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(35, 13);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "label1";
            // 
            // locationTxt
            // 
            this.locationTxt.AutoSize = true;
            this.locationTxt.Location = new System.Drawing.Point(5, 136);
            this.locationTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(35, 13);
            this.locationTxt.TabIndex = 2;
            this.locationTxt.Text = "label2";
            // 
            // dayTxt
            // 
            this.dayTxt.AutoSize = true;
            this.dayTxt.Location = new System.Drawing.Point(5, 169);
            this.dayTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayTxt.Name = "dayTxt";
            this.dayTxt.Size = new System.Drawing.Size(35, 13);
            this.dayTxt.TabIndex = 3;
            this.dayTxt.Text = "label3";
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Location = new System.Drawing.Point(5, 194);
            this.timeTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(35, 13);
            this.timeTxt.TabIndex = 4;
            this.timeTxt.Text = "label4";
            // 
            // EventShowPanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.dayTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventShowPanelUserControl";
            this.Size = new System.Drawing.Size(159, 223);
            this.Click += new System.EventHandler(this.EventShowPanelUserControl_Click);
            this.MouseEnter += new System.EventHandler(this.EventShowPanelUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EventShowPanelUserControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Label locationTxt;
        private System.Windows.Forms.Label dayTxt;
        private System.Windows.Forms.Label timeTxt;
    }
}
