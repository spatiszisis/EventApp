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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlShowEvents));
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 515);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1453, 276);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // closeBack
            // 
            this.closeBack.FlatAppearance.BorderSize = 0;
            this.closeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBack.Image = ((System.Drawing.Image)(resources.GetObject("closeBack.Image")));
            this.closeBack.Location = new System.Drawing.Point(3, 3);
            this.closeBack.Name = "closeBack";
            this.closeBack.Size = new System.Drawing.Size(75, 58);
            this.closeBack.TabIndex = 26;
            this.closeBack.UseVisualStyleBackColor = true;
            this.closeBack.Click += new System.EventHandler(this.closeBack_Click);
            // 
            // UserControlShowEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.closeBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "UserControlShowEvents";
            this.Size = new System.Drawing.Size(1453, 791);
            this.Load += new System.EventHandler(this.UserControlShowEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button closeBack;
    }
}
