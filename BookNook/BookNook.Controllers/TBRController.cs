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
    public class TBRController
    {
		public void AddNewTBRBook(IAddNewTBRBookView inForm, ITBRRepository tbrRepository)
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
					string recommendedBy = inForm.RecommendedBy;

					BookTBR newTBR = BookFactory.CreateBookTBR(title, author, publisher, datePub, numPages, genre, recommendedBy);

					tbrRepository.AddBookTBR(newTBR);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewTBRBooks(IShowTBRBookListView inForm, ITBRRepository tbrRepository, IMainController mainController)
		{
			List<BookTBR> listBooks = tbrRepository.getListBooksTBR();

			inForm.ShowModaless(mainController, listBooks);
		}
	}
}
