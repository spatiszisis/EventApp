namespace EventApp
{
    partial class UserControlFavList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelFav = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(91, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 3);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(79, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 58);
            this.label1.TabIndex = 18;
            this.label1.Text = "Your favorite events";
            // 
            // flowLayoutPanelFav
            // 
            this.flowLayoutPanelFav.AutoScroll = true;
            this.flowLayoutPanelFav.Location = new System.Drawing.Point(3, 257);
            this.flowLayoutPanelFav.Name = "flowLayoutPanelFav";
            this.flowLayoutPanelFav.Size = new System.Drawing.Size(1426, 276);
            this.flowLayoutPanelFav.TabIndex = 28;
            // 
            // UserControlFavList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelFav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlFavList";
            this.Size = new System.Drawing.Size(1453, 791);
            this.Load += new System.EventHandler(this.UserControlFavList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFav;
    }
}
