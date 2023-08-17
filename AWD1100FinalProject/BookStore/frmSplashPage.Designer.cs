namespace BookStore
{
    partial class frmSplashPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.imgStephenKing = new System.Windows.Forms.PictureBox();
            this.imgSuzanneCollins = new System.Windows.Forms.PictureBox();
            this.imgJKRowling = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStephenKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSuzanneCollins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJKRowling)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookSearchMenuItem,
            this.helpMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookSearchMenuItem
            // 
            this.bookSearchMenuItem.Name = "bookSearchMenuItem";
            this.bookSearchMenuItem.Size = new System.Drawing.Size(84, 20);
            this.bookSearchMenuItem.Text = "Book &Search";
            this.bookSearchMenuItem.Click += new System.EventHandler(this.bookSearchMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "&Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(426, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(522, 69);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSearch.Location = new System.Drawing.Point(12, 364);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(108, 28);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "Book &Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(219, 364);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(108, 28);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // imgStephenKing
            // 
            this.imgStephenKing.ErrorImage = null;
            this.imgStephenKing.Image = ((System.Drawing.Image)(resources.GetObject("imgStephenKing.Image")));
            this.imgStephenKing.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgStephenKing.InitialImage")));
            this.imgStephenKing.Location = new System.Drawing.Point(12, 112);
            this.imgStephenKing.Name = "imgStephenKing";
            this.imgStephenKing.Size = new System.Drawing.Size(155, 233);
            this.imgStephenKing.TabIndex = 17;
            this.imgStephenKing.TabStop = false;
            // 
            // imgSuzanneCollins
            // 
            this.imgSuzanneCollins.ErrorImage = null;
            this.imgSuzanneCollins.Image = ((System.Drawing.Image)(resources.GetObject("imgSuzanneCollins.Image")));
            this.imgSuzanneCollins.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgSuzanneCollins.InitialImage")));
            this.imgSuzanneCollins.Location = new System.Drawing.Point(196, 112);
            this.imgSuzanneCollins.Name = "imgSuzanneCollins";
            this.imgSuzanneCollins.Size = new System.Drawing.Size(155, 233);
            this.imgSuzanneCollins.TabIndex = 18;
            this.imgSuzanneCollins.TabStop = false;
            // 
            // imgJKRowling
            // 
            this.imgJKRowling.ErrorImage = null;
            this.imgJKRowling.Image = ((System.Drawing.Image)(resources.GetObject("imgJKRowling.Image")));
            this.imgJKRowling.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgJKRowling.InitialImage")));
            this.imgJKRowling.Location = new System.Drawing.Point(379, 112);
            this.imgJKRowling.Name = "imgJKRowling";
            this.imgJKRowling.Size = new System.Drawing.Size(155, 233);
            this.imgJKRowling.TabIndex = 19;
            this.imgJKRowling.TabStop = false;
            // 
            // frmSplashPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(546, 404);
            this.Controls.Add(this.imgJKRowling);
            this.Controls.Add(this.imgSuzanneCollins);
            this.Controls.Add(this.imgStephenKing);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSplashPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Page | AWD1100 Final Project";
            this.Load += new System.EventHandler(this.frmBookStore_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStephenKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSuzanneCollins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJKRowling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem bookSearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox imgStephenKing;
        private System.Windows.Forms.PictureBox imgSuzanneCollins;
        private System.Windows.Forms.PictureBox imgJKRowling;
    }
}

