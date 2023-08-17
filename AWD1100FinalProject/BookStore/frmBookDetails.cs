using FinalProjectLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmBookDetails : Form
    {
        public frmBookDetails()
        {
            InitializeComponent();
        }

        private void btnSplashPage_Click(object sender, EventArgs e)
        {
            LoadSplashPage();
        }

        private void splashPageMenuItem_Click(object sender, EventArgs e)
        {
            LoadSplashPage();
        }

        private void LoadSplashPage()
        {
            frmSplashPage splash = new frmSplashPage();

            splash.Show();
            this.Close();
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            LoadHelpForm();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            LoadHelpForm();
        }

        private void LoadHelpForm()
        {
            frmHelp help = new frmHelp();

            help.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit.ExitProgram();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Exit.ExitProgram();
        }
    }
}
