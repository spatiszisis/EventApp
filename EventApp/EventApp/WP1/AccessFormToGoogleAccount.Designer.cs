namespace EventApp
{
    partial class AccessFormToGoogleAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.googleAccessLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(85, 195);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(357, 22);
            this.emailtxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(85, 317);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(357, 22);
            this.passwordTxt.TabIndex = 3;
            // 
            // googleAccessLabel
            // 
            this.googleAccessLabel.AutoSize = true;
            this.googleAccessLabel.BackColor = System.Drawing.Color.White;
            this.googleAccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.googleAccessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.googleAccessLabel.Location = new System.Drawing.Point(75, 39);
            this.googleAccessLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.googleAccessLabel.Name = "googleAccessLabel";
            this.googleAccessLabel.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.googleAccessLabel.Size = new System.Drawing.Size(367, 60);
            this.googleAccessLabel.TabIndex = 4;
            this.googleAccessLabel.Text = "Google Access";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.button1.Location = new System.Drawing.Point(157, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 125);
            this.panel1.TabIndex = 6;
            // 
            // AccessFormToGoogleAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(499, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.googleAccessLabel);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessFormToGoogleAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessFormToGoogleAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label googleAccessLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}