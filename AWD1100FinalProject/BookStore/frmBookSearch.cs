using FinalProjectLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmBookSearch : Form
    {
        public frmBookSearch()
        {
            InitializeComponent();
        }

        private List<Book> books;

        //private List<Book> _books;
        //private List<String> _authors;
        //private List<Book> _searchResults;
        //private int _pageNum;

        string[] Authors =
        {
            "Select an author",
            "Stephen King",
            "J.K. Rowling",
            "Suzanne Collins"
        };

        string[] Images =
        {
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingDeathlyHallows.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingHalfBloodPrince.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingHPChamberofSecrets.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingHPGobletofFire.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingHPPrisonerofAzkaban.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingHPSorcerersStone.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\JKRowlingOrderofthePhoenix.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingDoctorSleep.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingGeraldsGame.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingGreenMile.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingIntheTallGrass.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingIT.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingPetSematary.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingSalemsLot.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingTheInstitute.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingTheMist.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\StephenKingTheShining.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\SuzanneCollinsCatchingFire.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\SuzanneCollinsHungerGames.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\SuzanneCollinsMockingJay.jpg",
            @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\Images\SuzanneCollinsSongbirdsandSnakes.jpg"
        };

        private void lblSearch_Click(object sender, EventArgs e)
        {
            bool valid = ValidateSearchCriteria();

            if (valid && txtSearchBy.Text != "")
            {
                Book foundBook = SearchbyTitleISBN(books);

                ShowResults();
            }
            else if (valid && txtSearchBy.Text == "")
            {
               SearchbyAuthor();
            }
        }

        private Book SearchbyTitleISBN(List<Book> book)
        {
            string bookTitle = txtSearchBy.Text.Trim();
            IEnumerable<Book> filteredBooks = null;

            return book.FirstOrDefault(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));
        }

        private void SearchbyAuthor()
        {
            listBooks.Items.Clear();

            string author = cmbAuthors.SelectedIndex.ToString();
            IEnumerable<Book> filteredBooks = null;

            if (author == "Stephen King")
            {
                filteredBooks =
                    from book in books
                    where book.Author == "Stephen King"
                    orderby book.Title
                    select book;
            }
            else if (author == "J.K. Rowling")
            {
                filteredBooks =
                   from book in books
                   where book.Author == "J.K. Rowling"
                   orderby book.Title
                   select book;
            }
            else if (author == "Suzanne Collins")
            {
                filteredBooks =
                   from book in books
                   where book.Author == "Suzanne Collins"
                   orderby book.Title
                   select book;
            }

            ShowResults();
        }

        private void ShowResults()
        {
            foreach (Book book in books)
            {
                listBooks.Items.Add(book.GetDisplayText());
            }
        }

        private bool ValidateSearchCriteria()
        {
            bool valid = true;

            if ((txtSearchBy.Text == "") && (cmbAuthors.SelectedIndex == 0))
            {
                ShowMessage("Enter an ISBN or book title in the search bar\nOr choose an author from the dropdown.", "Error!");
                valid = false;
            }
            else if ((txtSearchBy.Text != "") && (cmbAuthors.SelectedIndex > 0))
            {
                ShowMessage("Please only search by ISBN, book title, or author", "Error!");
                txtSearchBy.Text = "";
                cmbAuthors.SelectedIndex = 0;
                valid = false;
            }

            return valid;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            LoadDetailsPage();
        }

        private void LoadDetailsPage()
        {
            //listBooks.SelectedIndex = new frmBookDetails();
        }

        private void spalshPageMenuItem_Click(object sender, EventArgs e)
        {
            LoadSplashPage();
        }

        private void LoadSplashPage()
        {
            frmSplashPage splash = new frmSplashPage();

            splash.Show();
            this.Close();
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

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Exit.ExitProgram();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit.ExitProgram();
        }

        private void frmBookSearch_Load(object sender, EventArgs e)
        {
            string dir = @"C:\Users\rebek\Desktop\AWS1100RebekahHendersonFinalProject\AWD1100FinalProject\BookStore\";
            string path = dir + "books.txt";

            //load author dropdown list
            for (int a = 0; a < Authors.Length; a++) //foreach (string a in Authors)
            {
                cmbAuthors.Items.Add(Authors[a]);    // cmbAuthors.Items.Add(a)
            }
            cmbAuthors.SelectedIndex = 0;

            //read books file
            books = ReadBookFile(path);
        }

        private List<Book> ReadBookFile(string fileName)
        {
            List<Book> books = new List<Book>();

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 4)
                    {
                        Book book = new Book
                        {
                            Isbn        = parts[0],
                            Author      = parts[1],
                            Title       = parts[2],
                            ReleaseYear = int.Parse(parts[3])
                        };

                        books.Add(book);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return books;
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
