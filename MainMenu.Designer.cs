namespace Gloomi
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLinkLampen = new System.Windows.Forms.Button();
            this.labelnotif = new System.Windows.Forms.Label();
            this.panelNotif = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // buttonLinkLampen
            // 
            this.buttonLinkLampen.Location = new System.Drawing.Point(6, 24);
            this.buttonLinkLampen.Name = "buttonLinkLampen";
            this.buttonLinkLampen.Size = new System.Drawing.Size(389, 32);
            this.buttonLinkLampen.TabIndex = 1;
            this.buttonLinkLampen.Text = "Lampen";
            this.buttonLinkLampen.UseVisualStyleBackColor = true;
            this.buttonLinkLampen.Click += new System.EventHandler(this.buttonLinkLampen_Click);
            // 
            // labelnotif
            // 
            this.labelnotif.AutoSize = true;
            this.labelnotif.Location = new System.Drawing.Point(398, 8);
            this.labelnotif.Name = "labelnotif";
            this.labelnotif.Size = new System.Drawing.Size(59, 13);
            this.labelnotif.TabIndex = 2;
            this.labelnotif.Text = "Notificaties";
            // 
            // panelNotif
            // 
            this.panelNotif.AutoScroll = true;
            this.panelNotif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNotif.Location = new System.Drawing.Point(401, 24);
            this.panelNotif.Name = "panelNotif";
            this.panelNotif.Size = new System.Drawing.Size(396, 395);
            this.panelNotif.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelnotif);
            this.panelMain.Controls.Add(this.panelNotif);
            this.panelMain.Controls.Add(this.buttonLinkLampen);
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 422);
            this.panelMain.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.Button buttonLinkLampen;
        private System.Windows.Forms.Label labelnotif;
        private System.Windows.Forms.Panel panelNotif;
        private System.Windows.Forms.Panel panelMain;
    }
}

