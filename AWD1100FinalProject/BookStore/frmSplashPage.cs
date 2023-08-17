using FinalProjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmSplashPage : Form
    {
        public frmSplashPage()
        {
            InitializeComponent();
        }

        private void frmBookStore_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome to my book store!\nHome to the books of some of the world's most famous authors!";
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            LoadBookSearch();
        }

        private void bookSearchMenuItem_Click(object sender, EventArgs e)
        {
            LoadBookSearch();
        }

        private void LoadBookSearch()
        {
            frmBookSearch bookSearch = new frmBookSearch();

            bookSearch.Show();
            this.Hide();
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
