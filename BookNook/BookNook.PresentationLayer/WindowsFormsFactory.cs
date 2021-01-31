using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookNook.Base;
using BookNook.DomainModel.Repositories;
using BookNook.Controllers;

namespace BookNook.PresentationLayer
{
	public class WindowFormsFactory : IWindowFormsFactory
	{
		public IAddNewReadBookView CreateAddNewReadBookView()
		{
			var newFrm = new frmAddRead();

			return newFrm;
		}
		public IShowReadBookListView CreateShowReadBookListView()
		{
			var newFrm = new frmViewRead();

			return newFrm;
		}

		public IAddNewTBRBookView CreateAddNewTBRBookView()
		{
			var newFrm = new frmAddTBR();

			return newFrm;
		}
		public IShowTBRBookListView CreateShowTBRBookListView()
		{
			var newFrm = new frmViewTBR();

			return newFrm;
		}

		public IAddNewOwnedBookView CreateAddNewOwnedBookView()
		{
			var newFrm = new frmAddOwned();

			return newFrm;
		}
		public IShowOwnedBookListView CreateShowOwnedBookListView()
		{
			var newFrm = new frmViewOwned();

			return newFrm;
		}

		public IAddNewLibraryBookView CreateAddNewLibraryBookView()
		{
			var newFrm = new frmAddLibrary();

			return newFrm;
		}
		public IShowLibraryBookListView CreateShowLibraryBookListView()
		{
			var newFrm = new frmViewLibrary();

			return newFrm;
		}

		public IAddNewWishlistBookView CreateAddNewWishlistBookView()
		{
			var newFrm = new frmAddWishlist();

			return newFrm;
		}
		public IShowWishlistBookListView CreateShowWishlistBookListView()
		{
			var newFrm = new frmViewWishlist();

			return newFrm;
		}
	}
}
