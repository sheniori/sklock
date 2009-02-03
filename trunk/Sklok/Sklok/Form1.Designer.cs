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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuTabs = new System.Windows.Forms.TabControl();
            this.menuMain = new System.Windows.Forms.TabPage();
            this.menuPass = new System.Windows.Forms.TabPage();
            this.buttonLock = new System.Windows.Forms.Button();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword1 = new System.Windows.Forms.TextBox();
            this.newPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passChange = new System.Windows.Forms.Button();
            this.rightClickMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuTabs.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.menuPass.SuspendLayout();
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = false;
            this.statLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.statLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.statLabel.Name = "statLabel";
            this.statLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.statLabel.Size = new System.Drawing.Size(200, 17);
            this.statLabel.Text = "Lock Status: Ready";
            this.statLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuTabs
            // 
            this.menuTabs.Controls.Add(this.menuMain);
            this.menuTabs.Controls.Add(this.menuPass);
            this.menuTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTabs.HotTrack = true;
            this.menuTabs.Location = new System.Drawing.Point(0, 0);
            this.menuTabs.Name = "menuTabs";
            this.menuTabs.SelectedIndex = 0;
            this.menuTabs.Size = new System.Drawing.Size(492, 264);
            this.menuTabs.TabIndex = 4;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.SteelBlue;
            this.menuMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuMain.Controls.Add(this.buttonLock);
            this.menuMain.Location = new System.Drawing.Point(4, 22);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(3);
            this.menuMain.Size = new System.Drawing.Size(484, 238);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "Main Menu";
            // 
            // menuPass
            // 
            this.menuPass.BackColor = System.Drawing.Color.SteelBlue;
            this.menuPass.Controls.Add(this.passChange);
            this.menuPass.Controls.Add(this.label3);
            this.menuPass.Controls.Add(this.label2);
            this.menuPass.Controls.Add(this.label1);
            this.menuPass.Controls.Add(this.newPassword2);
            this.menuPass.Controls.Add(this.newPassword1);
            this.menuPass.Controls.Add(this.oldPassword);
            this.menuPass.Location = new System.Drawing.Point(4, 22);
            this.menuPass.Name = "menuPass";
            this.menuPass.Padding = new System.Windows.Forms.Padding(3);
            this.menuPass.Size = new System.Drawing.Size(484, 238);
            this.menuPass.TabIndex = 1;
            this.menuPass.Text = "Password Settings";
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(362, 187);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(114, 45);
            this.buttonLock.TabIndex = 2;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(235, 18);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '¤';
            this.oldPassword.Size = new System.Drawing.Size(224, 20);
            this.oldPassword.TabIndex = 0;
            this.oldPassword.WordWrap = false;
            // 
            // newPassword1
            // 
            this.newPassword1.Location = new System.Drawing.Point(235, 44);
            this.newPassword1.Name = "newPassword1";
            this.newPassword1.PasswordChar = '¤';
            this.newPassword1.Size = new System.Drawing.Size(224, 20);
            this.newPassword1.TabIndex = 1;
            // 
            // newPassword2
            // 
            this.newPassword2.Location = new System.Drawing.Point(235, 70);
            this.newPassword2.Name = "newPassword2";
            this.newPassword2.PasswordChar = '¤';
            this.newPassword2.Size = new System.Drawing.Size(224, 20);
            this.newPassword2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-Enter New Password";
            // 
            // passChange
            // 
            this.passChange.Location = new System.Drawing.Point(176, 123);
            this.passChange.Name = "passChange";
            this.passChange.Size = new System.Drawing.Size(117, 36);
            this.passChange.TabIndex = 6;
            this.passChange.Text = "Change Password";
            this.passChange.UseVisualStyleBackColor = true;
            this.passChange.Click += new System.EventHandler(this.passChange_Click);
            // 
            // BaseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 286);
            this.Controls.Add(this.menuTabs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.passEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseScreen";
            this.Opacity = 0.75;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rightClickMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuTabs.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuPass.ResumeLayout(false);
            this.menuPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passEnter;
        private System.Windows.Forms.NotifyIcon notiCon;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem Show;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.TabControl menuTabs;
        private System.Windows.Forms.TabPage menuMain;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.TabPage menuPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPassword2;
        private System.Windows.Forms.TextBox newPassword1;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Button passChange;
    }
}

