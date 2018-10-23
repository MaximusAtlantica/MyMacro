namespace MyMacro.Forms
{
    partial class About
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
            this.lbl_About = new System.Windows.Forms.Label();
            this.link_Credit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_About
            // 
            this.lbl_About.AutoSize = true;
            this.lbl_About.Location = new System.Drawing.Point(12, 9);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(51, 13);
            this.lbl_About.TabIndex = 0;
            this.lbl_About.Text = "lbl_About";
            // 
            // link_Credit
            // 
            this.link_Credit.AutoSize = true;
            this.link_Credit.Location = new System.Drawing.Point(52, 128);
            this.link_Credit.Name = "link_Credit";
            this.link_Credit.Size = new System.Drawing.Size(38, 13);
            this.link_Credit.TabIndex = 1;
            this.link_Credit.TabStop = true;
            this.link_Credit.Text = "Github";
            this.link_Credit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Credit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit : ";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_Credit);
            this.Controls.Add(this.lbl_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Shown += new System.EventHandler(this.About_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_About;
        private System.Windows.Forms.LinkLabel link_Credit;
        private System.Windows.Forms.Label label1;
    }
}