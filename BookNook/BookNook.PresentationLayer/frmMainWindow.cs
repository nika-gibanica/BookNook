using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookNook.Controllers;

namespace BookNook.PresentationLayer
{
    public partial class frmMainWindow : Form
    {
        private readonly MainFormController _controller;

        public frmMainWindow(MainFormController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            _controller.LoadDefaultModel();
        }

        private void booksReadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewReadBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowReadBooks();
        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddBookRead();
        }

        private void viewTBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowTBRBooks();
        }

        private void addABookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _controller.AddBookTBR();
        }

        private void viewOwnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowOwnedBooks();
        }

        private void addABookToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _controller.AddBookOwned();
        }

        private void viewLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowLibraryBooks();
        }

        private void addABookToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _controller.AddBookLibrary();
        }

        private void viewWishlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowWishlistBooks();
        }

        private void addABookToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _controller.AddBookWishlist();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
