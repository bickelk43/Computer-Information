namespace ComputerInformation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loggedInUserLabel = new System.Windows.Forms.Label();
            this.passwordExpiresLabel = new System.Windows.Forms.Label();
            this.passwordExpiresInfoLabel = new System.Windows.Forms.Label();
            this.loggedInInfoLabel = new System.Windows.Forms.Label();
            this.ipAddressInfoLabel = new System.Windows.Forms.Label();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.computerNameInfoLabel = new System.Windows.Forms.Label();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.didInfoLabel = new System.Windows.Forms.Label();
            this.extensionInfoLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.didLabel = new System.Windows.Forms.Label();
            this.computerInfoNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggedInUserLabel
            // 
            this.loggedInUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedInUserLabel.AutoSize = true;
            this.loggedInUserLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loggedInUserLabel.Location = new System.Drawing.Point(205, 9);
            this.loggedInUserLabel.Name = "loggedInUserLabel";
            this.loggedInUserLabel.Size = new System.Drawing.Size(262, 24);
            this.loggedInUserLabel.TabIndex = 0;
            this.loggedInUserLabel.Text = "[----Logged In Username----]";
            this.loggedInUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordExpiresLabel
            // 
            this.passwordExpiresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordExpiresLabel.AutoSize = true;
            this.passwordExpiresLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordExpiresLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordExpiresLabel.Location = new System.Drawing.Point(212, 33);
            this.passwordExpiresLabel.Name = "passwordExpiresLabel";
            this.passwordExpiresLabel.Size = new System.Drawing.Size(255, 24);
            this.passwordExpiresLabel.TabIndex = 1;
            this.passwordExpiresLabel.Text = "[--Password Expires Date--]";
            this.passwordExpiresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordExpiresInfoLabel
            // 
            this.passwordExpiresInfoLabel.AutoSize = true;
            this.passwordExpiresInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordExpiresInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordExpiresInfoLabel.Location = new System.Drawing.Point(12, 33);
            this.passwordExpiresInfoLabel.Name = "passwordExpiresInfoLabel";
            this.passwordExpiresInfoLabel.Size = new System.Drawing.Size(171, 24);
            this.passwordExpiresInfoLabel.TabIndex = 3;
            this.passwordExpiresInfoLabel.Text = "Password Expires:";
            // 
            // loggedInInfoLabel
            // 
            this.loggedInInfoLabel.AutoSize = true;
            this.loggedInInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loggedInInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.loggedInInfoLabel.Name = "loggedInInfoLabel";
            this.loggedInInfoLabel.Size = new System.Drawing.Size(103, 24);
            this.loggedInInfoLabel.TabIndex = 4;
            this.loggedInInfoLabel.Text = "Logged In:";
            // 
            // ipAddressInfoLabel
            // 
            this.ipAddressInfoLabel.AutoSize = true;
            this.ipAddressInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ipAddressInfoLabel.Location = new System.Drawing.Point(12, 57);
            this.ipAddressInfoLabel.Name = "ipAddressInfoLabel";
            this.ipAddressInfoLabel.Size = new System.Drawing.Size(107, 24);
            this.ipAddressInfoLabel.TabIndex = 6;
            this.ipAddressInfoLabel.Text = "IP Address:";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ipAddressLabel.Location = new System.Drawing.Point(282, 57);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(185, 24);
            this.ipAddressLabel.TabIndex = 5;
            this.ipAddressLabel.Text = "[IP Address Display]";
            this.ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // computerNameInfoLabel
            // 
            this.computerNameInfoLabel.AutoSize = true;
            this.computerNameInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.computerNameInfoLabel.Location = new System.Drawing.Point(12, 81);
            this.computerNameInfoLabel.Name = "computerNameInfoLabel";
            this.computerNameInfoLabel.Size = new System.Drawing.Size(161, 24);
            this.computerNameInfoLabel.TabIndex = 8;
            this.computerNameInfoLabel.Text = "Computer Name:";
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.computerNameLabel.Location = new System.Drawing.Point(197, 81);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(270, 24);
            this.computerNameLabel.TabIndex = 7;
            this.computerNameLabel.Text = "[--Computer Domain Name--]";
            this.computerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // didInfoLabel
            // 
            this.didInfoLabel.AutoSize = true;
            this.didInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.didInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.didInfoLabel.Location = new System.Drawing.Point(12, 105);
            this.didInfoLabel.Name = "didInfoLabel";
            this.didInfoLabel.Size = new System.Drawing.Size(133, 24);
            this.didInfoLabel.TabIndex = 10;
            this.didInfoLabel.Text = "Direct Phone:";
            // 
            // extensionInfoLabel
            // 
            this.extensionInfoLabel.AutoSize = true;
            this.extensionInfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.extensionInfoLabel.Location = new System.Drawing.Point(12, 129);
            this.extensionInfoLabel.Name = "extensionInfoLabel";
            this.extensionInfoLabel.Size = new System.Drawing.Size(105, 24);
            this.extensionInfoLabel.TabIndex = 12;
            this.extensionInfoLabel.Text = "Extension:";
            // 
            // extensionLabel
            // 
            this.extensionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.extensionLabel.Location = new System.Drawing.Point(286, 129);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(181, 24);
            this.extensionLabel.TabIndex = 11;
            this.extensionLabel.Text = "[Phone Extension]";
            this.extensionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // didLabel
            // 
            this.didLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.didLabel.AutoSize = true;
            this.didLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.didLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.didLabel.Location = new System.Drawing.Point(204, 105);
            this.didLabel.Name = "didLabel";
            this.didLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.didLabel.Size = new System.Drawing.Size(263, 24);
            this.didLabel.TabIndex = 13;
            this.didLabel.Text = "[Direct Line Phone Number]";
            this.didLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // computerInfoNotifyIcon
            // 
            this.computerInfoNotifyIcon.ContextMenuStrip = this.trayContextMenuStrip;
            this.computerInfoNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("computerInfoNotifyIcon.Icon")));
            this.computerInfoNotifyIcon.Text = "Computer Information";
            this.computerInfoNotifyIcon.Visible = true;
            this.computerInfoNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.computerInfoNotifyIcon_MouseDoubleClick);
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(134, 26);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(479, 168);
            this.Controls.Add(this.didLabel);
            this.Controls.Add(this.extensionInfoLabel);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.didInfoLabel);
            this.Controls.Add(this.computerNameInfoLabel);
            this.Controls.Add(this.computerNameLabel);
            this.Controls.Add(this.ipAddressInfoLabel);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.loggedInInfoLabel);
            this.Controls.Add(this.passwordExpiresInfoLabel);
            this.Controls.Add(this.passwordExpiresLabel);
            this.Controls.Add(this.loggedInUserLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trayContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedInUserLabel;
        private System.Windows.Forms.Label passwordExpiresLabel;
        private System.Windows.Forms.Label passwordExpiresInfoLabel;
        private System.Windows.Forms.Label loggedInInfoLabel;
        private System.Windows.Forms.Label ipAddressInfoLabel;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label computerNameInfoLabel;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Label didInfoLabel;
        private System.Windows.Forms.Label extensionInfoLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Label didLabel;
        private System.Windows.Forms.NotifyIcon computerInfoNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
    }
}

