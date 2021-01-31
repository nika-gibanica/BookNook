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
    public class LibraryController
    {
		public void AddNewLibraryBook(IAddNewLibraryBookView inForm, ILibraryRepository libraryRepository)
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
					DateTime dateBorrowed = inForm.DateBorrowed;
					DateTime dueDate = inForm.DueDate;
					string library = inForm.Library;

					BookLibrary newLibrary = BookFactory.CreateBookLibrary(title, author, publisher, datePub, numPages, genre, dateBorrowed, dueDate, library);

					libraryRepository.AddBookLibrary(newLibrary);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewLibraryBooks(IShowLibraryBookListView inForm, ILibraryRepository libraryRepository, IMainController mainController)
		{
			List<BookLibrary> listBooks = libraryRepository.getListBooksLibrary();

			inForm.ShowModaless(mainController, listBooks);
		}
	}
}
