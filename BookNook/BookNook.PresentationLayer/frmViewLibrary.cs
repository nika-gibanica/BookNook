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
    public partial class frmViewLibrary : Form, IShowLibraryBookListView
    {
        private List<BookLibrary> _listBooks = null;
        private IMainController _mainController = null;
        
        public frmViewLibrary()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController inMainController, List<BookLibrary> inListBooks)
        {
            _mainController = inMainController;
            _listBooks = inListBooks;

            UpdateList();

            this.Show();
        }

        private void addNewReadButton_Click(object sender, EventArgs e)
        {
            _mainController.AddBookLibrary();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateList()
        {
            for (int i = 0; i < _listBooks.Count(); i++)
            {
                BookLibrary book = _listBooks[i];

                string bookAuthor = book.Author;
                string bookPublisher = book.Publisher;
                string bookDatePublished = book.DatePublished.ToString();
                string bookGenre = book.Genre;
                string bookPages = book.NumPages.ToString();
                string bookBorrowed = book.DateBorrowed.ToString();
                string bookDue = book.DueDate.ToString();
                string bookFrom = book.Library;

                ListViewItem lvt = new ListViewItem(book.Title);
                lvt.SubItems.Add(bookAuthor);
                lvt.SubItems.Add(bookPublisher);
                lvt.SubItems.Add(bookDatePublished);
                lvt.SubItems.Add(bookPages);
                lvt.SubItems.Add(bookGenre);
                lvt.SubItems.Add(bookBorrowed);
                lvt.SubItems.Add(bookDue);
                lvt.SubItems.Add(bookFrom);

                listLibrary.Items.Add(lvt);
            }
        }

        private void frmViewLibrary_Load(object sender, EventArgs e)
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
