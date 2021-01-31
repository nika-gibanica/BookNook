using System;
using System.Collections.Generic;
using System.Text;
using BookNook.Base;
using BookNook.DomainModel.Repositories;
using BookNook.DomainModel;
using BookNook.DomainModel.Factories;
using System.Windows.Forms;

namespace BookNook.Controllers
{
    public class ReadController
    {
		public void AddNewReadBook(IAddNewReadBookView inForm, IReadRepository readRepository)
		{
			if (inForm.ShowViewModal() == true)
			{
				try
				{
					string title = inForm.Title;
					string author = inForm.Author;
					string publisher = inForm.Publisher;
					DateTime datePub = inForm.DatePublished;
					int numPages = inForm.NumberOfPages;
					string genre = inForm.Genre;
					DateTime dateRead = inForm.DateRead;
					int rating = inForm.Rating;

					BookRead newRead = BookFactory.CreateBookRead(title, author, publisher, datePub, numPages, genre, dateRead, rating);

					readRepository.AddBookRead(newRead);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewReadBooks(IShowReadBookListView inForm, IReadRepository readRepository, IMainController mainController)
		{
			List<BookRead> listBooks = readRepository.getListBooksRead();

			inForm.ShowModaless(mainController, listBooks);
		}
	}
}
