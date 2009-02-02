using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace Sklok.Forms
{
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width + 10;
            this.Height = Screen.PrimaryScreen.Bounds.Height + 10;
            this.Opacity = 50 ;
            this.Location = new Point(0, 0);
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            //The following is a test function.
            //System.Timers.Timer countdown = new System.Timers.Timer(100);
            //countdown.Elapsed += new ElapsedEventHandler(OnTimer);
            //countdown.Interval = 5000;
            //countdown.Enabled = true;
        }

        private void OnTimer(Object source, ElapsedEventArgs e)
        {
            BaseScreen.ActiveForm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
