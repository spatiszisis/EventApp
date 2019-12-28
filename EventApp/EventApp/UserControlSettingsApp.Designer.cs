namespace EventApp
{
    partial class UserControlSettingsApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.onvalue = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxchangeborderstyleform = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(96, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 3);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(86, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(96, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dark Mode: ";
            // 
            // onvalue
            // 
            this.onvalue.Location = new System.Drawing.Point(286, 256);
            this.onvalue.Name = "onvalue";
            this.onvalue.Size = new System.Drawing.Size(18, 31);
            this.onvalue.TabIndex = 19;
            this.onvalue.UseVisualStyleBackColor = true;
            this.onvalue.CheckedChanged += new System.EventHandler(this.onvalue_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(91, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Change the Borderformstyle: ";
            // 
            // checkboxchangeborderstyleform
            // 
            this.checkboxchangeborderstyleform.Location = new System.Drawing.Point(409, 334);
            this.checkboxchangeborderstyleform.Name = "checkboxchangeborderstyleform";
            this.checkboxchangeborderstyleform.Size = new System.Drawing.Size(18, 31);
            this.checkboxchangeborderstyleform.TabIndex = 21;
            this.checkboxchangeborderstyleform.UseVisualStyleBackColor = true;
            this.checkboxchangeborderstyleform.CheckedChanged += new System.EventHandler(this.checkboxchangeborderstyleform_CheckedChanged);
            // 
            // UserControlSettingsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.checkboxchangeborderstyleform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.onvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlSettingsApp";
            this.Size = new System.Drawing.Size(1453, 791);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox onvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxchangeborderstyleform;
    }
}
