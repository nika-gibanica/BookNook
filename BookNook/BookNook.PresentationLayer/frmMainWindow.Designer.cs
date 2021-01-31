
namespace BookNook.PresentationLayer
{
    partial class frmMainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReadBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOwnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWishlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllGoalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookGoalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksReadToolStripMenuItem,
            this.tBRToolStripMenuItem,
            this.ownedToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.wishlistToolStripMenuItem,
            this.goalsToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(977, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksReadToolStripMenuItem
            // 
            this.booksReadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReadBooksToolStripMenuItem,
            this.addABookToolStripMenuItem});
            this.booksReadToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.booksReadToolStripMenuItem.Name = "booksReadToolStripMenuItem";
            this.booksReadToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
            this.booksReadToolStripMenuItem.Text = "Read";
            this.booksReadToolStripMenuItem.Click += new System.EventHandler(this.booksReadToolStripMenuItem_Click);
            // 
            // tBRToolStripMenuItem
            // 
            this.tBRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTBRToolStripMenuItem,
            this.addABookToolStripMenuItem1});
            this.tBRToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.tBRToolStripMenuItem.Name = "tBRToolStripMenuItem";
            this.tBRToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.tBRToolStripMenuItem.Text = "TBR";
            // 
            // ownedToolStripMenuItem
            // 
            this.ownedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOwnedToolStripMenuItem,
            this.addABookToolStripMenuItem2});
            this.ownedToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.ownedToolStripMenuItem.Name = "ownedToolStripMenuItem";
            this.ownedToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.ownedToolStripMenuItem.Text = "Owned";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBorrowedToolStripMenuItem,
            this.addABookToolStripMenuItem3});
            this.libraryToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(90, 28);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // wishlistToolStripMenuItem
            // 
            this.wishlistToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.wishlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewWishlistToolStripMenuItem,
            this.addABookToolStripMenuItem4});
            this.wishlistToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.wishlistToolStripMenuItem.Name = "wishlistToolStripMenuItem";
            this.wishlistToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.wishlistToolStripMenuItem.Text = "Wishlist";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllGoalsToolStripMenuItem,
            this.viewBookGoalsToolStripMenuItem,
            this.addAGoalToolStripMenuItem});
            this.goalsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.goalsToolStripMenuItem.Text = "Goals";
            // 
            // viewReadBooksToolStripMenuItem
            // 
            this.viewReadBooksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewReadBooksToolStripMenuItem.Name = "viewReadBooksToolStripMenuItem";
            this.viewReadBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.viewReadBooksToolStripMenuItem.Text = "View read";
            this.viewReadBooksToolStripMenuItem.Click += new System.EventHandler(this.viewReadBooksToolStripMenuItem_Click);
            // 
            // addABookToolStripMenuItem
            // 
            this.addABookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addABookToolStripMenuItem.Name = "addABookToolStripMenuItem";
            this.addABookToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.addABookToolStripMenuItem.Text = "Add a book";
            // 
            // viewTBRToolStripMenuItem
            // 
            this.viewTBRToolStripMenuItem.Name = "viewTBRToolStripMenuItem";
            this.viewTBRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewTBRToolStripMenuItem.Text = "View TBR";
            // 
            // addABookToolStripMenuItem1
            // 
            this.addABookToolStripMenuItem1.Name = "addABookToolStripMenuItem1";
            this.addABookToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addABookToolStripMenuItem1.Text = "Add a book";
            // 
            // viewOwnedToolStripMenuItem
            // 
            this.viewOwnedToolStripMenuItem.Name = "viewOwnedToolStripMenuItem";
            this.viewOwnedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewOwnedToolStripMenuItem.Text = "View owned";
            // 
            // addABookToolStripMenuItem2
            // 
            this.addABookToolStripMenuItem2.Name = "addABookToolStripMenuItem2";
            this.addABookToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.addABookToolStripMenuItem2.Text = "Add a book";
            // 
            // viewBorrowedToolStripMenuItem
            // 
            this.viewBorrowedToolStripMenuItem.Name = "viewBorrowedToolStripMenuItem";
            this.viewBorrowedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewBorrowedToolStripMenuItem.Text = "View borrowed";
            // 
            // addABookToolStripMenuItem3
            // 
            this.addABookToolStripMenuItem3.Name = "addABookToolStripMenuItem3";
            this.addABookToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.addABookToolStripMenuItem3.Text = "Add a book";
            // 
            // viewWishlistToolStripMenuItem
            // 
            this.viewWishlistToolStripMenuItem.Name = "viewWishlistToolStripMenuItem";
            this.viewWishlistToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewWishlistToolStripMenuItem.Text = "View wishlist";
            // 
            // addABookToolStripMenuItem4
            // 
            this.addABookToolStripMenuItem4.Name = "addABookToolStripMenuItem4";
            this.addABookToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.addABookToolStripMenuItem4.Text = "Add a book";
            // 
            // viewAllGoalsToolStripMenuItem
            // 
            this.viewAllGoalsToolStripMenuItem.Name = "viewAllGoalsToolStripMenuItem";
            this.viewAllGoalsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewAllGoalsToolStripMenuItem.Text = "View all goals";
            // 
            // viewBookGoalsToolStripMenuItem
            // 
            this.viewBookGoalsToolStripMenuItem.Name = "viewBookGoalsToolStripMenuItem";
            this.viewBookGoalsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewBookGoalsToolStripMenuItem.Text = "View book goals";
            // 
            // addAGoalToolStripMenuItem
            // 
            this.addAGoalToolStripMenuItem.Name = "addAGoalToolStripMenuItem";
            this.addAGoalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addAGoalToolStripMenuItem.Text = "Add a goal";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bradley Hand ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(136, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(643, 150);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "BookNook";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(977, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Felix Titling", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMainWindow";
            this.Text = "BookNook";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReadBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOwnedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewWishlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem viewAllGoalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookGoalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAGoalToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

