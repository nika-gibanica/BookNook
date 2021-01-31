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
    public class WishlistController
    {
		public void AddNewWishlistBook(IAddNewWishlistBookView inForm, IWishlistRepository wishlistRepository)
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

					BookWishlist newWishlist = BookFactory.CreateBookWishlist(title, author, publisher, datePub, numPages, genre, price);

					wishlistRepository.AddBookWishlist(newWishlist);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewWishlistBooks(IShowWishlistBookListView inForm, IWishlistRepository wishlistRepository, IMainController mainController)
		{
			List<BookWishlist> listBooks = wishlistRepository.getListBooksWishlist();

			inForm.ShowModaless(mainController, listBooks);
		}
	}
}
