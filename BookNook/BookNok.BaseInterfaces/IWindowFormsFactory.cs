using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel.Repositories;

namespace BookNook.Base
{
	public interface IWindowFormsFactory
	{
		IAddNewReadBookView CreateAddNewReadBookView();
		IShowReadBookListView CreateShowReadBookListView();
		IAddNewTBRBookView CreateAddNewTBRBookView();
		IShowTBRBookListView CreateShowTBRBookListView();
		IAddNewOwnedBookView CreateAddNewOwnedBookView();
		IShowOwnedBookListView CreateShowOwnedBookListView();
		IAddNewLibraryBookView CreateAddNewLibraryBookView();
		IShowLibraryBookListView CreateShowLibraryBookListView();
		IAddNewWishlistBookView CreateAddNewWishlistBookView();
		IShowWishlistBookListView CreateShowWishlistBookListView();

	}
}
