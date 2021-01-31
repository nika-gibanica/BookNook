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
    public class OwnedController
    {
		public void AddNewOwnedBook(IAddNewOwnedBookView inForm, IOwnedRepository ownedRepository)
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
					decimal price = inForm.Price;
					string placeBought = inForm.PlaceBought;
					bool read = inForm.Read;

					BookOwned newOwned = BookFactory.CreateBookOwned(title, author, publisher, datePub, numPages, genre, price, placeBought, read);

					ownedRepository.AddBookOwned(newOwned);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewOwnedBooks(IShowOwnedBookListView inForm, IOwnedRepository ownedRepository, IMainController mainController)
		{
			List<BookOwned> listBooks = ownedRepository.getListBooksOwned();

			inForm.ShowModaless(mainController, listBooks);
		}
	}
}
