namespace Sklok
{
    partial class BaseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseScreen));
            this.passEnter = new System.Windows.Forms.Button();
            this.notiCon = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Show = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLock = new System.Windows.Forms.Button();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // passEnter
            // 
            this.passEnter.Location = new System.Drawing.Point(580, 449);
            this.passEnter.Name = "passEnter";
            this.passEnter.Size = new System.Drawing.Size(133, 77);
            this.passEnter.TabIndex = 0;
            this.passEnter.Text = "Close Me";
            this.passEnter.UseVisualStyleBackColor = true;
            this.passEnter.Click += new System.EventHandler(this.passEnter_Click);
            // 
            // notiCon
            // 
            this.notiCon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notiCon.BalloonTipText = "Active";
            this.notiCon.BalloonTipTitle = "Skolk Status:";
            this.notiCon.ContextMenuStrip = this.rightClickMenu;
            this.notiCon.Icon = ((System.Drawing.Icon)(resources.GetObject("notiCon.Icon")));
            this.notiCon.Text = "Sklok";
            this.notiCon.Visible = true;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Show,
            this.Exit});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(104, 48);
            this.rightClickMenu.Text = "Right Click";
            // 
            // Show
            // 
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(103, 22);
            this.Show.Text = "Show";
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(103, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(377, 236);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(114, 45);
            this.buttonLock.TabIndex = 1;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            // 
            // BaseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 290);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.passEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseScreen";
            this.Opacity = 0.75;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passEnter;
        private System.Windows.Forms.NotifyIcon notiCon;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem Show;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button buttonLock;
    }
}

