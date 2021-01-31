using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookNook.DomainModel;
using BookNook.Base;

namespace BookNook.PresentationLayer
{
    public partial class frmViewRead : Form, IShowReadBookListView
    {
        private List<BookRead> _listBooks = null;
        private IMainController _mainController = null;
        
        public frmViewRead()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController inMainController, List<BookRead> inListBooks)
        {
            _mainController = inMainController;
            _listBooks = inListBooks;

            UpdateList();

            this.Show();
        }

        private void addNewReadButton_Click(object sender, EventArgs e)
        {
            _mainController.AddBookRead();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateList()
        {
            for (int i = 0; i < _listBooks.Count(); i++)
            {
                BookRead book = _listBooks[i];

                string bookAuthor = book.Author;
                string bookPublisher = book.Publisher;
                string bookDatePublished = book.DatePublished.ToString();
                string bookGenre = book.Genre;
                string bookPages = book.NumPages.ToString();
                string bookFinished = book.DateRead.ToString();
                string bookRating = book.Rating.ToString();

                ListViewItem lvt = new ListViewItem(book.Title);
                lvt.SubItems.Add(bookAuthor);
                lvt.SubItems.Add(bookPublisher);
                lvt.SubItems.Add(bookDatePublished);
                lvt.SubItems.Add(bookPages);
                lvt.SubItems.Add(bookGenre);
                lvt.SubItems.Add(bookFinished);
                lvt.SubItems.Add(bookRating);

                listRead.Items.Add(lvt);
            }
        }

        private void frmViewRead_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
