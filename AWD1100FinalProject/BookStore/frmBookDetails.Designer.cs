namespace BookStore
{
    partial class frmBookDetails
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
            this.picbxBookCover = new System.Windows.Forms.PictureBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblByAuthor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splashPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSplashPage = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBookCover)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbxBookCover
            // 
            this.picbxBookCover.Location = new System.Drawing.Point(12, 41);
            this.picbxBookCover.Name = "picbxBookCover";
            this.picbxBookCover.Size = new System.Drawing.Size(155, 233);
            this.picbxBookCover.TabIndex = 0;
            this.picbxBookCover.TabStop = false;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBookTitle.Location = new System.Drawing.Point(192, 41);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(156, 25);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Book Title (year)";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblISBN.Location = new System.Drawing.Point(193, 85);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(55, 20);
            this.lblISBN.TabIndex = 3;
            this.lblISBN.Text = "ISBN: ";
            // 
            // lblByAuthor
            // 
            this.lblByAuthor.AutoSize = true;
            this.lblByAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblByAuthor.Location = new System.Drawing.Point(193, 121);
            this.lblByAuthor.Name = "lblByAuthor";
            this.lblByAuthor.Size = new System.Drawing.Size(77, 20);
            this.lblByAuthor.TabIndex = 4;
            this.lblByAuthor.Text = "By author";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splashPageMenuItem,
            this.bookSearchToolStripMenuItem,
            this.helpMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splashPageMenuItem
            // 
            this.splashPageMenuItem.Name = "splashPageMenuItem";
            this.splashPageMenuItem.Size = new System.Drawing.Size(82, 20);
            this.splashPageMenuItem.Text = "Splash &Page";
            this.splashPageMenuItem.Click += new System.EventHandler(this.splashPageMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // btnSplashPage
            // 
            this.btnSplashPage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSplashPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashPage.Location = new System.Drawing.Point(12, 300);
            this.btnSplashPage.Name = "btnSplashPage";
            this.btnSplashPage.Size = new System.Drawing.Size(108, 28);
            this.btnSplashPage.TabIndex = 6;
            this.btnSplashPage.Text = "Splash &Page";
            this.btnSplashPage.UseVisualStyleBackColor = true;
            this.btnSplashPage.Click += new System.EventHandler(this.btnSplashPage_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(190, 300);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(108, 28);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(368, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSearch.Location = new System.Drawing.Point(368, 246);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(108, 28);
            this.btnBookSearch.TabIndex = 9;
            this.btnBookSearch.Text = "Book &Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.bookSearchToolStripMenuItem.Text = "Book Search";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click);
            // 
            // frmBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(488, 340);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnSplashPage);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblByAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.picbxBookCover);
            this.Name = "frmBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Details | AWD1100 Final Project";
            ((System.ComponentModel.ISupportInitialize)(this.picbxBookCover)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxBookCover;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblByAuthor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem splashPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button btnSplashPage;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
    }
}