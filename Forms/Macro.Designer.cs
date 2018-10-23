namespace MyMacro.Forms
{
    partial class Macro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Macro));
            this.panel_Macro = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_OnOff = new System.Windows.Forms.Label();
            this.lbl_Pid = new System.Windows.Forms.Label();
            this.lbl_About = new System.Windows.Forms.Label();
            this.panel_Macro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Macro
            // 
            this.panel_Macro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_Macro.Controls.Add(this.lbl_About);
            this.panel_Macro.Controls.Add(this.lbl_Exit);
            this.panel_Macro.Controls.Add(this.lbl_OnOff);
            this.panel_Macro.Controls.Add(this.lbl_Pid);
            this.panel_Macro.Location = new System.Drawing.Point(0, 0);
            this.panel_Macro.Name = "panel_Macro";
            this.panel_Macro.Size = new System.Drawing.Size(220, 20);
            this.panel_Macro.TabIndex = 5;
            this.panel_Macro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Macro_MouseDown);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Image = global::MyMacro.Properties.Resources.exit;
            this.lbl_Exit.Location = new System.Drawing.Point(200, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(20, 20);
            this.lbl_Exit.TabIndex = 7;
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // lbl_OnOff
            // 
            this.lbl_OnOff.Image = global::MyMacro.Properties.Resources.stop;
            this.lbl_OnOff.Location = new System.Drawing.Point(0, 0);
            this.lbl_OnOff.Name = "lbl_OnOff";
            this.lbl_OnOff.Size = new System.Drawing.Size(20, 20);
            this.lbl_OnOff.TabIndex = 6;
            this.lbl_OnOff.Tag = "Start";
            this.lbl_OnOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Macro_MouseDown);
            // 
            // lbl_Pid
            // 
            this.lbl_Pid.AutoSize = true;
            this.lbl_Pid.Location = new System.Drawing.Point(20, 3);
            this.lbl_Pid.Name = "lbl_Pid";
            this.lbl_Pid.Size = new System.Drawing.Size(156, 13);
            this.lbl_Pid.TabIndex = 5;
            this.lbl_Pid.Text = "F11 - Pilih Target / F12 - On Off";
            this.lbl_Pid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Macro_MouseDown);
            // 
            // lbl_About
            // 
            this.lbl_About.Image = global::MyMacro.Properties.Resources.ask;
            this.lbl_About.Location = new System.Drawing.Point(180, 0);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(20, 20);
            this.lbl_About.TabIndex = 8;
            this.lbl_About.Click += new System.EventHandler(this.lbl_About_Click);
            // 
            // Macro
            // 
            this.ClientSize = new System.Drawing.Size(220, 50);
            this.Controls.Add(this.panel_Macro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Macro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Macro";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Macro_Shown);
            this.panel_Macro.ResumeLayout(false);
            this.panel_Macro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Macro;
        private System.Windows.Forms.Label lbl_Pid;
        private System.Windows.Forms.Label lbl_OnOff;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_About;

    }
}