using FinalProjectLibrary;
using System;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            string info = "";

            info += $"Hello and welcome to the help page!\n\n";
            info += $"If you're here, that means you probably need some help.\nOr you're testing my program. Either way, I'm here to provide that help!\n\n";
            info += $"If you have an ISBN number, go ahead and type either part of it or all of it into the search bar on the left.\n";
            info += $"Or! If you'd rather search by the book title, go ahead and type either part of it or all of it into that same search bar.\n";
            info += $"Otherwise, you can seach by the author in the dropdown box to the right of the seach bar.\n";
            info += $"Once you have the proper information, hit search or enter! Your results should show below!\n\n";
            info += $"If you want some more information, or if you want to review the book, hit the details button to the right of the results box.\n";
            info += $"From there, you can see some information about the book and past reviews! (If there are any!)\n";
            info += $"If you'd like to leave your own review, type your thoughts into the review box and hit submit!\n";
            info += $"Your review should show with the past reviews!";

            lblHelpInfo.Text = info;
        }

        private void btnSplashPage_Click(object sender, EventArgs e)
        {
            LoadSplashPage();
        }

        private void splashPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSplashPage();
        }

        private void LoadSplashPage()
        {
            frmSplashPage splash = new frmSplashPage();

            splash.Show();
            this.Close();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            LoadBookSearch();
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBookSearch();
        }

        private void LoadBookSearch()
        {
            frmBookSearch bookSearch = new frmBookSearch();

            bookSearch.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit.ExitProgram();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.ExitProgram();
        }
    }
}
