using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Sklok
{
    public partial class BaseScreen : Form
    {
        public BaseScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            Forms.LockScreen bckgrnd = new Sklok.Forms.LockScreen();
            this.AddOwnedForm(bckgrnd);
            this.TopMost = false;
            if (!(bckgrnd.Visible))
            {
                bckgrnd.TopMost = true;
                bckgrnd.Show();
            }
            else
            {
                bckgrnd.Dispose();
            }
        }

        ~BaseScreen()
        {
            notiCon.Dispose();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passChange_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.gothrough.ToString() == oldPassword.Text.ToString())
            {
                if (newPassword1.Text.ToString() == newPassword2.Text.ToString())
                    Properties.Settings.Default.gothrough = newPassword2.Text.ToString();
                else
                {
                    MessageBox.Show("New Passwords must match.", "Unmatched Password");
                    oldPassword.Text = newPassword1.Text = newPassword2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Invalid Password Entered", "ERROR");
                oldPassword.Text = newPassword1.Text = newPassword2.Text = "";
            }
        }
    }
}
