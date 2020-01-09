﻿namespace EventApp
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
            this.timeTxt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(212, 113);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Location = new System.Drawing.Point(7, 133);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(46, 17);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "label1";
            // 
            // locationTxt
            // 
            this.locationTxt.AutoSize = true;
            this.locationTxt.Location = new System.Drawing.Point(7, 166);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(46, 17);
            this.locationTxt.TabIndex = 2;
            this.locationTxt.Text = "label2";
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Location = new System.Drawing.Point(7, 237);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(46, 17);
            this.timeTxt.TabIndex = 4;
            this.timeTxt.Text = "label4";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // EventShowPanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventShowPanelUserControl";
            this.Size = new System.Drawing.Size(212, 274);
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
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
