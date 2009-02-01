using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
